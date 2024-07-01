using UnityEngine;

namespace _2_GlobalEventList
{
    public class CoinSFXBehaviour : MonoBehaviour
    {
        [SerializeField] private AudioSource coinSFX;
        
        private void OnEnable()
        {
            GlobalEventList.Instance.CoinCollected.AddListener(PlayCoinSFX);
        }
        
        private void OnDisable()
        {
            GlobalEventList.Instance.CoinCollected.RemoveListener(PlayCoinSFX);
        }
        
        private void PlayCoinSFX(Vector3 position)
        {
            coinSFX.Play();
        }
    }
}