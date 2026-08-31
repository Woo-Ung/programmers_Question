using System;
using System.Collections.Generic;

public class Solution 
{
    public string[] solution(string my_string) 
    { 
        string[] temp = new string[my_string.Length];
        
        List<string> mString = new List<string> {};
        
        for(int i = 0; i<my_string.Length;i++)
        {
            for(int j = i; j<my_string.Length;j++)
            {
                temp[i] += my_string[j].ToString();
            }
        }
        
        for(int i = 0; i <temp.Length; i++)
        {
            mString.Add(temp[i]);
        }
        
        mString.Sort();
        
        string[] answer = new string[temp.Length];  
        
        for(int i = 0; i <temp.Length; i++)
        {
            answer[i] = mString[i];
        }
        
        return answer;
    }
}