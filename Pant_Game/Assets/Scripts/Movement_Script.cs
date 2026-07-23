using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Movement_Script : MonoBehaviour
{
    Rigidbody2D pRB;
    [SerializeField] float pMoveSpeed = 3;
    [SerializeField] Vector2 pMoveVector;
    InputAction moveAction;
    [SerializeField] private GameObject Canvas1;
    [SerializeField] private GameObject Canvas2;
    [SerializeField] private GameObject Canvas3;

    [SerializeField] private GameObject WallsBG1;
    [SerializeField] private GameObject WallsBG2;
    [SerializeField] private GameObject WallsBG3;

    
    void Start()
    {
        WallsBG1.SetActive(true);
        WallsBG2.SetActive(false);
        WallsBG3.SetActive(false);

        pRB = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");


        Canvas1.SetActive(true);
        Canvas2.SetActive(false);
        Canvas3.SetActive(false);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pMoveVector = moveAction.ReadValue<Vector2>();
        pRB.linearVelocity = pMoveVector * pMoveSpeed;
        if (pMoveVector.magnitude > 0) 
        {
            if (pMoveVector.y > 0 && pMoveVector.x > 0 || 
                    pMoveVector.y < 0 && pMoveVector.x > 0 || 
                        pMoveVector.y < 0 && pMoveVector.x < 0 ||
                            pMoveVector.y > 0 && pMoveVector.x < 0)
            {
                pMoveSpeed = 0;
            }
            
            else
            {
                pMoveSpeed = 3;
            }
        }
        if (pMoveVector.magnitude == 0)
        {
            this.gameObject.transform.position = new Vector2(0, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NoBG"))
        {
            this.gameObject.transform.position = new Vector2(0, 0);
        }

        if (collision.gameObject.CompareTag("BG1"))
        {
            Debug.Log("Going back to BG1");
            this.gameObject.transform.position = new Vector2(0, 0);
            Canvas1.SetActive(true);
            Canvas2.SetActive(false);
            Canvas3.SetActive(false);

            WallsBG1.SetActive(true);
            WallsBG2.SetActive(false);
            WallsBG3.SetActive(false);

        }
        if (collision.gameObject.CompareTag("BG2"))
        {
            Debug.Log("Go to BG2");
            
            //change UI image to BG2 and set BG1 to inactive
            this.gameObject.transform.position = new Vector2(0,0);
            Canvas1.SetActive(false);
            Canvas2.SetActive(true);
            Canvas3.SetActive(false);

            WallsBG1.SetActive(false);
            WallsBG2.SetActive(true);
            WallsBG3.SetActive(false);
        }
        if (collision.gameObject.CompareTag("BG3"))
        {
            Debug.Log("Go to BG3");
            
            
            this.gameObject.transform.position = new Vector2(0,0);
            Canvas1.SetActive(false);
            Canvas2.SetActive(false);
            Canvas3.SetActive(true);

            WallsBG1.SetActive(false);
            WallsBG2.SetActive(false);
            WallsBG3.SetActive(true);
        }




    }




}
