using UnityEngine;
using UnityEngine.Events;
using Utility;

namespace _2_GlobalEventList
{
    public class GlobalEventList : Singleton<GlobalEventList>
    {
        public UnityEvent<Vector3> CoinCollected = new();
        public UnityEvent PlayerDied = new();
        public UnityEvent SomeOtherEventHappened = new();
    }
}