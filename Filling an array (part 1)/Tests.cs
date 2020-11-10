using NUnit.Framework;
using System;
using System.Linq;

[TestFixture]
public class SolutionTest
{
	private static Random rnd = new Random();
    
	[Test, Description("Kata.Arr creates a new array with the numbers 0 to N-1")]
	public void Tests()
	{
		Action[] tests = new Action[]
		{
			() => Assert.IsTrue(Kata.Arr(0).GetType().IsArray, "Kata.Arr creates a new array with the numbers 0 to N-1"),
			() => Assert.AreEqual(new int[0], Kata.Arr(0), "should return a blank array when called with no argument"),
			() => Assert.AreEqual(new int[] {0, 1, 2, 3}, Kata.Arr(4), "should return 0 to 3 when called with 4"),
			() => Assert.AreEqual(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, Kata.Arr(10), "should return 0 to 9 when called with 10"),
		};
		tests.OrderBy(x => rnd.Next()).ToList().ForEach(a => a.Invoke());
      
		// Random tests
		for (int i = 0; i < 100; ++i)
		{
			Func<int, int[]> solution = N => new int[N].Select((v, idx) => idx).ToArray();
			int n = rnd.Next(5, 15);
			int[] expected = solution(n);
			int[] actual = Kata.Arr(n);
			Assert.AreEqual(expected, actual, "should return 0 to N-1 where N is a random number");
			
		}
	}
}