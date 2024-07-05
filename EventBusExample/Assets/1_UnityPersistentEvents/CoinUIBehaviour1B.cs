using TMPro;
using UnityEngine;
using UnityEngine.Events;
using Utility;

namespace _1_UnityPersistentEvents
{
    public class CoinUIBehaviour1B : MonoBehaviour
    {
        public UnityEvent onCoinCollected;
        [SerializeField] private TMP_Text coinText;

        private void OnEnable()
        {
            onCoinCollected.AddPersistentListener(OnCoinCollected);
        }
        
        private void OnDisable()
        {
            onCoinCollected.RemovePersistentListener(OnCoinCollected);
        }
        
        private void OnCoinCollected()
        {
            coinText.color = Color.yellow;
        }
    }
}