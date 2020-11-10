using NUnit.Framework;
using System;

[TestFixture]
public class SetAlarmTest 
{
	[Test]
	public void Tests() 
	{
		Assert.AreEqual(false, Kata.SetAlarm(true, true));
		Assert.AreEqual(false, Kata.SetAlarm(false, true));
		Assert.AreEqual(true, Kata.SetAlarm(true, false));
		Assert.AreEqual(false, Kata.SetAlarm(false, false));
	}
}
