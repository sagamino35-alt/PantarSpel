using UnityEngine;

public class SpawnerTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject BottlePrefab;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private int trashAmountOS = 0;

    
    private void OnMouseDown()
    {
        

        if (trashAmountOS == 0)
        {
            trashAmountOS++;
            Debug.Log("Spawner clicked");
            Instantiate<GameObject>(BottlePrefab, spawnPoint.transform.position, Quaternion.identity);
        }
        



    }
}
