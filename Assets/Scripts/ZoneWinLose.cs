using UnityEngine;

public class ZoneWinLose : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] float mult = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            gameManager.GainMoney(mult);
            Destroy(collision.gameObject);
        }
    }

}
