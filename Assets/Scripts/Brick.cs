using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brick : MonoBehaviour
{

    public int maxHits = 1;

    private SceneManager sceneManager;
    private int timesHit = 0;
    private int totalBricksCount;

    void Start()
    {
        sceneManager = FindObjectOfType<SceneManager>();
        timesHit = 0;
        Brick[] allBricks = FindObjectsOfType<Brick>();

        totalBricksCount = allBricks.Length;

        Debug.Log(totalBricksCount);

        ChaneColor();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;

        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
            totalBricksCount--;

            if (totalBricksCount == 0)
            {
                sceneManager.LoadNextScene();
            }
        }

        ChaneColor();
    }

    private void ChaneColor()
    {
        switch (maxHits - timesHit)
        {
            case 1:
                GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case 2:
                GetComponent<SpriteRenderer>().color = Color.yellow;
                break;
            case 3:
                GetComponent<SpriteRenderer>().color = Color.green;
                break;
        }
    }
}
