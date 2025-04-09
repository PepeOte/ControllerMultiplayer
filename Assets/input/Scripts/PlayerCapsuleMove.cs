using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCapsuleMove : MonoBehaviour
{
    private Rigidbody rb;
    
    public float jumpForce = 100f;
    
    private PlayerInput playerInput;
    
    private Vector2 moveInput;
    
    private float moveForce = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
 	rb = GetComponent<Rigidbody>();
 	playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = playerInput.actions["Move"].ReadValue<Vector2>();
    }
    
    void FixedUpdate(){
    	rb.AddForce(new Vector3(moveInput.x, 0, moveInput.y) * moveForce);
    }
    
    public void Jump(InputAction.CallbackContext context){
    	if(context.performed){
    		rb.AddForce(Vector3.up * jumpForce);
    		Debug.Log("Jumping");
    	}
    	Debug.Log(context.phase);
    }
}
