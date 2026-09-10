using UnityEngine;

public class InventoryManager_Script : MonoBehaviour
{
    public int totalInventorySlots;
    public int trashInInventory;
    public int food;

    [SerializeField] Shop_Script Shop_Script;

    private void Start()
    {
        trashInInventory = 0;

        
    }

    public void BagUpgrade1()
    {
        //Says to shop_script to execute code
        if (Shop_Script.bagUpgrade1 == true)
        {
            totalInventorySlots += 15;
        }
    }

    public void AddTrashToInv()
    {
        //Says to collect_script to execute code
        trashInInventory++;
    }


}
