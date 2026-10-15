using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementTest : MonoBehaviour
{
    Rigidbody2D pRB;
    [SerializeField] float pMoveSpeed = 3;
    [SerializeField] Vector2 pMoveVector;
    private Vector2 reset;


    InputAction moveAction;

    [SerializeField] private List<GameObject> WallsList;
    [SerializeField] private List<GameObject> MinigameCanvasList;

    void Start()
    {
        reset = new Vector2(0, 0);

        pMoveSpeed = 3;


        pRB = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");

        foreach (GameObject Walls in WallsList)
        {
            Walls.SetActive(false);
        }
        WallsList[0].SetActive(true);


        foreach (GameObject BG in MinigameCanvasList)
        {
            BG.SetActive(false);
        }
        MinigameCanvasList[0].SetActive(true);

    }

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
            this.gameObject.transform.position = reset;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("CTest"))
        {
            Debug.Log("Center");

            foreach (GameObject Walls in WallsList)
            {
                Walls.SetActive(false);
            }
            WallsList[0].SetActive(true);


            foreach (GameObject BG in MinigameCanvasList)
            {
                BG.SetActive(false);
            }
            MinigameCanvasList[0].SetActive(true);

            this.gameObject.transform.position = reset;
        }




        if (collision.gameObject.CompareTag("UTest"))
        {
            Debug.Log("Up");

            foreach (GameObject Walls in WallsList)
            {
                Walls.SetActive(false);
            }
            WallsList[1].SetActive(true);


            foreach (GameObject BG in MinigameCanvasList)
            {
                BG.SetActive(false);
            }
            MinigameCanvasList[1].SetActive(true);

            this.gameObject.transform.position = reset;
        }

        

        if (collision.gameObject.CompareTag("LTest"))
        {
           

            foreach (GameObject Walls in WallsList)
            {
                Walls.SetActive(false);
            }
            WallsList[2].SetActive(true);


            foreach (GameObject BG in MinigameCanvasList)
            {
                BG.SetActive(false);
            }
            MinigameCanvasList[2].SetActive(true);

            this.gameObject.transform.position = reset;
        }

        if (collision.gameObject.CompareTag("RTest"))
        {
            Debug.Log("Right");

            foreach (GameObject Walls in WallsList)
            {
                Walls.SetActive(false);
            }
            WallsList[3].SetActive(true);


            foreach (GameObject BG in MinigameCanvasList)
            {
                BG.SetActive(false);
            }
            MinigameCanvasList[3].SetActive(true);

            this.gameObject.transform.position = reset;
        }

        /*if (collision.gameObject.CompareTag("DTest"))
        {
            Debug.Log("Down");

            foreach (GameObject Walls in WallsList)
            {
                Walls.SetActive(false);
            }
            WallsList[4].SetActive(true);


            foreach (GameObject BG in MinigameCanvasList)
            {
                BG.SetActive(false);
            }
            MinigameCanvasList[4].SetActive(true);

            this.gameObject.transform.position = reset;
        }*/






        if (collision.gameObject.CompareTag("OTest"))
        {
            Debug.Log("Nothing");


            this.gameObject.transform.position = reset;
        }

    }

}
