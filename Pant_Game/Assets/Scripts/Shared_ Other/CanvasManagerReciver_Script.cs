using Unity.VisualScripting;
using UnityEngine;

public class CanvasManagerReciver_Script : MonoBehaviour
{
    [SerializeField] GameObject CanvasManager;
    [SerializeField] CanvasManager_Script CanvasManager_Script;

    private void Start()
    {
        CanvasManager = GameObject.Find("CanvasManager");
        CanvasManager_Script = CanvasManager.GetComponent<CanvasManager_Script>();
        
    }
    private void OpenP1()
    {
        
    }
}
