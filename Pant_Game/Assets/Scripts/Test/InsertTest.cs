using System.Collections;
using UnityEngine;

public class InsertTest : MonoBehaviour
{
    [SerializeField] private DragTest4 dragTest;
    [SerializeField] private SpawnerTest spawnerTest;

   
    private void Update()
    {
        dragTest = FindAnyObjectByType<DragTest4>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (dragTest.move == true)
        {
            StartCoroutine(WaitDetection(collision));
        }
        
    }

    IEnumerator WaitDetection(Collider2D collision)
    {
        yield return new WaitForSeconds (1f);
        if (dragTest.move == true)
        {
            if (collision.CompareTag("Bottle_Red"))
            {

                Debug.Log("Red bottle detected");
                spawnerTest.trashAmountOS = 0;
                StartCoroutine(WaitForDestroy(collision));

            }
        }
        else
        {
            Debug.Log("Moved out of insert");
        }
    }
    IEnumerator WaitForDestroy(Collider2D collision)
    {
        dragTest.InsertedBottle();
        yield return new WaitForSeconds(1f);
        Destroy(collision.gameObject);
    }
}
