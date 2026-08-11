using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Movement")]
    public float walkSpeed = 5f;
    public float turnSpeed = 100f;

    private CharacterController controller;
    private Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    void HandleRotation()
    {
        float turnInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrows
        transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
    }

    void HandleMovement()
    {
        float moveInput = Input.GetAxis("Vertical"); // W/S or Up/Down arrows

        // Move forward/backward relative to where player is facing
        Vector3 move = transform.forward * moveInput;
        controller.Move(move * walkSpeed * Time.deltaTime);
        animator.SetFloat("Speed_f", Mathf.Abs(moveInput));
    }
}
