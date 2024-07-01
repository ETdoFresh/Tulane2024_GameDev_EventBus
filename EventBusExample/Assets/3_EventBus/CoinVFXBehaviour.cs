using UnityEngine;

namespace _3_EventBus
{
    public class CoinVFXBehaviour : MonoBehaviour
    {
        [SerializeField] private ParticleSystem coinVFX;
        
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
            transform.position = coinCollectedEvent.Position;
            coinVFX.Play();
        }
    }
}