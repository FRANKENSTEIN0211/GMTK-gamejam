using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{
    public void playgame()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void howtoplay()
    {
        SceneManager.LoadScene("Scene_1");
    }
    public void backtomenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void home()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
