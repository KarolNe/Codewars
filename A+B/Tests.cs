using NUnit.Framework;
using System;  

[TestFixture]
public class FirstClassTest 
{
	[Test]
    public void testSum()
    {
		byte[] a = {1, 2, 3, 4, 5, 6, 7};
        byte[] b = {1, 3, 6, 8, 2, 5, 1};
        byte[] c = {2, 5, 9, 12, 7, 11, 8};
        
		for(int i = 0; i < c.Length; i++)
        {
            Assert.AreEqual(c[i], FirstClass.sum(a[i], b[i]));            
        }
    }
    
    [Test]
    public void testRandomSum()
    {
        Random rand = new Random(DateTime.Now.Second);
        byte a;
        byte b;
        
		for(int i = 0; i < 10; i++)
        {
            a = (byte) rand.Next(0, 128);
            b = (byte) rand.Next(0, 128 - a);
            Assert.AreEqual((byte) a + b, FirstClass.sum(a, b));
        }
    }
  }