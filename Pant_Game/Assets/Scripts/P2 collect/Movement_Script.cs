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
    [SerializeField] private GameObject BG1;
    [SerializeField] private GameObject BG2;
    [SerializeField] private GameObject BG3;
    [SerializeField] private GameObject BG4;


    [SerializeField] private GameObject WallsBG1;
    [SerializeField] private GameObject WallsBG2;
    [SerializeField] private GameObject WallsBG3;
    [SerializeField] private GameObject WallsBG4;

    [SerializeField] private List<GameObject> BgList;
    [SerializeField] private List<GameObject> BgWallsList;

    
    void Start()
    {
        reset = new Vector2 (0,0);

        pMoveSpeed = 3;
        WallsBG1.SetActive(true);
        WallsBG2.SetActive(false);
        WallsBG3.SetActive(false);
        WallsBG4.SetActive(false);

        pRB = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");


        BG1.SetActive(true);
        BG2.SetActive(false);
        BG3.SetActive(false);
        BG4.SetActive(false);
        
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



    }




}
