using TMPro;
using UnityEngine;

public class TrashManager_Script : MonoBehaviour
{
    public TextMeshProUGUI CollectText;
    public int collectedCount = 0;
    public int redBottleCount = 0;
    public int greenBottleCount = 0;
    public int blueBottleCount = 0;
    public int orangeBottleCount = 0;
    public int yellowBottleCount = 0;

    public void UpdateCollectText()
    {
        collectedCount++;


    }

    void Update()
    {
        CollectText.text = "Burkar samlade: " + collectedCount.ToString();
    }
}
