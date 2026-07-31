using UnityEngine;

public class PantAmountPass_Script : MonoBehaviour
{
    public CollectTxt_Script collectTxtScript;
    public Money_Script moneyScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyScript.moneyAmount);
        PlayerPrefs.SetInt("PantAmount", collectTxtScript.collectedCount);
        PlayerPrefs.Save();
    }
}
