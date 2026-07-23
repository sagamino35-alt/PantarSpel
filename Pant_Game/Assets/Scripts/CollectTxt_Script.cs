using TMPro;
using UnityEngine;

public class CollectTxt_Script : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI CollectText;
    public int collectedCount = 0;

    public void UpdateCollectText()
    {
        collectedCount++;
        CollectText.text = "Burkar samlade: " + collectedCount.ToString();
    }

    void Update()
    {
        CollectText.text = "Burkar samlade: " + collectedCount.ToString();
    }








}
