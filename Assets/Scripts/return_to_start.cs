using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class return_to_start : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Start_Screen");
    }

}
