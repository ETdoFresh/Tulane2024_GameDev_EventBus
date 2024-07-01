using UnityEngine;

namespace _1_UnityPersistentEvents
{
    public class CoinBehaviour1A : MonoBehaviour
    {
        [SerializeField] private CoinUIBehaviour1A coinUIBehaviour;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                coinUIBehaviour.onCoinCollected.Invoke();
                Destroy(gameObject);
            }
        }
    }
}