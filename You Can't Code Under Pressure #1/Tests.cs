using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Solution
{
  [TestFixture]
  public class CodeWarsTest
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData(2).Returns(4);
        yield return new TestCaseData(4).Returns(8);
        yield return new TestCaseData(-10).Returns(-20);
        yield return new TestCaseData(0).Returns(0);
        yield return new TestCaseData(100).Returns(200);
      }
    }
  
    [Test, TestCaseSource("testCases")]
    public int Test(int n) => Kata.DoubleInteger(n);
    
    private static Random rnd = new Random();
    
    [Test, Description("Random Tests")]
    public void RandomTests()
    {
      for (int i = 0; i < 100; ++i)
      {
        int n = rnd.Next(-1 * (int)Math.Pow(2, 28), (int)Math.Pow(2, 28));
        Assert.AreEqual(n * 2, Kata.DoubleInteger(n));
      }
    }
  }
}