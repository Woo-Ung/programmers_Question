using System;

public class Solution {
    public string solution(int age) {
        string myString = age.ToString();
        string answer = "";
        for(int i = 0; i < myString.Length; i++)
        {
            answer += ((char)((int)(myString[i])+49)).ToString();
        }        
        return answer;
    }
}