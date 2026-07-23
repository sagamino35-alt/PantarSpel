using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject BottlePrefab;
    [SerializeField] private GameObject spawnPoint;
    

    
    private void OnMouseDown()
    {
        Debug.Log("Spawner clicked");
        Instantiate<GameObject>(BottlePrefab, spawnPoint.transform.position, Quaternion.identity);


    }

}
