using Unity.VisualScripting;
using UnityEngine;

public class Collect_Script : MonoBehaviour
{
    [SerializeField] private CollectTxt_Script collectTxtScript;

    private void Start()
    {
        collectTxtScript = FindAnyObjectByType<CollectTxt_Script>();
    }
    public void OnMouseClick()
    {
        collectTxtScript.UpdateCollectText();
        Debug.Log("Collect button clicked");

        if (gameObject.CompareTag("Bottle_Red"))
        {
            collectTxtScript.redBottleCount++;
        }
        else if (gameObject.CompareTag("Bottle_Green"))
        {
            collectTxtScript.greenBottleCount++;
        }
        else if (gameObject.CompareTag("Bottle_Blue"))
        {
            collectTxtScript.blueBottleCount++;
        }
        else if (gameObject.CompareTag("Bottle_Orange"))
        {
            collectTxtScript.orangeBottleCount++;
        }
        else if (gameObject.CompareTag("Bottle_Yellow"))
        {
            collectTxtScript.yellowBottleCount++;
        }

        gameObject.SetActive(false);
        
        
    }
}
