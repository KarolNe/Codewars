using System;
using NUnit.Framework;

[TestFixture]
public static class KataTests 
{

  static Random random = new Random();

[Test]
    public static void BasicTests() 
    {
        Assert.AreEqual(1, Kata.summation(1));
        Assert.AreEqual(36, Kata.summation(8));
        Assert.AreEqual(253, Kata.summation(22));
        Assert.AreEqual(5050, Kata.summation(100));
        Assert.AreEqual(22791, Kata.summation(213));
        
    }
    
    [Test]
    public static void RandomTests() 
    {
      for(int i = 0; i < 100; i++)
      {
        int number = random.Next(1, 500);
        Assert.AreEqual(number*(number+1)/2, Kata.summation(number));
      }
        
    }
}