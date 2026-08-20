using UnityEditor;
using UnityEngine;

public class Money_Script : MonoBehaviour
{
    public static void dontDestroyOnLoad(Money_Script moneyScript)
    {
        
    }
    public int moneyAmount;

    private void Update()
    {
        
        
    }

    public void AddMoney()
    {
        moneyAmount++;
    }


}
