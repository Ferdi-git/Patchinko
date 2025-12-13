using UnityEngine;

public class ZoneWinLose : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] float mult = 0.5f;
    private ParticleSystem ParticleSystem;

    private void Start()
    {
        ParticleSystem = GetComponent<ParticleSystem>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            ParticleSystem.Play();
            gameManager.GainMoney(mult);
            Destroy(collision.gameObject);
        }
    }

}
