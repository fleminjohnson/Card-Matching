using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardMatchingGame
{
    public class SingletonBehaviourDontDestroy<T> : MonoBehaviour where T : SingletonBehaviourDontDestroy<T>
    {
        private static T instance;
        public static T Instance { get { return instance; } }

        public void Awake()
        {
            Debug.Log("parent awake method");
            if (instance == null)
            {
                instance = (T)this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Debug.LogWarning("Someone tring to create a duplicate of Singleton!");
                Destroy(this);
            }
        }
    }
}
