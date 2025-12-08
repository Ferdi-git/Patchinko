using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject prefabBall;
    [SerializeField] GameManager gameManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 randomPos  = transform.position;
            randomPos.x = Random.Range(-0.6f, 1.6f);
            gameManager.GainMoney(-1);
            Instantiate(prefabBall, randomPos , Quaternion.identity);
        }
    }
}
