using TMPro;
using UnityEngine;

namespace _3_EventBus
{
    public class CoinUIBehaviour : MonoBehaviour
    {
        [SerializeField] private TMP_Text coinText;
        private int _collectedCoins;
        
        private void OnEnable()
        {
            EventBus.AddListener<CoinCollectedEvent>(OnCoinCollected);
        }
        
        private void OnDisable()
        {
            EventBus.RemoveListener<CoinCollectedEvent>(OnCoinCollected);
        }
        
        private void OnCoinCollected(CoinCollectedEvent coinCollectedEvent)
        {
            coinText.color = new Color(Random.value, Random.value, Random.value);
            coinText.text = $"Coins: {++_collectedCoins}";
        }
    }
}