using System;

public class Solution 
{
    public string solution(string my_string, int[] indices) 
    {
        string answer = "";
        
        Array.Sort(indices);
        
        int count = 0;
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(count < indices.Length &&i == indices[count])
            {                
                count++;
                continue;
            }            
            answer += my_string[i];
        }        
        
        return answer;
    }
}