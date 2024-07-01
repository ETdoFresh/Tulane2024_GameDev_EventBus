using UnityEngine;

namespace _2_GlobalEventList
{
    public class CoinBehaviour2 : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                GlobalEventList.Instance.CoinCollected.Invoke(transform.position);
                Destroy(gameObject);
            }
        }
    }
}