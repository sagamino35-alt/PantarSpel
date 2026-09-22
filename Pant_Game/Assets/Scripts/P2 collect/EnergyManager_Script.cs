using UnityEngine;

public class EnergyManager_Script : MonoBehaviour
{
    public int EnergyPoints;
    public int MaxEnergyPoints = 10;

    public int CollectCostTrash;

    [SerializeField] Shop_Script Shop_Script;

    [SerializeField] int foodAmount;
    [SerializeField] int foodEnergy = 5;
    

    private void Start()
    {
        EnergyPoints = MaxEnergyPoints;
    }

    public void RemoveEnergyPoints()
    {
        EnergyPoints -= CollectCostTrash;
    }

    public void HandUpgrade1()
    {
        //kollar om shop scripts hand upgrade 1 är true, om true så minskar den energikosnaden med 1. Man kan skapa en ny int med handUpgrade1energyCost och antingen tar bort eller sätter CollectCostTrash
        if (Shop_Script.handUpgrade1 == true)
        {
            CollectCostTrash = 2 ;
        }
    }


    public void AddFood()
    {
        //kallas i Shop_Script
        foodAmount++;
    }
    public void EatFood()
    {
        //kallas i EnergyButtonReciver_Script
        if (foodAmount <= 0 || EnergyPoints >= MaxEnergyPoints)
        {
            Debug.Log("You are either have no food or max energy");

        }
        else
        {
            Debug.Log("You ate food");

            foodAmount--;

            EnergyPoints += foodEnergy;

        }
    }

}
