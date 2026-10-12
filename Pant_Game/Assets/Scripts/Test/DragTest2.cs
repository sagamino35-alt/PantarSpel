using System.Collections;
using UnityEngine;

public class DragTest2 : MonoBehaviour
{
    [SerializeField] private GameObject MousePoint;

    [SerializeField] private GameObject Origin;

    [SerializeField] private SpringJoint2D hinge;
    [SerializeField] private Rigidbody2D rb;



    Vector2 vel;
    Vector2 lastPos;
    Vector2 objPos;

    [SerializeField] private float waitTime;


    private bool moving = false;

    bool isReturning;

    private void Start()
    {
        hinge = GetComponent(typeof(SpringJoint2D)) as SpringJoint2D;

        transform.position = Origin.transform.position;
        rb.gravityScale = 0;
        moving = false;
        hinge.enabled = false;
    }

    private void OnMouseDown()
    {
        

        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        MousePoint.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(mousePos).x,
            Camera.main.ScreenToWorldPoint(mousePos).y);


        hinge.enabled = true;

        moving = true;

        hinge = GetComponent(typeof(SpringJoint2D)) as SpringJoint2D;

        hinge.connectedBody = MousePoint.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        hinge.autoConfigureConnectedAnchor = false;

        hinge.distance = 0.005f;
        hinge.anchor = MousePoint.transform.position;
        hinge.connectedAnchor = MousePoint.transform.position;

        rb.gravityScale = 1;
        rb.linearVelocity = Vector2.zero;

        isReturning = false;
    }
    private void FixedUpdate()
    {
        if (moving == true)
        {
            isReturning = false;

            Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            MousePoint.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(mousePos).x,
                Camera.main.ScreenToWorldPoint(mousePos).y);

            

            hinge.connectedAnchor = MousePoint.transform.position;

            objPos = transform.position;

            vel = (objPos - lastPos) / (Time.fixedDeltaTime);

            lastPos = transform.position;

        }

        if (isReturning)
        {

            transform.position = Vector3.Lerp(transform.position, Origin.transform.position, Time.deltaTime * 20);
            
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
