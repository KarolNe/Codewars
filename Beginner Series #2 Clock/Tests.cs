using NUnit.Framework;
using System;
  
  [TestFixture]
  public class ClockTest
  {
    [Test]
    public void RandomTests()
    {
     Random r = new Random();
     
      for(int d = 0; d < 100; d++){
        int i = r.Next(24);
        int j = r.Next(60);
        int s = r.Next(60); 
        Assert.AreEqual(Past(i,j,s), Clock.Past(i,j,s), "Failed at Past(" + i + "," + j + "," + s + ")");
      }
     }
     
    public int Past(int h, int m, int s)
    {
      return (h * 60 + m) * 60000 + s * 1000;
    }
  }