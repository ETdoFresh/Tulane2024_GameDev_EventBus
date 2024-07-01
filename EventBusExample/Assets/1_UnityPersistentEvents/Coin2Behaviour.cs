using UnityEngine;

namespace _1_UnityPersistentEvents
{
    public class Coin2Behaviour : MonoBehaviour
    {
        [SerializeField] private CoinUI2Behaviour coinUI2Behaviour;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                coinUI2Behaviour.onCoinCollected.Invoke();
                Destroy(gameObject);
            }
        }
    }
}