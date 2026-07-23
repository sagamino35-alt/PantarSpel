using Unity.VisualScripting;
using UnityEngine;

public class Collect_Script : MonoBehaviour
{
    public CollectTxt_Script collectTxtScript;
    public void OnMouseClick()
    {
        collectTxtScript.UpdateCollectText();
        Debug.Log("Collect button clicked");
        
        gameObject.SetActive(false);
        
    }
}
