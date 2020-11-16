/*
It's the academic year's end, fateful moment of your school report. The averages must be calculated. All the students come to you and entreat you to calculate their average for them. Easy ! You just need to write a script.

Return the average of the given array rounded down to its nearest integer.

The array will never be empty.
*/

using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
    double sum = 0;
    
    for(int i=0 ; i < marks.Length; i++)
    {
      sum += marks[i];
    }
    int av = (int)(Math.Floor(sum/marks.Length));
    
    return av;
    
  }
}
