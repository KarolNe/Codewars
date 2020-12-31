using NUnit.Framework;
using System.Linq;

[TestFixture]
public class Tests
{
  [Test]
  [TestCase(2,10,2,ExpectedResult=new int[]{2,4,6,8,10})]
  [TestCase(1,10,3,ExpectedResult=new int[]{1,4,7,10})]
  [TestCase(1,10,1,ExpectedResult=new int[]{1,2,3,4,5,6,7,8,9,10})]
  [TestCase(1,10,4,ExpectedResult=new int[]{1,5,9})]
  [TestCase(1,10,5,ExpectedResult=new int[]{1,6})]
  public static int[] FixedTest(int min, int max, int step)
  {
    return Kata.GenerateRange(min, max,step);
  }
  
  private static int[] Solution(int min, int max, int step)
  {
    return Enumerable.Range(min, max - min + 1).Where(x => (x - min) % step == 0).ToArray();
  }
  
  [Test]
  public static void RandomTest([Random(1,10,100)]int step)
  {
    int min = 0;
    int max = 100;
    Assert.AreEqual(Solution(min,max,step), Kata.GenerateRange(min, max, step), string.Format("Should work for min = {0}, max = {1} and step = {2}", min, max, step));
  }
}