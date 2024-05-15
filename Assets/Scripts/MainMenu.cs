using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("CharacterSelection");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("User has quit.");
    }
}
