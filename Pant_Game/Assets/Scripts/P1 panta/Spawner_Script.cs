using Unity.VisualScripting;
using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject BottlePrefab;
    [SerializeField] private GameObject spawnPoint;
    public int clickCount = 0;
    [SerializeField] TrashManager_Script trashManager;

    void Start()
    {
        clickCount = 0;
    }
    private void OnMouseDown()
    {
        clickCount++;
        if (clickCount == trashManager.collectedCount || clickCount < trashManager.collectedCount)
        {
            Debug.Log("Spawner clicked");
            Instantiate<GameObject>(BottlePrefab, spawnPoint.transform.position, Quaternion.identity);

        }
        


    }

}
