using System;
using System.Collections.Generic;

public class Solution 
{
    public List<int> solution(int n, int[] slicer, int[] num_list) 
    {
        List<int> answer = new List<int>();
        int a=0;
        int b=0;
        int c = 1;
        switch(n)
        {
            case 1:
                a = 0;
                b = slicer[1];
                break;
            case 2:
                a = slicer[0];
                b = num_list.Length - 1;
                break;
            case 3:
                a = slicer[0];
                b = slicer[1];
                break;
            case 4:
                a = slicer[0];
                b = slicer[1];
                c = 2;
                break;
            default:
                break;
        }
        
        for(int i = a; i <= b; i += c)
        {
            answer.Add(num_list[i]);
        }        
        
        return answer;
    }
}