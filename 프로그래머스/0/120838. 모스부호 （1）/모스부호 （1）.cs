using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string letter) {
        string answer = "";        
        
        string[] morse = 
        {
            ".-","-...","-.-.","-..",".","..-.",
            "--.","....","..",".---","-.-",".-..",
            "--","-.","---",".--.","--.-",".-.",
            "...","-","..-","...-",".--","-..-",
            "-.--","--.."
        };
        string a = "";        
        
        List<string> mString = new List<string> {};
        
        for(int i = 0; i < letter.Length; i++)
        {
            if(letter[i] == ' ')
            {   
                mString.Add(a);
                a = "";
                continue;
            }            
            a += letter[i];   
            if(i == letter.Length - 1)
            {
                mString.Add(a);
                a = "";
            }
        }
        
        for(int i = 0; i<mString.Count; i++)
        {
            for(int j = 0; j<morse.Length; j++)
            {
                if(mString[i] == morse[j])
                {
                    answer += ((char)(j + 97)).ToString();
                }
            }
        }
        
        return answer;
    }
}