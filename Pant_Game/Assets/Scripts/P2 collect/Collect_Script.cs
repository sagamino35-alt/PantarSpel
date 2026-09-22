using Unity.VisualScripting;
using UnityEngine;

public class Collect_Script : MonoBehaviour
{
    [SerializeField] TrashManager_Script trashManager;
    [SerializeField] EnergyManager_Script energyManager;
    [SerializeField] InventoryManager_Script inventoryManager;
    [SerializeField] TrashHeap_Script trashHeapScript;


    [SerializeField] int RandomBottle;


    private void Start()
    {
        trashManager = FindAnyObjectByType<TrashManager_Script>();
        energyManager = FindAnyObjectByType<EnergyManager_Script>();
        inventoryManager = FindAnyObjectByType<InventoryManager_Script>();
        trashHeapScript = FindAnyObjectByType<TrashHeap_Script>();

    }

    

    public void OnMouseClick()
    {
        

        if (energyManager.EnergyPoints == 0 || energyManager.EnergyPoints < 0)
        {
            //kollar om du har energin att plocka upp skräp
            Debug.Log("You have no energy");
        }
        else
        {
            if (inventoryManager.totalInventorySlots == inventoryManager.trashInInventory)
            {
                //Kollar om bag är full
                Debug.Log("Bag is full");
            }
            else
            {
                inventoryManager.AddTrashToInv(); 
                energyManager.RemoveEnergyPoints(); 

                trashManager.UpdateCollectText(); 
                Debug.Log("Collect button clicked");

                



                //lägger till skräpet i rätt kategori
                if (gameObject.CompareTag("Bottle_Red"))
                {
                    trashManager.redBottleCount++;
                    //tar bort obj
                    gameObject.SetActive(false);
                }
                else if (gameObject.CompareTag("Bottle_Green"))
                {
                    trashManager.greenBottleCount++;
                    //tar bort obj
                    gameObject.SetActive(false);
                }
                else if (gameObject.CompareTag("Bottle_Blue"))
                {
                    trashManager.blueBottleCount++;
                    //tar bort obj
                    gameObject.SetActive(false);
                }
                else if (gameObject.CompareTag("Bottle_Orange"))
                {
                    trashManager.orangeBottleCount++;
                    //tar bort obj
                    gameObject.SetActive(false);
                }
                else if (gameObject.CompareTag("Bottle_Yellow"))
                {
                    trashManager.yellowBottleCount++;
                    //tar bort obj
                    gameObject.SetActive(false);
                } 


                else if (gameObject.CompareTag("TrashHeap"))
                {
                    if (trashHeapScript.TrashInHeapCount >= 0)
                    {
                        trashHeapScript.TrashInHeapCount--;

                        RandomBottleGen();


                    } 
                    else
                    {
                        //tar bort obj
                        gameObject.SetActive(false);
                    }
                }



            }

        }
    }

    //Range with all trash types. Depending on which number it adds to the trash kind
    private void RandomBottleGen()
    {
        RandomBottle = Random.Range(1, 6);
        if (RandomBottle == 1)
        {
            trashManager.redBottleCount++;
        }
        if (RandomBottle == 2)
        {
            trashManager.greenBottleCount++;
        }
        if (RandomBottle == 3)
        {
            trashManager.blueBottleCount++;
        }
        if (RandomBottle == 4)
        {
            trashManager.orangeBottleCount++;
        }
        if (RandomBottle == 5)
        {
            trashManager.yellowBottleCount++;
        }
    }






}
