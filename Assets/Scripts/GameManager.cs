using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float dollars = 100000f;
    private int costOfBall = 100;
    [SerializeField] TextMeshProUGUI textMoney;
    private void Start()
    {
        dollars = 100000;
        UpdateMoneyText();
    }

    public void GainMoney(float mult)
    {
        dollars += costOfBall* mult;
        UpdateMoneyText();
    }

    private void UpdateMoneyText()
    {
        textMoney.text = dollars.ToString() + " $";
    }
}
