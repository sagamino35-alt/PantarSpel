using UnityEngine;

public class Drag_Script : MonoBehaviour
{
    GameObject HingePoint;
    HingeJoint2D hinge;
    public Rigidbody2D rb;
    
    Vector2 vel;
    Vector2 lastPos;
    Vector2 objPos;



    public bool moving = false;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        HingePoint = this.gameObject;
        hinge = HingePoint.GetComponent(typeof(HingeJoint2D)) as HingeJoint2D;



        rb.gravityScale = 1;
        moving = false;
        hinge.enabled = false;
    } 

    private void OnMouseDown()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        
        HingePoint.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(mousePos).x, Camera.main.ScreenToWorldPoint(mousePos).y);

        hinge = HingePoint.GetComponent(typeof(HingeJoint2D)) as HingeJoint2D;

        hinge.enabled = true;

        moving = true;



        hinge.connectedBody = rb;
        hinge.autoConfigureConnectedAnchor = false;


        hinge.anchor = mousePos;


        rb.linearVelocity = Vector2.zero;
        rb.gravityScale = 0;

        Debug.Log("Mouse down on object");
        //set velocity to 0 when picking up object
        //set gravity to 0 when picking up object. Fixed object drooping 
    }

    private void FixedUpdate()
    {
        if (moving == true)
        {
            Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            HingePoint.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(mousePos).x, Camera.main.ScreenToWorldPoint(mousePos).y);



            objPos = transform.position;

            vel = (objPos - lastPos) / (Time.fixedDeltaTime);

            lastPos = transform.position;

        } 


    }

    private void OnMouseUp()
    {
        hinge.connectedBody = null;

        hinge.autoConfigureConnectedAnchor = true;

        hinge.enabled = false;

        moving = false;

        rb.linearVelocity = rb.linearVelocity + vel;

        rb.gravityScale = 1;

    }

}
