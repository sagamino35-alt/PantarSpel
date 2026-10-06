using TMPro;
using UnityEngine;

public class MeterManager_Script : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MoneyTxt;
    [SerializeField] TextMeshProUGUI FoodTxt;
    [SerializeField] TextMeshProUGUI EnergyTxt;

    [SerializeField] Money_Script MoneyScript;
    [SerializeField] EnergyManager_Script EnergyManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoneyTxt.text = ("Money: " + MoneyScript.moneyAmount.ToString());
        FoodTxt.text = ("Food: " + EnergyManager.foodAmount.ToString());
        EnergyTxt.text = ("Energy: " + EnergyManager.EnergyPoints.ToString());
    }
}
