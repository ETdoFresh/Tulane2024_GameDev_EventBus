using UnityEngine;

namespace _1_UnityPersistentEvents
{
    public class Coin2Behaviour : MonoBehaviour
    {
        [SerializeField] private CoinText2Behaviour coinText2Behaviour;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                coinText2Behaviour.onCoinCollected.Invoke();
                Destroy(gameObject);
            }
        }
    }
}