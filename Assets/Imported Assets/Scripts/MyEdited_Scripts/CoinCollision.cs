
using UnityEngine;
using UnityEngine.Events;

public class CoinCollision : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip coinPickupSFX;
    public UnityEvent coinPickUp;
    [SerializeField] private ParticleSystem particleSystem;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            CoinPickup();
        }
    }

    void CoinPickup()
    {
        audioSource.Stop();
        particleSystem.Play();
        coinPickUp.Invoke();
        Destroy(gameObject);
    }
}
