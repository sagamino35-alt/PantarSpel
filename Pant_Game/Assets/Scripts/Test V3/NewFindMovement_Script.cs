using UnityEngine;
using UnityEngine.InputSystem;

public class NewFindMovement_Script : MonoBehaviour
{
    private Rigidbody2D imageRb;
    [SerializeField] private float canvasSpeed = 5;
    [SerializeField] private Vector2 cVector;


    [SerializeField] private InputActionReference arrowMovement;
    void Start()
    {
        imageRb = GetComponent<Rigidbody2D>();

    }
    //230 1500
    // Update is called once per frame
    void FixedUpdate()
    {
        cVector = arrowMovement.action.ReadValue<Vector2>();
        imageRb.linearVelocity = cVector * canvasSpeed;
        imageRb.position = new Vector2(Mathf.Clamp(imageRb.position.x, -230, 230), Mathf.Clamp(imageRb.position.y, -1500, 1500));

    }
}
