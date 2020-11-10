using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

[TestFixture]
public class Tests
{
	private static IEnumerable<TestCaseData> sampleTestCases
	{
		get
		{
			yield return new TestCaseData(new int[] {1,2,2}).Returns(9);
			yield return new TestCaseData(new int[] {1,2}).Returns(5);
			yield return new TestCaseData(new int[] {5,3,4}).Returns(50);
		}
	}

	[Test, TestCaseSource("sampleTestCases"), Description("Sample Tests")]
	public int SampleTest(int[] n) => Kata.SquareSum(n);
  
	private static Random rnd = new Random();
  
	private static int Solution(int[] n) => n.Sum((v) => v * v);
  
	[Test, Description("Random Tests")]
	public void RandomTest()
	{
		for (int i = 0; i < 100; ++i)
		{	
			int[] test = new int[rnd.Next(1, 10)].Select(_ => rnd.Next(0, 1000)).ToArray();
			int expected = Solution(test);
			int actual = Kata.SquareSum(test);
			Assert.AreEqual(expected, actual);
		}
	}
}