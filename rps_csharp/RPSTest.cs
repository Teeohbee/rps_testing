using NUnit.Framework;

[TestFixture]
public class RPSTests
{
	[TestCase("Rock","Scissors","Player One Wins")]
	[TestCase("Rock","Rock","It's a draw")]
	[TestCase("Rock","Paper","Player Two Wins")]
	[TestCase("Paper","Rock","Player One Wins")]
	[TestCase("Paper","Paper","It's a draw")]
	[TestCase("Paper","Scissors","Player Two Wins")]
	[TestCase("Scissors","Paper","Player One Wins")]
	[TestCase("Scissors","Scissors","It's a draw")]
	[TestCase("Scissors","Rock","Player Two Wins")]
	public void PlayerVsPlayer(string playerOneWeapon, string playerTwoWeapon, string expected)
	{
		string result = RPS.TwoPlayer (playerOneWeapon, playerTwoWeapon);
		Assert.That (result, Is.EqualTo (expected));
	}

	[TestCase("Rock","It's a draw")]
	[TestCase("Paper","Player One Wins")]
	[TestCase("Scissors","Player Two Wins")]
	public new string CPUWeapon()
	{
		return "Rock";
	}
	public void PlayerVsComputer(string playerOneWeapon, string expected)
	{
		string result = RPS.OnePlayer (playerOneWeapon);
		Assert.That (result, Is.EqualTo (expected));
	}
}
