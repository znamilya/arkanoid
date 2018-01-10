using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }

    public void LoadNextScene()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
