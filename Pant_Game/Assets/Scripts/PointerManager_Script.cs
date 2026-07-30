using System.Transactions;
using UnityEngine;
using UnityEngine.UI;

public class PointerManager_Script : MonoBehaviour
{
    public GameObject cursorGO;
    public Image cursorImage;
    public Sprite pointer1_hover;
    public Sprite pointer1_click;
    private PointerAction controlls;


    private void Awake()
    {
        controlls = new PointerAction();
        Cursor.visible = false;
        cursorImage.sprite = pointer1_hover;

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
        Debug.Log("Clicked");
        cursorImage.sprite = pointer1_click;
    }
    private void endClick()
    {
        Debug.Log("Stoped clicked");
        cursorImage.sprite = pointer1_hover;
    }

    
}
