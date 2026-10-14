using System;
using System.Collections.Generic;

public class Solution {
    public List<string> solution(string[] str_list) 
    {
        string[] answer = new string[str_list.Length];
        int num = 0;
        bool isL = false;
        bool isExist = false;
        for(int i = 0; i < str_list.Length; i++)
        {
            if(str_list[i] == "l")
            {
                isExist = true;
                isL = true;
                num = i;
                break;
            }
            else if(str_list[i] == "r")
            {
                isExist = true;
                isL = false;
                num = i+1;
                break;
            }
            answer[i] = str_list[i];
        }
        
        List<string> answer2 = new List<string>();
        if(!isExist)
        {
            return answer2;
        }
        
        if(isL)
        {
             for(int i = 0; i < num; i++)
             {
                 answer2.Add(answer[i]);
             }
        }
        
        else
        {
            for(int i = num; i < str_list.Length; i++)
             {                
                 answer2.Add(str_list[i]);
             }
        }
        
        return answer2;
    }

}