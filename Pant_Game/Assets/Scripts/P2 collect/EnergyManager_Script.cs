using UnityEngine;

public class EnergyManager_Script : MonoBehaviour
{
    public int EnergyPoints;
    public int MaxEnergyPoints = 10;

    public int CollectCostTrash;

    [SerializeField] Shop_Script Shop_Script;


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


}
