using System;

public class RPS
{
	static Random rnd = new Random ();

	public static string OnePlayer(string playerOneWeapon)
	{
		string playerTwoWeapon = CPUWeapon();
		return Play (playerOneWeapon, playerTwoWeapon);
	}

	static string CPUWeapon()
	{
		string[] weapons = { "Rock", "Paper", "Scissors" };
		return weapons [rnd.Next (2)];
	}
		
	public static string TwoPlayer(string playerOneWeapon = "", string playerTwoWeapon = "")
	{
		if (playerOneWeapon == String.Empty) 
		{
			playerOneWeapon = CPUWeapon ();
		}
		if (playerTwoWeapon == String.Empty) 
		{
			playerTwoWeapon = CPUWeapon ();
		}
		return Play (playerOneWeapon, playerTwoWeapon);
	}

	static string Play (string playerOneWeapon, string playerTwoWeapon)
	{
		if (playerOneWeapon == playerTwoWeapon) {
			return "It's a draw";
		}
		else
			if (playerOneWeapon == "Rock") {
				return PlayerOneRock (playerTwoWeapon);
			}
			else
				if (playerOneWeapon == "Paper") {
					return PlayerOnePaper (playerTwoWeapon);
				}
				else {
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
