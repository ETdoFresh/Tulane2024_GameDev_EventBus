using UnityEngine.Events;

namespace Utility
{
    public static class UnityPersistentEventExtension
    {
        public static void AddPersistentListener(this UnityEvent unityEvent, UnityAction action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.AddPersistentListener(unityEvent, action);
#else
            unityEvent.AddListener(action);
#endif
        }

        public static void RemovePersistentListener(this UnityEvent unityEvent, UnityAction action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.RemovePersistentListener(unityEvent, action);
#else
            unityEvent.RemoveListener(action);
#endif
        }

        public static void AddPersistentListener<T0>(this UnityEvent<T0> unityEvent, UnityAction<T0> action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.AddPersistentListener(unityEvent, action);
#else
            unityEvent.AddListener(action);
#endif
        }

        public static void RemovePersistentListener<T0>(this UnityEvent<T0> unityEvent, UnityAction<T0> action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.RemovePersistentListener(unityEvent, action);
#else
            unityEvent.RemoveListener(action);
#endif
        }

        public static void AddPersistentListener<T0, T1>(this UnityEvent<T0, T1> unityEvent, UnityAction<T0, T1> action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.AddPersistentListener(unityEvent, action);
#else
            unityEvent.AddListener(action);
#endif
        }

        public static void RemovePersistentListener<T0, T1>(this UnityEvent<T0, T1> unityEvent,
            UnityAction<T0, T1> action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.RemovePersistentListener(unityEvent, action);
#else
            unityEvent.RemoveListener(action);
#endif
        }

        public static void AddPersistentListener<T0, T1, T2>(this UnityEvent<T0, T1, T2> unityEvent,
            UnityAction<T0, T1, T2> action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.AddPersistentListener(unityEvent, action);
#else
            unityEvent.AddListener(action);
#endif
        }

        public static void RemovePersistentListener<T0, T1, T2>(this UnityEvent<T0, T1, T2> unityEvent,
            UnityAction<T0, T1, T2> action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.RemovePersistentListener(unityEvent, action);
#else
            unityEvent.RemoveListener(action);
#endif
        }

        public static void AddPersistentListener<T0, T1, T2, T3>(this UnityEvent<T0, T1, T2, T3> unityEvent,
            UnityAction<T0, T1, T2, T3> action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.AddPersistentListener(unityEvent, action);
#else
            unityEvent.AddListener(action);
#endif
        }

        public static void RemovePersistentListener<T0, T1, T2, T3>(this UnityEvent<T0, T1, T2, T3> unityEvent,
            UnityAction<T0, T1, T2, T3> action)
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.RemovePersistentListener(unityEvent, action);
#else
            unityEvent.RemoveListener(action);
#endif
        }
    }
}