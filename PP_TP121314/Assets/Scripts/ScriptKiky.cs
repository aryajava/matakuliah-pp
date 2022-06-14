using UnityEngine;

public class ScriptKiky : MonoBehaviour
{
    Animator myAnimator;
    public float speed = 10.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    float currSpeed, param1;
    bool param2, param3;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        param1 = 0; param2 = false; param3 = false;
        if (controller.isGrounded)
        {
            currSpeed = speed;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                param2 = true;
                currSpeed = speed / 2;
            }
            if (Input.GetKey(KeyCode.LeftControl)) param3 = true;
            param1 = Mathf.Abs(Input.GetAxis("Vertical"));
            myAnimator.SetFloat("Speed", param1);
            transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
            myAnimator.SetFloat("Speed", param1);
            myAnimator.SetBool("Shift", param2);
            myAnimator.SetBool("Attack", param3);
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= currSpeed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
                param1 = 0.2f;
            }
        }
        if (!myAnimator.IsInTransition(0))
        {
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}
