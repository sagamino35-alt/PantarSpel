using Unity.VisualScripting;
using UnityEngine;

public class Collect_Script : MonoBehaviour
{
    [SerializeField] private TrashManager_Script trashManager;
    [SerializeField] EnergyManager_Script energyManager;

    private void Start()
    {
        trashManager = FindAnyObjectByType<TrashManager_Script>();
        energyManager = FindAnyObjectByType<EnergyManager_Script>();
    }
    public void OnMouseClick()
    {
        

        if (energyManager.EnergyPoints == 0 || energyManager.EnergyPoints < 0)
        {
            
        }
        else
        {
            energyManager.RemoveEnergyPoints();

            trashManager.UpdateCollectText();
            Debug.Log("Collect button clicked");

            if (gameObject.CompareTag("Bottle_Red"))
            {
                trashManager.redBottleCount++;
            }
            else if (gameObject.CompareTag("Bottle_Green"))
            {
                trashManager.greenBottleCount++;
            }
            else if (gameObject.CompareTag("Bottle_Blue"))
            {
                trashManager.blueBottleCount++;
            }
            else if (gameObject.CompareTag("Bottle_Orange"))
            {
                trashManager.orangeBottleCount++;
            }
            else if (gameObject.CompareTag("Bottle_Yellow"))
            {
                trashManager.yellowBottleCount++;
            }

            gameObject.SetActive(false);

        }
        
        
    }
}
