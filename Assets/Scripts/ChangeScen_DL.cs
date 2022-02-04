using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScen_DL : MonoBehaviour
{
    public void ChangeSceneDialogue1()
    {
        SceneManager.LoadScene("Dialogue1");
    }

    public void ChangeSceneDialogue2()
    {
        SceneManager.LoadScene("Dialogue2");
    }

    public void ChangeSceneDialogue3()
    {
        SceneManager.LoadScene("Dialogue3");
    }

    public void ChangeSceneDialogue4()
    {
        SceneManager.LoadScene("Dialogue4");
    }
}
