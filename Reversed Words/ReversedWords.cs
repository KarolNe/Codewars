/*
Complete the solution so that it reverses all of the words within the string passed in.

Example:

Kata.ReverseWords("The greatest victory is that which requires no battle");
// should return "battle no requires which that is victory greatest The"
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Kata
{
  public static string ReverseWords(string str)
  {
    string answer = string.Join(" ",str.Split(' ').Reverse());
    
    return answer;
  }
}