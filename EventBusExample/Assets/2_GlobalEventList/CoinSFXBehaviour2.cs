using UnityEngine;
using Utility;

namespace _2_GlobalEventList
{
    public class CoinSFXBehaviour2 : MonoBehaviour
    {
        [SerializeField] private AudioSource coinSFX;
        
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
            coinSFX.Play();
        }
    }
}