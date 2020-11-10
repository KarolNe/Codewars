using NUnit.Framework;
using System;
using System.Linq;

[TestFixture]
public class SolutionTest
{
	public static Random rnd = new Random();
  
	[Test]
	public void SampleTest()
	{
		Assert.That(Kata.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
	}	
    
	private static string randStr()
	{
		int len = rnd.Next(10, 50);
		return String.Concat(new char[len].Select(_ => (char)(rnd.Next(0, 25) + 97)));
	}
    
	[Test]
	public void RandomTest()
	{
		for (int i = 0; i < 100; ++i)
		{
			string testCase = randStr();
			Assert.That(Kata.Greet(testCase), Is.EqualTo($"Hello, {testCase} how are you doing today?"));
		}
	}	
}
