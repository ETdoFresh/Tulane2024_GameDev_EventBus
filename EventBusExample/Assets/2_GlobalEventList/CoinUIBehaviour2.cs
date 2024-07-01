using TMPro;
using UnityEngine;
using Utility;

namespace _2_GlobalEventList
{
    public class CoinUIBehaviour2 : MonoBehaviour
    {
        [SerializeField] private TMP_Text coinText;
        private int _collectedCoins;

        private void OnEnable()
        {
            GlobalEventList.Instance.CoinCollected.AddPersistentListener(OnCoinCollected);
        }
        
        private void OnDisable()
        {
            GlobalEventList.Instance?.CoinCollected.RemovePersistentListener(OnCoinCollected);
        }

        private void OnCoinCollected(Vector3 position)
        {
            coinText.text = $"Coins: {++_collectedCoins}";
        }
    }
}