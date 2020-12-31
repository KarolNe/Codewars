using NUnit.Framework;
using System;

[TestFixture]
class Tests
{
    [TestCase(10, 5)]
    [TestCase(100, 40)]
    public void ATrueHero(int bullets, int dragons)
    {
        Assert.IsTrue(Kata.Hero(bullets, dragons));
    }

    [TestCase(4, 5)]
    [TestCase(1500, 751)]
    [TestCase(0, 1)]
    [TestCase(7, 4)]
    public void AFalseHero(int bullets, int dragons)
    {
        Assert.IsFalse(Kata.Hero(bullets, dragons));
    }

    [Test]
    public void IsHeAHero()
    {
        var rnd = new Random();
        for (int i = 0; i < 100; i++)
        {
            var bullets = rnd.Next(0, 1001);
            var dragons = rnd.Next(0, bullets + 1);
            var expected = SolutionHero(bullets, dragons);
            Assert.That(Kata.Hero(bullets, dragons), Is.EqualTo(expected));
        }
    }

    bool SolutionHero(int bullets, int dragons) => bullets >= dragons * 2;
}