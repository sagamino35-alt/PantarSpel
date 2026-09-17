using UnityEngine;

public class EnergyButtonReciver_Script : MonoBehaviour
{
    [SerializeField] EnergyManager_Script Energy_Script;


    private void Start()
    {
        Energy_Script = FindAnyObjectByType<EnergyManager_Script>();
    }

    public void EatFood ()
    {
        Energy_Script.EatFood();
    }


}
