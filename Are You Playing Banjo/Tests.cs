using NUnit.Framework;
using System;

[TestFixture]
public class AreYouPlayingBanjo
{
  [Test]
  public static void Paul()
  {
    Assert.AreEqual("Paul does not play banjo", Kata.AreYouPlayingBanjo("Paul"));
  }
  
  [Test]
  public static void Adam()
  {
    Assert.AreEqual("Adam does not play banjo", Kata.AreYouPlayingBanjo("Adam"));
  }
  
  [Test]
  public static void Karol()
  {
    Assert.AreEqual("Karol does not play banjo", Kata.AreYouPlayingBanjo("Karol"));
  }
  
  [Test]
  public static void Ringo()
  {
    Assert.AreEqual("Ringo plays banjo", Kata.AreYouPlayingBanjo("Ringo"));
  }
  
  [Test]
  public static void bravo()
  {
    Assert.AreEqual("bravo does not play banjo", Kata.AreYouPlayingBanjo("bravo"));
  }
  
  [Test]
  public static void rolf()
  {
    Assert.AreEqual("rolf plays banjo", Kata.AreYouPlayingBanjo("rolf"));
  }
}