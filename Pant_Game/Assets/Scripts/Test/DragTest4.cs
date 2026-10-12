using System.Collections;
using UnityEngine;
using static UnityEngine.UI.Image;

public class DragTest4 : MonoBehaviour
{

    [SerializeField] private GameObject Origin;

    
    public Rigidbody2D rb;

    GameObject HingePoint;
    HingeJoint2D hinge;

    Vector2 velocity;
    Vector2 lastPosition;
    Vector2 objPosition;

    bool move = false;

    [SerializeField] private float waitTime;

    private bool isReturning = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //Finds a GameObject with the name "HingePoint"
        HingePoint = GameObject.Find("HingePoint");

        transform.position = Origin.transform.position;
        rb.gravityScale = 0;
    }

    private void OnMouseDown()
    {
        
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        HingePoint.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(mousePosition).x, Camera.main.ScreenToWorldPoint(mousePosition).y, HingePoint.transform.position.z);

        
        hinge = HingePoint.GetComponent(typeof(HingeJoint2D)) as HingeJoint2D;
        
        move = true;
        
        hinge.enabled = true;
        
        hinge.connectedBody = rb;
        
        hinge.autoConfigureConnectedAnchor = false;

        rb.gravityScale = 1;


    }

    private void FixedUpdate()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        HingePoint.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(mousePosition).x, Camera.main.ScreenToWorldPoint(mousePosition).y, HingePoint.transform.position.z);

        if (move == true)
        {
            isReturning = false;


            objPosition = transform.position;
            velocity = (objPosition - lastPosition) / (Time.fixedDeltaTime);
            lastPosition = transform.position;

        }

        if (isReturning)
        {

            transform.position = Vector3.Lerp(transform.position, Origin.transform.position, Time.deltaTime * 20);

        }

    }

    private void OnMouseUp()
    {
        //Removes the hinges influence from the rigidbody
        hinge.connectedBody = null;
        //Allows the Anchor point to be moved for when we click on a new rigid body
        hinge.autoConfigureConnectedAnchor = true;
        //Disables the rigid body
        hinge.enabled = false;
        //Stops the calculations in FixedUpdate
        move = false;
        //Combines the velocity from the mouse with the velocity from the hinge and applies it to the desired rigid body
        rb.linearVelocity = rb.linearVelocity + velocity;

        StartCoroutine(TimeToReturn());

    }



    IEnumerator TimeToReturn()
    {



        yield return new WaitForSeconds(waitTime);
        rb.gravityScale = 0;
        rb.linearVelocity = Vector2.zero;

        isReturning = true;
    }




}
