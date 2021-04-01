using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject howToPlay;
    public GameObject quitBT;
    public GameObject startBT;
    
   
    public void Open()
    {
        SceneManager.LoadScene(0);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(7);
    }
        public void Start_BT()
    {
        SceneManager.LoadScene(1);
    }



    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit_Game()
    {
        Application.Quit();

    }
}
