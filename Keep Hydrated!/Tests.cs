using NUnit.Framework;
using System;

[TestFixture]
public class Tests
{
  public static Random rng = new Random();
  
  [Test]
  [TestCase(2, ExpectedResult = 1)]
  [TestCase(1.4, ExpectedResult = 0)]
  [TestCase(12.3, ExpectedResult = 6)]
  [TestCase(0.82, ExpectedResult = 0)]
  [TestCase(11.8, ExpectedResult = 5)]
  [TestCase(1787, ExpectedResult = 893)]
  [TestCase(0, ExpectedResult = 0)]
  public static int FixedTest(double d)
  {
    return Kata.Litres(d);
  }
  
  [Test]
  public static void RandomTest([Random(0,10000,100)] double d)
  {
    Assert.AreEqual((int)(d * 0.5), Kata.Litres(d));
  }
}