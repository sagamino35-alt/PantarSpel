using UnityEngine;

public class DayButtonReciver_Script : MonoBehaviour
{
    [SerializeField] DayManager_Script DayManager;
    void Start()
    {
        DayManager = FindAnyObjectByType<DayManager_Script>();
    }

    // Update is called once per frame
    public void ResetDayButton()
    {
        DayManager.ResetDay();
    }
}
