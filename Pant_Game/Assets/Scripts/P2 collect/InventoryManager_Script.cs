using UnityEngine;

public class InventoryManager_Script : MonoBehaviour
{
    public int totalInventorySlots = 10;
    public int trashInInventory;
    public int food = 0;

    private void Start()
    {
        trashInInventory = 0;
    }

    public void AddTrashToInv()
    {
        trashInInventory++;
    }


}
