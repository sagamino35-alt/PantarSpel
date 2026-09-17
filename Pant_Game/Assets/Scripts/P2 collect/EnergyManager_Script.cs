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
        if (Shop_Script.handUpgrade1 == true)
        {
            CollectCostTrash = 2;
        }
    }


    public void AddFood()
    {
        foodAmount++;
    }
    public void EatFood()
    {
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
