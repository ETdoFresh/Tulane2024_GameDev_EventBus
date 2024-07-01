﻿using TMPro;
using UnityEngine;

namespace _2_GlobalEventList
{
    public class CoinUIBehaviour : MonoBehaviour
    {
        [SerializeField] private TMP_Text coinText;
        private int _collectedCoins;

        private void OnEnable()
        {
            GlobalEventList.Instance.CoinCollected.AddListener(OnCoinCollected);
        }
        
        private void OnDisable()
        {
            GlobalEventList.Instance?.CoinCollected.RemoveListener(OnCoinCollected);
        }

        private void OnCoinCollected(Vector3 position)
        {
            coinText.text = $"Coins: {++_collectedCoins}";
        }
    }
}