using NUnit.Framework;

[TestFixture]
public class RPSTests
{
	[TestCase("Rock","Paper","Player One Wins")]
	[TestCase("Paper","Rock","Player Two Wins")]
	public void PlayerVsPlayer(string playerOneWeapon, string playerTwoWeapon, string expected)
	{
		string result = RPS.TwoPlayer (playerOneWeapon, playerTwoWeapon);
		Assert.That (result, Is.EqualTo (expected));
	}

	[TestCase("Rock","You chose Rock")]
	[TestCase("Paper","You chose Paper")]
	[TestCase("Scissors","You chose Scissors")]
	public void PlayerVsComputer(string playerOneWeapon, string expected)
	{
		string result = RPS.OnePlayer (playerOneWeapon);
		Assert.That (result, Is.EqualTo (expected));
	}

}
