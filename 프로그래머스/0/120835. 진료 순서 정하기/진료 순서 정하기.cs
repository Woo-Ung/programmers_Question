using System;

public class Solution 
{
    public int[] solution(int[] emergency) 
    {
        int[] answer = new int[emergency.Length];
        
        for(int i =0; i<emergency.Length; i++)
        {            
            for(int j = 0;j < emergency.Length;j++)
            {
                if(i == j)
                {
                    answer[i]++;
                    continue;
                }
                if(emergency[i] < emergency[j])
                {
                    answer[i]++;
                }
                else
                {
                    continue;
                }
            }
        }
        
        return answer;
    }
}