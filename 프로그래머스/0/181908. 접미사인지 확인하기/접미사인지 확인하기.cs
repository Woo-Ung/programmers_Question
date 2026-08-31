using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int answer = 0;
        
        bool isSame = false;
        
        int count = 1;
        for(int i = my_string.Length -1 ; i >= my_string.Length - is_suffix.Length; i--)
        {
            if(my_string.Length < is_suffix.Length)
            {
                isSame = false;                
                break;
            }
            if(my_string[i] == is_suffix[is_suffix.Length - count])
            {
                isSame = true;
            }
            else
            {
                isSame = false;                
                break;
            }
            count++;
        }
        
        return answer = isSame == true ? 1 : 0;
    }
}