using UnityEngine;
using TMPro;

public class Score_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] int pant;
    [SerializeField] TextMeshProUGUI PointsText;
    [SerializeField] InventoryManager_Script InventoryManager;

    
    void Start()
    {
        
        pant = InventoryManager.trashInInventory;
    }
    void Update()
    {
        PointsText.text = "Burkar kvar att panta: " + pant.ToString();
    }

    public void SubScore()
    {
        pant--;
        
    }

    public void UpdateCount()
    {
        pant = InventoryManager.trashInInventory;
        PointsText.text = "Burkar kvar att panta: " + pant.ToString();
    } 

}
