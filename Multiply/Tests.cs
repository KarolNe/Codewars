using NUnit.Framework;
using System;

[TestFixture]
public class CustomMathTest
{
	[Test]
	public void ShouldMultiple()
	{
		Assert.AreEqual(2, CustomMath.multiply(2, 1));
		Assert.AreEqual(8, CustomMath.multiply(2, 4));
	}
}