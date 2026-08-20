using UnityEngine;

public class PantAmountPass_Script : MonoBehaviour
{
    public CollectTxt_Script collectTxtScript;
    
    public int moneyAmount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.SetInt("PantAmount", collectTxtScript.collectedCount);
        PlayerPrefs.Save();
    }
}
