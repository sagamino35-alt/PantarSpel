using System.Collections;
using TMPro;
using UnityEngine;

public class Collision_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Drag_Script dragScript;
    Money_Script money_Script;
    Score_Script score_Script;


    void Start()
    {
        dragScript = GetComponent<Drag_Script>();
        
    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Insert") && dragScript.moving)
        {
            if (collision.gameObject.CompareTag("Insert") && !dragScript.moving)
            {
                Debug.Log("Bottle should be destroyed");
                Destroy(transform.parent.gameObject);
                score_Script.SubScore();
                money_Script.AddMoney();

            }
            else if (!collision.gameObject.CompareTag("Insert") || dragScript.moving)
            {
                Debug.Log("Bottle is still moving or is not colliding, not destroyed");
            }
            else if (collision.gameObject.CompareTag("Insert") || !dragScript.moving)
            {
                Debug.Log("Bottle is still moving or is not colliding, not destroyed");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }


    void FixedUpdate()
    {
        
    }

    
    //check if object is moving
    //if so, do not destroy object on collision with insert
    //if not, destroy object on collision with insert
    //Use update to constantly check if object is moving or not


}
