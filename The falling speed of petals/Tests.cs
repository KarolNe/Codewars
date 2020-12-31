using NUnit.Framework;
using System;
using System.Collections.Generic;

  [TestFixture]
  public class SampleTest
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData(5).Returns(80);
      }
    }
  
    [Test, TestCaseSource("testCases")]
    public double Test(double v) =>
      Kata.SakuraFall(v);
  }
  
  [TestFixture]
  public class FixedTest
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        yield return new TestCaseData(10).Returns(40);
        yield return new TestCaseData(200).Returns(2);
        yield return new TestCaseData(-1).Returns(0);
        yield return new TestCaseData(0).Returns(0);
        yield return new TestCaseData(12.3).Returns(400 / 12.3);
        yield return new TestCaseData(3).Returns(400 / 3.0);
      }
    }
  
    [Test, TestCaseSource("testCases")]
    public double Test(double v) =>
      Kata.SakuraFall(v);
  }
  
  [TestFixture]
  public class RandomTest
  {
    private static IEnumerable<TestCaseData> testCases
    {
      get
      {
        Random rnd = new Random();
        
        for (int i = 0; i < 100; ++i)
        {
          double v = rnd.NextDouble() * 1000 - 500;
          yield return new TestCaseData(v).Returns(v <= 0 ? 0 : 400 / v);
        }
      }
    }
  
    [Test, TestCaseSource("testCases")]
    public double Test(double v) =>
      Kata.SakuraFall(v);
  }