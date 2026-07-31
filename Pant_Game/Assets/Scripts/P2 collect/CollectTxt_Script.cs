using TMPro;
using UnityEngine;

public class CollectTxt_Script : MonoBehaviour
{
    public TextMeshProUGUI CollectText;
    public int collectedCount = 0;

    public void UpdateCollectText()
    {
        collectedCount++;
        
    }

    void Update()
    {
        CollectText.text = "Burkar samlade: " + collectedCount.ToString();
    }








}
