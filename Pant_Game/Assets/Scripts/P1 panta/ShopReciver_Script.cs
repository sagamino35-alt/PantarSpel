using UnityEngine;

public class ShopReciver_Script : MonoBehaviour
{
    [SerializeField] Shop_Script Shop_Script;
    [SerializeField] GameObject ShopManager;
    void Start()
    {
        ShopManager = GameObject.Find("ShopManager");
        Shop_Script = ShopManager.GetComponent<Shop_Script>();
    }

    // Update is called once per frame
    public void bagUpgradeButton()
    {
        Shop_Script.bagUpgradeButton();
    }
}
