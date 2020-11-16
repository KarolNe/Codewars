/*
Clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.

Your task is to make 'Past' function which returns time converted to milliseconds.

Example:
Past(0, 1, 1) == 61000
Input constraints: 0 <= h <= 23, 0 <= m <= 59, 0 <= s <= 59
*/

using System;
  
public static class Clock
{
  public static int Past(int h, int m, int s)
  {
      int hrs = h * 3600000;
      int min = m * 60000;
      int sec = s * 1000;
      int seconds = hrs + min + sec;
    
      return seconds;
  }
}