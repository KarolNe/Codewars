using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

  [TestFixture]
  public class Test
  {
    private static Random rand = new Random();
    
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual(new int[] {-1,-2,-3,-4,-5}, ArraysInversion.InvertValues(new int[] {1,2,3,4,5}));
      Assert.AreEqual(new int[] {-1,2,-3,4,-5}, ArraysInversion.InvertValues(new int []{1,-2,3,-4,5}));
      Assert.AreEqual(new int[] {}, ArraysInversion.InvertValues(new int[] {}));
      Assert.AreEqual(new int[] {0}, ArraysInversion.InvertValues(new int[] {0}));
    }
    
    private static int[] Solve(int[] input)
    {
      return input.Select(x => x*(-1)).ToArray();
    }
    
    private static int[] GenerateArr() {
        List<int> numbers = new List<int>(); 
        int n = rand.Next(5, 100);
        for(int i = 0; i < n; i++) {
           numbers.Add(rand.Next(-100,100));
        }
        return numbers.ToArray();
    }
    
    [Test]
    public void RandomTests()
    {
      Random rand = new Random();
      for (int i = 0; i < 100; i++)
      {
        int[] arr = GenerateArr();
        Assert.AreEqual(Solve(arr),ArraysInversion.InvertValues(arr));
      }  
    } 
  }