using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float dollars = 100000f;
    private int costOfBall = 100;
    [SerializeField] TextMeshProUGUI textMoney;
    [SerializeField] GameObject DeathScreen;
    private void Start()
    {
        UpdateMoneyText();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Echap();
        }
    }


    public void GainMoney(float mult)
    {
        dollars += costOfBall* mult;
        if (dollars <= 0)
        {
            dollars = 0;
            Echap();
        }

        UpdateMoneyText();
    }

    private void UpdateMoneyText()
    {
        textMoney.text = dollars.ToString() + " $";
    }

    public void Echap()
    {
        DeathScreen.SetActive(true);
    }


    public void Home()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
