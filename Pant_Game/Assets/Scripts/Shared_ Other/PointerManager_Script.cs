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

    private PointerAction controlls;

    [SerializeField] bool p1;
    [SerializeField] bool p2;
    [SerializeField] bool p3;

    private void Awake()
    {
        controlls = new PointerAction();
        Cursor.visible = false;

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
        controlls.PointerClick.Click.started += _ => startClick();
        controlls.PointerClick.Click.performed += _ => endClick();
    }


    private void Update()
    {
        cursorGO.transform.position = Input.mousePosition;
    }
    

    private void startClick()
    {
        if (p1 == true && p2 == false && p3 == false)
        {
            Debug.Log("Clicked with p1");
            cursorImage.sprite = pointer1_click;
        }


        if (p1 == false && p2 == true && p3 == false)
        {
            Debug.Log("Clicked with p2");
            cursorImage.sprite = pointer2_click;
        }

        if (p1 == false && p2 == false && p3 == true)
        {
            Debug.Log("Clicked with p3");
            cursorImage.sprite= pointer3_click;
        }

        if (p1 == true && p2 == true && p3 == true || 
                p1 == true && p2 == true && p3 == false || 
                    p1 == true && p2 == false && p3 == true || 
                        p1 == false && p2 == true && p3 == true ||
                            p1 == true && p2 == true && p3 == false 
                                || p1 == false && p2 == false && p3 == false)
        {
            Debug.Log("Clicked with p1");
            cursorImage.sprite = pointer1_click;
        }
        
    }
    private void endClick()
    {
        if (p1 == true && p2 == false && p3 == false)
        {
            Debug.Log("Clicked with p1");
            cursorImage.sprite = pointer1_hover;
        }


        if (p1 == false && p2 == true && p3 == false)
        {
            Debug.Log("Clicked with p2");
            cursorImage.sprite = pointer2_hover;
        }

        if (p1 == false && p2 == false && p3 == true)
        {
            Debug.Log("Clicked with p3");
            cursorImage.sprite = pointer3_hover;
        }

        if (p1 == true && p2 == true && p3 == true ||
                p1 == true && p2 == true && p3 == false ||
                    p1 == true && p2 == false && p3 == true ||
                        p1 == false && p2 == true && p3 == true ||
                            p1 == true && p2 == true && p3 == false
                                || p1 == false && p2 == false && p3 == false)
        {
            Debug.Log("Clicked with p1");
            cursorImage.sprite = pointer1_hover;
        }
    }

    
}
