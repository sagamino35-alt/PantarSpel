using System.Collections;
using TMPro;
using UnityEngine;

public class Collision_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Drag_Script dragScript;
    
   

    void Start()
    {
        dragScript = GetComponent<Drag_Script>();
        
    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(CheckCollision(collision, FindAnyObjectByType<Score_Script>()));
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }


    void FixedUpdate()
    {
        
    }

    IEnumerator CheckCollision(Collider2D collision, Score_Script score_Script)
    {
        if (collision.gameObject.CompareTag("Insert") && dragScript.moving)
        {
            Debug.Log("Starting count down");
            yield return new WaitForSeconds(1f);
            Debug.Log("Count down stopped");
            StartCoroutine(CheckIfMoving(collision, score_Script));
        }
        
        
    }

    IEnumerator CheckIfMoving(Collider2D collision, Score_Script score_Script)
    {
        if (collision.gameObject.CompareTag("Insert") && !dragScript.moving)
        {
           Debug.Log("Bottle should be destroyed");
           Destroy(transform.parent.gameObject);
           score_Script.AddScore();
           
        }
        else if (!collision.gameObject.CompareTag("Insert") || dragScript.moving)
        {
            Debug.Log("Bottle is still moving or is not colliding, not destroyed");
        } 
        else if (collision.gameObject.CompareTag("Insert") || !dragScript.moving)
        {
            Debug.Log("Bottle is still moving or is not colliding, not destroyed");
        }

        yield return new WaitForSeconds(0.1f);

    }
    //check if object is moving
    //if so, do not destroy object on collision with insert
    //if not, destroy object on collision with insert
    //Use update to constantly check if object is moving or not


}
