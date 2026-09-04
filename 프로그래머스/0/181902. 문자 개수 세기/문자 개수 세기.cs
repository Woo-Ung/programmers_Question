using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        
        for(int i = 0; i<my_string.Length;i++)
        {
            if((int)my_string[i] >= (int)'a')
            {
                answer[((int)(my_string[i]-'a')) + 26]++;
            }
            else
            {
                answer[(int)(my_string[i]-'A')]++;
            }
            
        }
        
        return answer;
    }
}