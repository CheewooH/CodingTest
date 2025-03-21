using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int plus = 0;
        foreach (int num in num_list) // int num을 만들고 안에 int형 배열 num_list 을 넣는다
        {
            plus += num; // plus = plus + num; 덧샘을 누적한다
        }
        
        int multi = 1;
        foreach (int num in num_list)
        {
            multi *= num;
        }
        
        if (multi < (plus*plus))
        {
            return 1;
        }
        else 
        {
            return 0;
        }
    }
}