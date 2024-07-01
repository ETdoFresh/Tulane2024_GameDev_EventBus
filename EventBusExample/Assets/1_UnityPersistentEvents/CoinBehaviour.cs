using UnityEngine;

namespace _1_UnityPersistentEvents
{
    public class CoinBehaviour : MonoBehaviour
    {
        [SerializeField] private CoinTextBehaviour coinTextBehaviour;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                coinTextBehaviour.onCoinCollected.Invoke();
                Destroy(gameObject);
            }
        }
    }
}