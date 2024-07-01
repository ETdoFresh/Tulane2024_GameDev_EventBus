using UnityEngine;

namespace _3_EventBus
{
    public class CoinBehaviour : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                EventBus.Invoke(new CoinCollectedEvent { Position = transform.position });
                Destroy(gameObject);
            }
        }
    }
}