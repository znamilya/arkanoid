using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        Vector3 position = new Vector3(0.5f, 0.5f, 0f);

        position.x = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0.5f, 15.5f);

        transform.position = position;
    }
}
