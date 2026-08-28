using System;

public class Solution 
{
    public int solution(int n, int k) 
    {
        int lambM = 12000;
        int drinkM = 2000;
        int totalM = 0;
        
        totalM = lambM * n + drinkM * (k - (n / 10));
                
        return totalM;
    }
}