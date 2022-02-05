using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    OptionData optiondata;
    ChangeScen_DL dl;

    void Start()
    {
        optiondata = GameObject.Find("GameManager").GetComponent<OptionData>();
        dl = GameObject.Find("GameManager").GetComponent<ChangeScen_DL>();
    }

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

    public void ChangeSceneLand2()
    {
        SceneManager.LoadScene("Land2");
    }

    public void ChangeSceneSeaGame()
    {
        SceneManager.LoadScene("SeaGame");
    }

    public void ChangeSceneMaze()
    {
        SceneManager.LoadScene("Maze");
    }

    public void ChangeSceneSeaPalaceRabbit()
    {
        SceneManager.LoadScene("SeaPalace2");
    }

    public void ChangeSceneWoods()
    {
        SceneManager.LoadScene("Woods");
    }

    public void ChangeSceneLandEnding()
    {
        SceneManager.LoadScene("À°Áö¿£µù");
    }

    public void ChangeSceneSeaEnding()
    {
        SceneManager.LoadScene("Ãæ¼º¿£µù");
    }
    public void ChangeSceneDieEnding()
    {
        SceneManager.LoadScene("Á×À½¿£µù");
    }
    public void ChangeSceneGreedyEnding()
    {
        SceneManager.LoadScene("Å½¿å¿£µù");
    }
    public void ChangeSceneFamEnding()
    {
        SceneManager.LoadScene("³²»ýÀÌ¿£µù");
    }

    public void EndingScene()
    {
        if (optiondata.rabbit >= 8)
            dl.ChangeSceneDialogue4();
        else if (optiondata.rabbit <= 4)
            ChangeSceneDieEnding();
        else if (optiondata.greed >= 8)
            ChangeSceneGreedyEnding();
    }
}
