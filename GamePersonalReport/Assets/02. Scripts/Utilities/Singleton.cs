using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static bool _isShuttingDown = false;
    private static object _locked = new object();
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_isShuttingDown)
                return null;

            lock (_locked)
            {
                if (_instance == null)
                {
                    _instance = (T)FindObjectOfType(typeof(T));

                    if (_instance == null)
                    {
                        GameObject singletonObject = new GameObject();
                        singletonObject.name = typeof(T).ToString();
                        _instance = singletonObject.AddComponent<T>();
                    }

                    DontDestroyOnLoad(_instance.gameObject);
                }

                return _instance;
            }
        }
    }

    public void OnApplicationQuit()
    {
        _isShuttingDown = true;
    }
}
