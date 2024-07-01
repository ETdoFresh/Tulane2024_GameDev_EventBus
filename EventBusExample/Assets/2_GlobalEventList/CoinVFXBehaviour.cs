using UnityEngine;

namespace _2_GlobalEventList
{
    public class CoinVFXBehaviour : MonoBehaviour
    {
        [SerializeField] private ParticleSystem coinVFX;
        
        private void OnEnable()
        {
            GlobalEventList.Instance.CoinCollected.AddListener(PlayCoinVFX);
        }
        
        private void OnDisable()
        {
            GlobalEventList.Instance.CoinCollected.RemoveListener(PlayCoinVFX);
        }
        
        private void PlayCoinVFX(Vector3 position)
        {
            transform.position = position;
            coinVFX.Play();
        }
    }
}