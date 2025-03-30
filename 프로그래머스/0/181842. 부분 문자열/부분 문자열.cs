using System;

public class Solution 
{
    public int solution(string str1, string str2)
    {
        int index = str2.IndexOf(str1);
        if (index >= 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}