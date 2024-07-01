using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace _1_UnityPersistentEvents
{
    public class CoinUI2Behaviour : MonoBehaviour
    {
        public UnityEvent onCoinCollected;
        [SerializeField] private TMP_Text coinText;

        private void OnEnable()
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.AddPersistentListener(onCoinCollected, OnCoinCollected);
#else
            onCoinCollected.AddListener(OnCoinCollected);
#endif
        }
        
        private void OnDisable()
        {
#if UNITY_EDITOR
            UnityEditor.Events.UnityEventTools.RemovePersistentListener(onCoinCollected, OnCoinCollected);
#else
            onCoinCollected.RemoveListener(OnCoinCollected);
#endif
        }
        
        private void OnCoinCollected()
        {
            coinText.color = Color.yellow;
        }
    }
}