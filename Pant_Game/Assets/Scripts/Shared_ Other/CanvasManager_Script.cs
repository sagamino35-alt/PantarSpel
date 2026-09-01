using UnityEngine;

public class CanvasManager_Script : MonoBehaviour
{
    [SerializeField] GameObject gameP1Find;
    [SerializeField] GameObject gameP2Recycle;
    [SerializeField] GameObject gameP3Shop;

    private void Start()
    {
        gameP1Find.SetActive(true);
        gameP2Recycle.SetActive(false);
        gameP3Shop.SetActive(false);
        
    }
    public void OpenP1()
    {
        Debug.Log("Clicked button, go to find");
        gameP1Find.SetActive(true);
        gameP2Recycle.SetActive(false);
        gameP3Shop.SetActive(false);
    }

    public void OpenP2()
    {
        Debug.Log("Clicked button, go to Recycle");
        gameP1Find.SetActive(false);
        gameP2Recycle.SetActive(true);
        gameP3Shop.SetActive(false);
    }

    public void OpenP3()
    {
        Debug.Log("Clicked button, go to Shop");
        gameP1Find.SetActive(false);
        gameP2Recycle.SetActive(false);
        gameP3Shop.SetActive(true);
    }

}
