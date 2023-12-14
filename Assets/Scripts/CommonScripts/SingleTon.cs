using UnityEngine;

// SingleTon 클래스 선언

public class SingleTon<T> : MonoBehaviour where T : Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindAnyObjectByType<T>();
                if(instance == null)
                {
                    GameObject obj = new GameObject { name = typeof(T).Name };
                    instance = obj.AddComponent<T>();
                }
            }

            return instance;
        }
    }

    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
}
