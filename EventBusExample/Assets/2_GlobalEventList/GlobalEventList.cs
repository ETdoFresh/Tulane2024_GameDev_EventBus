using UnityEngine;
using UnityEngine.Events;
using Utility;

namespace _2_GlobalEventList
{
    public class GlobalEventList : Singleton<GlobalEventList>
    {
        public UnityEvent<Vector3> CoinCollected = new UnityEvent<Vector3>();
        public UnityEvent PlayerDied = new UnityEvent();
        public UnityEvent SomeOtherEventHappened = new UnityEvent();
    }
}