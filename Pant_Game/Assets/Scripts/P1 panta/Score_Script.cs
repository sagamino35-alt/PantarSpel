using UnityEngine;
using TMPro;

public class Score_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] int pant;
    [SerializeField] TextMeshProUGUI PointsText;
    [SerializeField] TrashManager_Script TrashManager;

    
    void Start()
    {
        
        pant = TrashManager.collectedCount;
    }
    void Update()
    {
        PointsText.text = "Burkar kvar att panta: " + pant.ToString();
    }

    public void SubScore()
    {
        pant--;
        
    }

}
