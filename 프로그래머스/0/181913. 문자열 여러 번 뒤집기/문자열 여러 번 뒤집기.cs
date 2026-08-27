using System;

public class Solution 
{
    public string solution(string my_string, int[,] queries) 
    {
        string[] myS = new string[queries.GetLength(0) + 1];

        myS[0] = my_string;
        string answer = "";
        for (int j = 0; j < queries.GetLength(0); j++)
        {
            for (int i = 0; i < queries[j, 0]; i++)
            {
                myS[j + 1] += myS[j][i];
            }
            for (int i = queries[j, 1]; i >= queries[j, 0]; i--)
            {
                myS[j + 1] += myS[j][i];
            }
            if (queries[j, 1] + 1 < my_string.Length)
            {
                for (int i = queries[j, 1] + 1; i < my_string.Length; i++)
                {
                    myS[j + 1] += myS[j][i];
                }
            }

        }
        return answer = myS[queries.GetLength(0)];
    }
}