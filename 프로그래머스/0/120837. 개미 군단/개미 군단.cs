using System;

public class Solution 
{
    public int solution(int hp)
    {
        int answer = 0;
        
        int a = hp % 5;
        answer += (hp/5);
        if(a != 0)
        {
            int b = a % 3;
            answer += (a/3);
            if(b != 0)
            {                
                answer += (b/1);            
            }
        }       
        
        return answer;
    }
}