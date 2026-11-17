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
        imageRb.position = new Vector2(Mathf.Clamp(imageRb.position.x, -0.6f, 0.6f), Mathf.Clamp(imageRb.position.y, -6.4f, 6.4f));

        Debug.Log("RB pos: " + imageRb.position);
        Debug.Log("Transform.position: " + imageRb.transform.position);
        Debug.Log("Transform.localPosition: " + imageRb.transform.localPosition);
    }
}
