using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour
{
    static T instance;

    public virtual void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this as T;
        }
    }

    public virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
}
