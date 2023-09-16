using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public void Level1Button()
    {
        SceneManager.LoadScene("Level 1");
        StaticClass.lvl1 = true;

    }
    public void Level2Button()
    {
        SceneManager.LoadScene("Level 2");
        StaticClass.lvl2 = true;
    }
    public void Level3Button()
    {
        SceneManager.LoadScene("Level 3");
        StaticClass.lvl3 = true;
    }
    public void Level4Button()
    {
        SceneManager.LoadScene("Level 4");
        StaticClass.lvl4 = true;
    }
}
