using NUnit.Framework;
using System;
using System.Linq;

[TestFixture]
public class SolutionTest
{
    private static double epsilon = 1e-6;
    
    private static Random rnd = new Random();
    
    [Test, Description("Fixed Tests (in random order)")]
    public void SampleTest()
    {
      Action[] tests = new Action[]
      {
        () => Assert.That(0, Is.EqualTo(Kata.DistanceBetweenPoints(new Point(3, 3), new Point(3, 3))).Within(epsilon)),
        () => Assert.That(5, Is.EqualTo(Kata.DistanceBetweenPoints(new Point(1, 6), new Point(4, 2))).Within(epsilon)),
        () => Assert.That(10.728001, Is.EqualTo(Kata.DistanceBetweenPoints(new Point(-10.2, 12.5), new Point(0.3, 14.7))).Within(epsilon)),
      };
      tests.OrderBy(x => rnd.Next()).ToList().ForEach(a => a.Invoke());
    }
    
    [Test, Description("Random Tests")]
    public void RandomTest()
    {
      for (int i = 0; i < 1000; ++i)
      {
        Point a = new Point((rnd.NextDouble() * 100 - 50), (rnd.NextDouble() * 100 - 50));
        Point b = new Point((rnd.NextDouble() * 100 - 50), (rnd.NextDouble() * 100 - 50));
        double expected = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        double actual = Kata.DistanceBetweenPoints(a, b);
        Assert.That(expected, Is.EqualTo(actual).Within(epsilon));
      }
    }
}