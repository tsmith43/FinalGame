using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{

    public void LoadScene(int level)
    {
        if (level < 3)
        {
            SceneManager.LoadScene(level);
        }
        else
        {
            Application.Quit();
        }
    }
}
