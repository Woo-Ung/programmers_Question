using System;
using System.Collections.Generic;

public class Solution 
{
    public List<int> solution(int[] arr, int[] query) 
    {
        List<int> answer = new List<int>();
        for(int i = 0; i< arr.Length;i++)
        {
            answer.Add(arr[i]);
        }        
        
        for(int i = 0; i<query.Length; i++)
        {
            if(i % 2 == 0)                
            {
                int a = answer.Count-1;
                for(int j = a ; j > query[i]; j--)
                {
                    answer.RemoveAt(j);
                }
            }
            else
            {                
                for(int j = query[i]-1 ; j >= 0; j--)
                {
                    answer.RemoveAt(j);
                }
            }
        }
        
        return answer;
    }
}