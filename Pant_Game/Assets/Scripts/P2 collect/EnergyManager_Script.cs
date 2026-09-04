using UnityEngine;

public class EnergyManager_Script : MonoBehaviour
{
    public int EnergyPoints;
    public int MaxEnergyPoints = 10;


    private void Start()
    {
        EnergyPoints = MaxEnergyPoints;
    }

    public void RemoveEnergyPoints()
    {
        EnergyPoints--;
    }

}
