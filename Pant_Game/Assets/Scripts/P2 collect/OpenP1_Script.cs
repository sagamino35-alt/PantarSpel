using UnityEngine;

public class OpenP1_Script : MonoBehaviour
{
    [SerializeField] GameObject gameP1;
    [SerializeField] GameObject gameP2;

    public void OpenCloseP1 ()
    {
        Debug.Log("Clicked button, go to shop");
        gameP1.SetActive (true);
        gameP2.SetActive (false);

    }



}
