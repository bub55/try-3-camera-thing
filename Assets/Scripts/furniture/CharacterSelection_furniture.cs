using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection_furniture : MonoBehaviour
{
	public GameObject[] characters;
	public int selectedCharacter = 0;
	public string NextScene;

	public void NextCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter = (selectedCharacter + 1) % characters.Length;
		characters[selectedCharacter].SetActive(true);
	}

	public void PreviousCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter--;
		if (selectedCharacter < 0)
		{
			selectedCharacter += characters.Length;
		}
		characters[selectedCharacter].SetActive(true);
	}

	public void StartGame()
	{
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
		PlayerPrefs.SetString("Next Scene", NextScene);
		SceneManager.LoadScene(NextScene);
	}
}
