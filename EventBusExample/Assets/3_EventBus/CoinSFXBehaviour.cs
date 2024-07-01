using UnityEngine;

namespace _3_EventBus
{
    public class CoinSFXBehaviour : MonoBehaviour
    {
        [SerializeField] private AudioSource coinSFX;
        
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
            coinSFX.Play();
        }
    }
}