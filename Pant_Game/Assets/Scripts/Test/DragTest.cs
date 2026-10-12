using System.Collections;
using UnityEngine;

public class DragTest : MonoBehaviour
{
    [SerializeField] private GameObject HingePoint;
    [SerializeField] private HingeJoint2D hinge;
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private GameObject Origin;

    Vector2 vel;
    Vector2 lastPos;
    Vector2 objPos;

    [SerializeField] private float waitTime;


    [SerializeField] private bool moving = false;
    [SerializeField] private bool isReturning;

    Vector2 offset;
    void Start()
    {


        rb = GetComponent<Rigidbody2D>();
        HingePoint = gameObject;
        hinge = HingePoint.GetComponent(typeof(HingeJoint2D)) as HingeJoint2D;


        transform.position = Origin.transform.position;
        rb.gravityScale = 0;
        moving = false;
        hinge.enabled = false;
    }

    private void OnMouseDown()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

         offset = Camera.main.ScreenToWorldPoint(mousePos) - transform.position;

        HingePoint.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(mousePos).x, 
            Camera.main.ScreenToWorldPoint(mousePos).y) - offset;

        hinge = HingePoint.GetComponent(typeof(HingeJoint2D)) as HingeJoint2D;

        hinge.enabled = true;

        moving = true;



        hinge.connectedBody = rb;
        hinge.autoConfigureConnectedAnchor = false;


        hinge.anchor = mousePos;


        rb.linearVelocity = Vector2.zero;
        rb.gravityScale = 0;

        isReturning = false;

        //Debug.Log("Mouse down on object");
        //set velocity to 0 when picking up object
        //set gravity to 0 when picking up object. Fixed object drooping 
    }

    private void FixedUpdate()
    {
        if (moving == true)
        {
            isReturning = false;

            Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            HingePoint.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(mousePos).x, 
                Camera.main.ScreenToWorldPoint(mousePos).y) - offset;



            objPos = transform.position;

            vel = (objPos - lastPos) / (Time.fixedDeltaTime);

            lastPos = transform.position;

        }
        else
        {
            
            

            
        }

    }

    private void Update()
    {
        if(isReturning)
        {
           
            transform.position = Vector3.Lerp(transform.position, Origin.transform.position, Time.deltaTime * 20);
            //transform.position = new Vector3(Mathf.Lerp(transform.position.y, Origin.transform.position.y, t), 0);
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