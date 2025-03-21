using System;

public class Solution 
{
    public int solution(int[] num_list, int n) 
    {
        
        if(Array.IndexOf(num_list, n)!= -1)
        {
          return 1;  
        }
        else
        {
            return 0;
        }
    }
}