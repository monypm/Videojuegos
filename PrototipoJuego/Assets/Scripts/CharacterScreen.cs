using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public static class CharacterScreen
{

	public static int GetHp ()
	{
		if (PlayerPrefs.HasKey ("HP")) {
			return PlayerPrefs.GetInt ("HP");
		} else {
			return 0;
		}
	}

	public static void SetHP (int hp)
	{
		PlayerPrefs.SetInt ("HP", hp);
	}

	public static void CharacterSelected (int character)
	{
		PlayerPrefs.SetInt ("CharacterSelected", character);
	}

	public static int GetCharacterSelected ()
	{
		if (PlayerPrefs.HasKey ("CharacterSelected")) {
			return PlayerPrefs.GetInt ("CharacterSelected");
		} else {
			return 0;
		}
	}

	public static int GetEnemy1Alive ()
	{
		if (PlayerPrefs.HasKey ("Enemy1")) {
			return PlayerPrefs.GetInt ("Enemy1");
		} else {
			return 1;
		}
	}

	public static int GetEnemy2Alive ()
	{
		if (PlayerPrefs.HasKey ("Enemy2")) {
			return PlayerPrefs.GetInt ("Enemy2");
		} else {
			return 1;
		}
	}

	public static int GetEnemy3Alive ()
	{
		if (PlayerPrefs.HasKey ("Enemy3")) {
			return PlayerPrefs.GetInt ("Enemy3");
		} else {
			return 1;
		}
	}

	public static void SetEnemy1Alive ()
	{
		PlayerPrefs.SetInt ("Enemy1", 0);
	}

	public static void SetEnemy2Alive ()
	{
		PlayerPrefs.SetInt ("Enemy2", 0);
	}

	public static void SetEnemy3Alive ()
	{
		PlayerPrefs.SetInt ("Enemy3", 0);
	}

	public static void SetVictoryStatus ()
	{
		PlayerPrefs.SetInt ("Victory", 1);
	}

	public static int GetVictoryStatus ()
	{
		if (PlayerPrefs.HasKey ("Victory")) {
			return PlayerPrefs.GetInt ("Victory");
		} else {
			return 0;
		}
	}



	public static void ResetPlayerState (int startingHP)
	{
		Debug.Log ("Game is Reset.");
		PlayerPrefs.SetInt ("HP", startingHP);
		PlayerPrefs.SetInt ("Enemy1Alive", 1);
		PlayerPrefs.SetInt ("Enemy2Alive", 1);
		PlayerPrefs.SetInt ("Enemy3Alive", 1);
		PlayerPrefs.SetInt ("Victory", 0);
		PlayerPrefs.SetInt ("CharacterSelected", 0);

	}



	public static void ShowPlayerPrefs ()
	{
		string[] values = { "Victory", "HP", "Enemy1Alive", "Enemy2Alive", "Enemy3Alive" };

		foreach (string value in values) {
			if (PlayerPrefs.HasKey (value)) {
				Debug.Log (value + " = " + PlayerPrefs.GetInt (value));
			} else {
				Debug.Log (value + " is not set.");
			}
		}
	}
}
