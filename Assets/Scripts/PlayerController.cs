using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


	public float velBase;
	public float tempRotacion = 0.1f;
	float velRotacion;

	private float vel;
	bool isMoving;

	public Transform cam;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;
	public float Salto = 3f; 

	Vector3 velocidad;
	public float gravedad = -9.81f;
	private bool isGrounded;

	private float saltoTimeCounter;
	public float saltoTime;
	private bool isJumping;


	[HideInInspector] public Vector3 moveDir;


	B34AnimationController b34AnimationController;


	CharacterController characterController;

	Animator animator;


	void Start()
	{
		characterController = GetComponent<CharacterController>();
		b34AnimationController = GetComponentInChildren<B34AnimationController>();


	}

	void Update()
	{

		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

		if (isGrounded && velocidad.y < 0)
		{
			velocidad.y = -2f;
		}

		float vertical = Input.GetAxisRaw("Vertical");
		float horizontal = Input.GetAxisRaw("Horizontal");

		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			isJumping = true;
			saltoTimeCounter = saltoTime;
			velocidad.y = Mathf.Sqrt(Salto * -2f * gravedad);
			b34AnimationController.JumpTrigger();
		}

		if (Input.GetButton("Jump") && isJumping == true)
        {

			if (saltoTimeCounter > 0)
            {
				velocidad.y = Mathf.Sqrt(Salto * -2f * gravedad);
				saltoTimeCounter -= Time.deltaTime;
			}
            else
            {
				isJumping = false;
            }

		}

		if (Input.GetButtonUp("Jump"))
        {
			isJumping = false;
        }

		Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

		velocidad.y += gravedad + Time.deltaTime;

		characterController.Move(velocidad * Time.deltaTime);


		vel = velBase;
		if(direction.magnitude >= 0.1f)
        {
			float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
			float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref velRotacion, tempRotacion);

			transform.rotation = Quaternion.Euler(0f, angle, 0f);


			moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
			characterController.Move(moveDir.normalized * vel * Time.deltaTime);
			isMoving = true;

			b34AnimationController.SetForwardSpeedParameter(1f);
			//b34AnimationController.IsWalking(true);

		}

		if (direction.magnitude <= 0f)
		{
			isMoving = false;
			b34AnimationController.SetForwardSpeedParameter(0f);
			//b34AnimationController.IsWalking(false);
		}



	}
}
