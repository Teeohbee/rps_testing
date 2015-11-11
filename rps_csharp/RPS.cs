using System;

public class RPS
{
	public static string OnePlayer(string playerOneWeapon)
	{
		Random rnd = new Random ();
		int opponentWeapon = rnd.Next (2);
		return $"You chose {playerOneWeapon}";
	}

	public static string TwoPlayer(string playerOneWeapon, string playerTwoWeapon)
	{
		return "Player One Wins";
	}
}
