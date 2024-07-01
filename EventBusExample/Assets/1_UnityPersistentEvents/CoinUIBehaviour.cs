using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace _1_UnityPersistentEvents
{
    public class CoinUIBehaviour : MonoBehaviour
    {
        public UnityEvent onCoinCollected;
        [SerializeField] private TMP_Text coinText;

        private void OnEnable()
        {
            onCoinCollected.AddListener(OnCoinCollected);
        }
        
        private void OnDisable()
        {
            onCoinCollected.RemoveListener(OnCoinCollected);
        }
        
        private void OnCoinCollected()
        {
            coinText.color = Color.yellow;
        }
    }
}
