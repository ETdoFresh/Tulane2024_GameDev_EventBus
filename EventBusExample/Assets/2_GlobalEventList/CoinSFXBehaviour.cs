using UnityEngine;

namespace _2_GlobalEventList
{
    public class CoinSFXBehaviour : MonoBehaviour
    {
        [SerializeField] private AudioSource coinSFX;
        
        private void OnEnable()
        {
            GlobalEventList.Instance.CoinCollected.AddListener(OnCoinCollected);
        }
        
        private void OnDisable()
        {
            GlobalEventList.Instance?.CoinCollected.RemoveListener(OnCoinCollected);
        }
        
        private void OnCoinCollected(Vector3 position)
        {
            coinSFX.Play();
        }
    }
}