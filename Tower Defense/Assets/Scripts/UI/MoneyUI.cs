using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    private Text moneyText;

    private void Start()
    {
        moneyText = GetComponent<Text>();
    }
    private void Update()
    {
        moneyText.text = "$" + PlayerStats.Money.ToString();
    }
}
