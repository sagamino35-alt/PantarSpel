using TMPro;
using UnityEngine;

public class DayManager_Script : MonoBehaviour
{
    [SerializeField] EnergyManager_Script energyManagerScript;

    [SerializeField] int DayCount;

    [SerializeField] TextMeshProUGUI DayTxt;


    
    void Start()
    {
        DayCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        DayTxt.text = ("Day: " + DayCount.ToString());
    }

    public void ResetDay()
    {
        DayCount++;
        energyManagerScript.ResetEnergy();
    }

}
