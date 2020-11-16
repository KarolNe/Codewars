using NUnit.Framework;
using System;
using System.Linq;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void BasicTests()
    {
      Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
      Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
      Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
      Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
      Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
    }
    
    [Test]
    public void RandomTests()
    {
      var rand = new Random();
      
      for(int k = 0; k < 40; ++k)
      {
        var length = rand.Next(0, 30);
        var str = string.Concat(Enumerable.Range(0, length).Select(a => rand.Next(1,11) % 4 == 0 ? ' ' : (char)rand.Next(65,90)));
        
        Assert.AreEqual(string.Join(" ", str.Split(' ').Reverse()), Kata.ReverseWords(str), str + " wasn't reversed correctly!");
      }
    }
  }