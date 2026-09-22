using Unity.VisualScripting;
using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject BottlePrefab;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] int clickCount = 0;
    [SerializeField] InventoryManager_Script inventoryManager;

    void Start()
    {
        
    }

    private void Update()
    {
        clickCount = inventoryManager.trashInInventory;
    }

    private void OnMouseDown()
    {
        clickCount--;
        if (clickCount >= 0)
        {
            Debug.Log("Spawner clicked");
            Instantiate<GameObject>(BottlePrefab, spawnPoint.transform.position, Quaternion.identity);

        }
        


    }

}
