using UnityEngine;
using TMPro;

public class Score_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] int pant = 0;
    [SerializeField] TextMeshProUGUI PointsText;

    
    void Start()
    {
        
    }

    public void AddScore()
    {
        pant++;
        PointsText.text = "Burkar pantade: " + pant.ToString();
    }

}
