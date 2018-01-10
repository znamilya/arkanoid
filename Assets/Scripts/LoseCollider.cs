using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private SceneManager sceneManager;

    private void Start()
    {
        sceneManager = FindObjectOfType<SceneManager>();
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        sceneManager.LoadScene("Win");
    }
}
