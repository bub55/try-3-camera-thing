using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class path_Controller : MonoBehaviour
{
    public void ChooseFurniture()
    {
        SceneManager.LoadScene("selection_furniture");
    }
    public void ChooseOtherStuff()
    {
        SceneManager.LoadScene("selection_other_stuff");
    }

}
