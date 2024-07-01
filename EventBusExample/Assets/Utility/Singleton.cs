using UnityEngine;

namespace Utility
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _instance;
        private static bool _isApplicationQuitting;
        
        public static T Instance
        {
            get
            {
                if (_instance) return _instance;
                if (_isApplicationQuitting) return null;
                _instance = FindObjectOfType<T>();
                if (_instance) return _instance;
                _instance = new GameObject(typeof(T).Name).AddComponent<T>();
                return _instance;
            }
        }
        
        protected virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = (T) this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        
        protected virtual void OnApplicationQuit()
        {
            _isApplicationQuitting = true;
        }
    }
}