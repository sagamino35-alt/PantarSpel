using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject BottlePrefab;
    [SerializeField] private GameObject spawnPoint;
    public int clickCount = 0;

    void Start()
    {
        clickCount = 0;
    }
    private void OnMouseDown()
    {
        clickCount++;
        if (clickCount == PlayerPrefs.GetInt("PantAmount") || clickCount < PlayerPrefs.GetInt("PantAmount"))
        {
            Debug.Log("Spawner clicked");
            Instantiate<GameObject>(BottlePrefab, spawnPoint.transform.position, Quaternion.identity);

        }
        


    }

}
