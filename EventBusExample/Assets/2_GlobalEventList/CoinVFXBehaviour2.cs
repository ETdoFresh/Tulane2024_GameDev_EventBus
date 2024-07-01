using UnityEngine;
using Utility;

namespace _2_GlobalEventList
{
    public class CoinVFXBehaviour2 : MonoBehaviour
    {
        [SerializeField] private ParticleSystem coinVFX;
        
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
            transform.position = position;
            coinVFX.Play();
        }
    }
}