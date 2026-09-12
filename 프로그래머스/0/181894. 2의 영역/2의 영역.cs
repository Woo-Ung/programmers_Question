using System;
using System.Collections.Generic;

public class Solution 
{
    public List<int> solution(int[] arr) 
    {
        List<int> answer = new List<int>();
        int a =-1;
        int b =-1;
        
         for(int i = 0; i < arr.Length;i++)
        {
             if(arr[i] == 2 )
             {
                 if(a == -1)
                 {
                    a = i;
                 }
                 else
                 {
                     b = i;
                 }
             }
         }
        
        if(a == -1)
        {
           answer.Add(-1);
        }
        
        else if (b == -1)
        {
            answer.Add(arr[a]);
        }
        
        else
        for(int i = a; i <= b;i++)
        {
            answer.Add(arr[i]);
        }
        return answer;
    }
}