using UnityEngine;
using UnityEngine.UI;

public class Shop_Script : MonoBehaviour
{
    public bool bagUpgrade1;
    public bool bagUpgrade2;

    public bool handUpgrade1;
    public bool handUpgrade2;

    [SerializeField] Money_Script Money_Script;
    [SerializeField] InventoryManager_Script Inventory_Script;
    [SerializeField] EnergyManager_Script Energy_Script;
    [SerializeField] PointerManager_Script Pointer_Script;


    [SerializeField] int bag1Cost = 10;
    [SerializeField] int hand1Cost = 10;

    [SerializeField] int foodCost = 10;
    

    [SerializeField] Button bagUpgrade;
    [SerializeField] Button handUpgrade;
    [SerializeField] Button food;

    private void Start()
    {
        bagUpgrade1 = false; 
        bagUpgrade2 = false;
    }

    public void BagUpgradeButton()
    {
        if (Money_Script.moneyAmount >= bag1Cost)
        {
            Debug.Log("You clicked the bag upgrade button!");
            bagUpgrade1 = true;

            Inventory_Script.BagUpgrade1();

            Money_Script.moneyAmount -= bag1Cost;
        }
        else
        {
            Debug.Log("you are too poor to buy bag1");
        }
        

    }
    public void HandUpgradeButton()
    {
        if (Money_Script.moneyAmount >= hand1Cost)
        {
            Debug.Log("You clicked the hand upgrade button");
            handUpgrade1 = true;

            
            Energy_Script.HandUpgrade1();

            Money_Script.moneyAmount -= hand1Cost;

            Pointer_Script.ChangeToP2();


        }
        else
        {
            Debug.Log("you are too poor to buy hand1");
        }
    }

    public void FoodButton()
    {
        if (Money_Script.moneyAmount >= foodCost)
        {

        }
        else
        {
            Debug.Log("you are too poor to buy food");
        }
    }

}
