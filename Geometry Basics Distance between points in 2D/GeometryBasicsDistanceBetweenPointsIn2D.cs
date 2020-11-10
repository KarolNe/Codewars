/*
Description:
This series of katas will introduce you to basics of doing geometry with computers.

Point objects have x and y attributes (X and Y in C#) attributes.

Write a function calculating distance between Point a and Point b.

Tests round answers to 6 decimal places.
*/
using System;

public class Kata
{
	public static double DistanceBetweenPoints(Point a, Point b)
	{
		double corA =  Math.Pow(b.X-a.X, 2);
		double corB = Math.Pow(b.Y-a.Y, 2);
		
		double result = Math.Sqrt(corA + corB);

		return result;
	}
}
