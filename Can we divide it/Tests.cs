using NUnit.Framework;
using System;

  [TestFixture]
  public class BasicSolutionTest
  {
    [Test]
    public void BasicTest()
    {
      Assert.AreEqual(true, Kata.is_divide_by(8, 2, 4));
      Assert.AreEqual(true, Kata.is_divide_by(12, -3, 4));
      Assert.AreEqual(false, Kata.is_divide_by(8, 3, 4));
      Assert.AreEqual(false, Kata.is_divide_by(48, 2, -5));
      Assert.AreEqual(true, Kata.is_divide_by(-100, -25, 10));
      Assert.AreEqual(false, Kata.is_divide_by(10000, 5, -3));
      Assert.AreEqual(true, Kata.is_divide_by(4, 4, 2));
      Assert.AreEqual(false, Kata.is_divide_by(5, 2, 3));
      Assert.AreEqual(false, Kata.is_divide_by(-96, 25, 17));
      Assert.AreEqual(true, Kata.is_divide_by(33, 1, 33));
    }
  }


  [TestFixture]
  public class RandomTest
  {
    private static bool check(int number, int a, int b)
    {
      return !(number % a != 0 || number % b != 0);
    }
    [Test]
    public void PositiveRandomTest()
    {
      Random rnd = new Random();
      for (int i = 0; i<100; i++)
      {
      int number = rnd.Next(1, 10000);
      int a = rnd.Next(1, 4);
      int b = rnd.Next(1, 7);
      Console.WriteLine("Testing for is_divide_by({0}, {1}, {2})", number, a, b);
      Assert.AreEqual(RandomTest.check(number, a, b), Kata.is_divide_by(number, a, b));
      }
    }
    [Test]
    public void NegativeRandomTest()
    {
      Random rnd = new Random();
      for (int i = 0; i<100; i++)
      {
      int number = rnd.Next(-10000, 1000);
      int a = rnd.Next(-4, -1);
      int b = rnd.Next(-7, -1);
      Console.WriteLine("Testing for is_divide_by({0}, {1}, {2})", number, a, b);
      Assert.AreEqual(RandomTest.check(number, a, b), Kata.is_divide_by(number, a, b));
      }
    }
  }
