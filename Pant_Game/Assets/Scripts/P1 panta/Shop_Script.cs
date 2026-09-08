using UnityEngine;
using UnityEngine.UI;

public class Shop_Script : MonoBehaviour
{
    public bool bagUpgrade1;
    public bool bagUpgrade2;

    public bool handUpgrade1;
    public bool handUpgrade2;

    [SerializeField] Money_Script Money_Script;

    [SerializeField] int bagCost = 10;
    

    [SerializeField] Button bagUpgrade;
    [SerializeField] Button handUpgrade;
    [SerializeField] Button food;

    private void Start()
    {
        bagUpgrade1 = false; 
        bagUpgrade2 = false;
    }

    public void bagUpgradeButton()
    {
        if (Money_Script.moneyAmount >= bagCost)
        {
            Debug.Log("You clicked the bag upgrade button!");
            bagUpgrade1 = true;
        }
        else
        {
            Debug.Log("you are too poor");
        }
        

    }
}
