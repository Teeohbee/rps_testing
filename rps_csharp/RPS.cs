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
		if (playerOneWeapon == playerTwoWeapon) {
			return "It's a draw";
		} else if (playerOneWeapon == "Rock") {
			return PlayerOneRock (playerTwoWeapon);
		} else if (playerOneWeapon == "Paper") {
			return PlayerOnePaper (playerTwoWeapon);
		} else {
			return PlayerOneScissors (playerTwoWeapon);
		}
	}

	static string PlayerOneRock (string playerTwoWeapon)
	{
		return (playerTwoWeapon == "Scissors") ? "Player One Wins" : "Player Two Wins";
	}

	static string PlayerOnePaper (string playerTwoWeapon)
	{
		return (playerTwoWeapon == "Rock") ? "Player One Wins" : "Player Two Wins";

	}

	static string PlayerOneScissors (string playerTwoWeapon)
	{
		return (playerTwoWeapon == "Paper") ? "Player One Wins" : "Player Two Wins";
	}
}
