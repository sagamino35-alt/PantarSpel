using UnityEngine;

public class EnergyButtonReciver_Script : MonoBehaviour
{
    [SerializeField] EnergyManager_Script Energy_Script;

    //Scriptet som ät knappen har i scenen. Den hittar energy manager och kallar på energy manager när du klickar knappen
    private void Start()
    {
        Energy_Script = FindAnyObjectByType<EnergyManager_Script>();
    }

    public void EatFood ()
    {
        Energy_Script.EatFood();
    }


}
