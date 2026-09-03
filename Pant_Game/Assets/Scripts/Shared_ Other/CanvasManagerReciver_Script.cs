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
    public void OpenP1()
    {
        CanvasManager_Script.OpenP1();
    }

    public void OpenP2()
    {
        CanvasManager_Script.OpenP2();
    }

    public void OpenP3()
    {
        CanvasManager_Script.OpenP3();
    }

    
}
