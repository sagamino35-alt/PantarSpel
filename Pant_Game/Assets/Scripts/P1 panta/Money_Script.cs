using UnityEngine;

public class Money_Script : MonoBehaviour
{
    public int moneyAmount;

    private void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    public void AddMoney()
    {
        moneyAmount++;
    }


}
