using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void Back()
    {
        SceneManager.UnloadScene("Levelselection");
        SceneManager.LoadScene("Main Menu");
    }
}
