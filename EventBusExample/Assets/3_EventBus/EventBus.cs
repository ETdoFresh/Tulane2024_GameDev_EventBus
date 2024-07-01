using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityActions = System.Object;

namespace _3_EventBus
{
    public static class EventBus
    {
        private static readonly Dictionary<Type, List<UnityActions>> Events = new();
        
        public static void AddListener<T>(UnityAction<T> listener)
        {
            var eventType = typeof(T);
            if (!Events.ContainsKey(eventType)) 
                Events[eventType] = new List<UnityActions>();
            Events[eventType].Add(listener);
        }
        
        public static void RemoveListener<T>(UnityAction<T> listener)
        {
            var eventType = typeof(T);
            if (!Events.ContainsKey(eventType)) return;
            Events[eventType].Remove(listener);
        }
        
        public static void Invoke<T>(T unityEvent)
        {
            var eventType = typeof(T);
            if (!Events.ContainsKey(eventType)) return;
            foreach (UnityAction<T> listener in Events[eventType]) 
                listener.Invoke(unityEvent);
        }
    }
}