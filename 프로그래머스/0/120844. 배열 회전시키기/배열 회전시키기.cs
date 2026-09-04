using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        if(direction == "right")
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0)
                {
                    answer[i] = numbers[numbers.Length-1];
                    continue;
                }                
                else
                {
                    answer[i] = numbers[i-1];
                }
            }
        }
        
        else
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == numbers.Length-1)
                {
                    answer[i] = numbers[0];
                    continue;
                }                
                else
                {
                    answer[i] = numbers[i+1];
                }
            }
        }
        
        return answer;
    }
}