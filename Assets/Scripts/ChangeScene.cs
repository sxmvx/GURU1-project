using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneSeaPalace()
    {
        SceneManager.LoadScene("SeaPalace");
    }

    public void ChangeSceneLoad()
    {
        SceneManager.LoadScene("SaveLoad");
    }

    public void ChangeSceneExit()
    {
        Application.Quit();
    }

    public void ChangeSceneMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void ChangeSceneLand()
    {
        SceneManager.LoadScene("Land");
    }

    public void ChangeSceneSeaGame()
    {
        SceneManager.LoadScene("SeaGame");
    }

    public void ChangeSceneMaze()
    {
        SceneManager.LoadScene("Maze");
    }
}
