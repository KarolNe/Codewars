/*
I'm new to coding and now I want to get the sum of two arrays...actually the sum of all their elements. I'll appreciate for your help.

P.S. Each array includes only integer numbers. Output is a number too.
*/

using System;
public static class Kata
{
	public static int ArrayPlusArray(int[] arr1, int[] arr2)
	{
		int sumAR1 = 0;
		int sumAR2 = 0;
    
		for(int i = 0; i< arr1.Length;i++)
		{	
			sumAR1 += arr1[i];
		}
		
		for(int i = 0; i< arr2.Length;i++)
		{
			sumAR2 += arr2[i];
		}
    
    return sumAR1 + sumAR2;
  }
}