using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.UI;

public class PointerManager_Script : MonoBehaviour
{
    [SerializeField] GameObject cursorGO;
    [SerializeField] Image cursorImage;
    [SerializeField] Sprite pointer1_hover;
    [SerializeField] Sprite pointer1_click;

    [SerializeField] Sprite pointer2_hover;
    [SerializeField] Sprite pointer2_click;

    [SerializeField] Sprite pointer3_hover;
    [SerializeField] Sprite pointer3_click;

    [SerializeField] PointerAction controlls;

    public bool p1;
    public bool p2;
    public bool p3;

    public List<Sprite> H_PointerList;
    public List<Sprite> ClickPointerList;

    public List<bool> boolList;


    private void Awake()
    {
        controlls = new PointerAction();
        

    }

    
    private void OnEnable()
    {
        controlls.Enable();
    }

    private void OnDisable()
    {
        controlls.Disable();
    }


    private void Start()
    {
        controlls.PointerClick.Click.started += _ => StartClick();
        controlls.PointerClick.Click.performed += _ => EndClick();

        p1 = true;
        p2 = false;
        p3 = false;


    }

    public void ChangeToP2()
    {
        p1 = false;
        p2 = true;
        p3 = false;

    }


    private void Update()
    {
        cursorGO.transform.position = Input.mousePosition;





    }
    

    private void StartClick()
    {
        if (p1 == true && p2 == false && p3 == false)
        {
            
            cursorImage.sprite = pointer1_click;
        }


        if (p1 == false && p2 == true && p3 == false)
        {
            
            cursorImage.sprite = pointer2_click;
        }

        if (p1 == false && p2 == false && p3 == true)
        {
            
            cursorImage.sprite = pointer3_click;
        }

        if (p1 == true && p2 == true && p3 == true || 
                p1 == true && p2 == true && p3 == false || 
                    p1 == true && p2 == false && p3 == true || 
                        p1 == false && p2 == true && p3 == true ||
                            p1 == true && p2 == true && p3 == false 
                                || p1 == false && p2 == false && p3 == false)
        {
            
            cursorImage.sprite = pointer1_click;
        }

        
        
    }
    private void EndClick()
    {
        if (p1 == true && p2 == false && p3 == false)
        {
            
            cursorImage.sprite = pointer1_hover;
        }


        if (p1 == false && p2 == true && p3 == false)
        {
            
            cursorImage.sprite = pointer2_hover;
        }

        if (p1 == false && p2 == false && p3 == true)
        {
            
            cursorImage.sprite = pointer3_hover;
        }

        if (p1 == true && p2 == true && p3 == true ||
                p1 == true && p2 == true && p3 == false ||
                    p1 == true && p2 == false && p3 == true ||
                        p1 == false && p2 == true && p3 == true ||
                            p1 == true && p2 == true && p3 == false
                                || p1 == false && p2 == false && p3 == false)
        {
            
            cursorImage.sprite = pointer1_hover;
        }


        





    }

    
}
