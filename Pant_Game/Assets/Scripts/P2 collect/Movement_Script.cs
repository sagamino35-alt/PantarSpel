using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Movement_Script : MonoBehaviour
{
    Rigidbody2D pRB;
    [SerializeField] float pMoveSpeed = 3;
    [SerializeField] Vector2 pMoveVector;
    private Vector2 reset;


    InputAction moveAction;
    

    [SerializeField] private List<GameObject> BgList;
    [SerializeField] private List<GameObject> BgWallsList;

    
    void Start()
    {
        reset = new Vector2 (0,0);

        pMoveSpeed = 3;
       

        pRB = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");

        //sätter alla bakgrunder och walls till false och aktiverar BG0 Walls0
        foreach (GameObject BG in BgList)
        {
            BG.SetActive(false);
        }
        BgList[0].SetActive(true);

        foreach (GameObject Walls in BgWallsList)
        {
            Walls.SetActive(false);
        }
        BgWallsList[0].SetActive(true);
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
            this.gameObject.transform.position = reset;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NoBG"))
        {
            this.gameObject.transform.position = reset;
        }



        //Main road
        if (collision.gameObject.CompareTag("BG0"))
        {
            Debug.Log("Going back to BG0");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[0].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[0].SetActive(true);


        }

        if (collision.gameObject.CompareTag("BG1"))
        {
            Debug.Log("Going back to BG1");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[1].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[1].SetActive(true);


        }

        if (collision.gameObject.CompareTag("BG2"))
        {
            Debug.Log("Go to BG2");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[2].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[2].SetActive(true);


        }

        if (collision.gameObject.CompareTag("BG3"))
        {
            Debug.Log("Go to BG3");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[3].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[3].SetActive(true);


        }

        if (collision.gameObject.CompareTag("BG4"))
        {
            Debug.Log("Go to BG4");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[4].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[4].SetActive(true);


        }

        //West road
        if (collision.gameObject.CompareTag("west road BG0"))
        {
            Debug.Log("Go to west road BG0");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[5].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[5].SetActive(true);


        }

        if (collision.gameObject.CompareTag("west road BG1"))
        {
            Debug.Log("Go to west road BG1");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[6].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[6].SetActive(true);


        }

        if (collision.gameObject.CompareTag("west road BG2"))
        {
            Debug.Log("Go to west road BG2");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[7].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[7].SetActive(true);


        }

        if (collision.gameObject.CompareTag("west road BG3"))
        {
            Debug.Log("Go to west road BG3");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[8].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[8].SetActive(true);


        }

        if (collision.gameObject.CompareTag("west road BG4"))
        {
            Debug.Log("Go to west road BG4");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[9].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[9].SetActive(true);


        }

        if (collision.gameObject.CompareTag("west road BG5"))
        {
            Debug.Log("Go to west road BG5");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[10].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[10].SetActive(true);


        }

        //East road

        if (collision.gameObject.CompareTag("east road BG0"))
        {
            Debug.Log("Go to east road BG0");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[11].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[11].SetActive(true);

        }

        if (collision.gameObject.CompareTag("east road BG1"))
        {
            Debug.Log("Go to east road BG1");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[12].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[12].SetActive(true);

        }

        if (collision.gameObject.CompareTag("east road BG2"))
        {
            Debug.Log("Go to east road BG2");

            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[13].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[13].SetActive(true);

        }

        if (collision.gameObject.CompareTag("east road BG3"))
        {
            Debug.Log("Go to east road BG3");
            
            this.gameObject.transform.position = reset;

            foreach (GameObject BG in BgList)
            {
                BG.SetActive(false);
            }
            BgList[14].SetActive(true);

            foreach (GameObject Walls in BgWallsList)
            {
                Walls.SetActive(false);
            }
            BgWallsList[14].SetActive(true);

        }







    }

}
