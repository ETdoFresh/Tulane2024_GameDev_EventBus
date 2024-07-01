﻿using UnityEngine;

namespace _2_GlobalEventList
{
    public class CoinVFXBehaviour : MonoBehaviour
    {
        [SerializeField] private ParticleSystem coinVFX;
        
        private void OnEnable()
        {
            GlobalEventList.Instance.CoinCollected.AddListener(OnCoinCollected);
        }
        
        private void OnDisable()
        {
            GlobalEventList.Instance.CoinCollected.RemoveListener(OnCoinCollected);
        }
        
        private void OnCoinCollected(Vector3 position)
        {
            transform.position = position;
            coinVFX.Play();
        }
    }
}