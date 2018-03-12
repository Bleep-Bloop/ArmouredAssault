using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class TankController : MonoBehaviour 
{
	public int m_PlayerNumber = 1;              // Used to identify which tank belongs to which player.  This is set by this tank's manager.
	public float m_Speed = 5f;                  // How fast the tank moves forward and back.
	public float m_TurnSpeed = 180f;            // How fast the tank turns in degrees per second.


	public Image joystickBackgroundImage; //temp public
	public Image joystickImage; //temp public

	public GameManager gameManager;

	private string m_MovementAxisName = "Vertical";          // The name of the input axis for moving forward and back.
	private string m_TurnAxisName = "Horizontal";            // The name of the input axis for turning.
	private Rigidbody m_Rigidbody;              // Reference used to move the tank.
	private float m_MovementInputValue;         // The current value of the movement input.
	private float m_TurnInputValue;             // The current value of the turn input.


	public Sprite[] HeartSprites;
	public Image HealthBar;

	public int currentHealth = 3;

	public MeshRenderer playerMesh;

	private Vector3 inputDirection; //used to be inputVector

	public bool movingForward = false;

	private void Awake ()
	{
		m_Rigidbody = GetComponent<Rigidbody> ();

		playerMesh = GetComponent<MeshRenderer> ();


	} //End Awake()


	private void OnEnable ()
	{
		// When the tank is turned on, make sure it's not kinematic.
		m_Rigidbody.isKinematic = false;

		// Also reset the input values.
		m_MovementInputValue = 0f;
		m_TurnInputValue = 0f;
	
	} //End OnEnable()


	private void OnDisable ()
	{
		// When the tank is turned off, set it to kinematic so it stops moving.
		m_Rigidbody.isKinematic = true;
	} //End OnDisable()


	private void Start ()
	{

		gameManager = GameManager.FindObjectOfType<GameManager> ();

	} //End Start()

	/// <summary>
	/// //////////////////////////////////////////////////////////////////////////////////////////////////
	/// </summary>
	private void Update ()
	{


		// Store the value of both input axes.
		m_MovementInputValue = Input.GetAxis (m_MovementAxisName);
		m_TurnInputValue = Input.GetAxis (m_TurnAxisName);

		EngineAudio ();


		HealthBar.sprite = HeartSprites[currentHealth];

		if (currentHealth == 0) {
			Death ();
		}

	} //End Update()


	private void EngineAudio ()
	{
		// If there is no input (the tank is stationary)...
		if (Mathf.Abs (m_MovementInputValue) < 0.1f && Mathf.Abs (m_TurnInputValue) < 0.1f)
		{

		}
		else
		{

		}

	} //End EngineAudio()


	private void FixedUpdate ()
	{
		// Adjust the rigidbodies position and orientation in FixedUpdate.
		Move ();
		Turn ();
	} //End FixedUpdate()


	public void Move ()
	{

		// Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
		Vector3 movement = transform.forward * m_MovementInputValue * m_Speed * Time.deltaTime;

		// Apply this movement to the rigidbody's position.
		m_Rigidbody.MovePosition(m_Rigidbody.position + movement);

	} //End Move()


	//For some reason I cant delete this I will get errors
	private void Turn ()
	{
		// Determine the number of degrees to be turned based on the input, speed and time between frames.
		float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;

		// Make this into a rotation in the y axis.
		Quaternion turnRotation = Quaternion.Euler (0f, turn, 0f);

		// Apply this rotation to the rigidbody's rotation.
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnRotation);

		//Debug.Log (m_TurnInputValue);
	} //End Turn


	public void TurnClockwise()
	{
		// Determine the number of degrees to be turned based on the input, speed and time between frames.
		float turn = 1 * m_TurnSpeed * Time.deltaTime;

		// Make this into a rotation in the y axis.
		Quaternion turnRotation = Quaternion.Euler (0f, turn, 0f);

		// Apply this rotation to the rigidbody's rotation.
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnRotation);
	
	} //End TurnClockwise()


	public void TurnCounterClockwise()
	{
		// Determine the number of degrees to be turned based on the input, speed and time between frames.
		float turn = -1 * m_TurnSpeed * Time.deltaTime;

		// Make this into a rotation in the y axis.
		Quaternion turnRotation = Quaternion.Euler (0f, turn, 0f);

		// Apply this rotation to the rigidbody's rotation.
		m_Rigidbody.MoveRotation (m_Rigidbody.rotation * turnRotation);
	
	} //End TurnCounterClockwise


	public void MoveForward ()
	{

		Vector3 movement = transform.forward * 1 * m_Speed * Time.deltaTime;

		m_Rigidbody.MovePosition(m_Rigidbody.position + movement);

	} //End MoveForward()


	public void MoveBackwards ()
	{
		Vector3 movement = transform.forward * -1 * m_Speed * Time.deltaTime;

		m_Rigidbody.MovePosition(m_Rigidbody.position + movement);

	} //MoveBackwards()

	public void Damage()
	{
		Debug.Log ("OUCH");
		currentHealth = currentHealth - 1;
	} //End Damage()

	public void Death()
	{
		Debug.Log ("YOU LOSE");
		SceneManager.LoadScene ("MainMenuScene");
	} //End Death


}//End TankController