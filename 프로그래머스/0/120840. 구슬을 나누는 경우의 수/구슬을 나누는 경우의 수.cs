using System;

public class Solution 
{
    public double solution(int balls, int share) 
    {
        double answer = 0;
        
        answer = Math.Round(Fact(balls) / (Fact(share) * Fact(balls - share)));
        
        return answer;
    }
    
    public static double Fact (int a)
    {
        double x = 1;
        for(int i = a; i>0;i--)
        {
            x *=i;
        }
        return x;
    }
}

