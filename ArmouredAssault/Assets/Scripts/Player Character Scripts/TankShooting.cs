using UnityEngine;
using UnityEngine.UI;

public class TankShooting : MonoBehaviour
{


	public int m_PlayerNumber = 1;  // Used to identify the different players.
	public Rigidbody m_Shell;  // Prefab of the shell.

	public GameObject playerShell;

	public Transform m_FireTransform;  
	public Slider m_AimSlider;  
	public float m_MinLaunchForce = 15f; 
	public float m_MaxLaunchForce = 30f;  
	public float m_MaxChargeTime = 0.75f;  

	private string m_FireButton;  
	private float m_CurrentLaunchForce;  
	private float m_ChargeSpeed;  
	private bool m_Fired; 
	public bool fireButtonPressed = false;  
	public Button fireButton; //UI Button for firing the cannon

	private void OnEnable ()
	{
		// When the tank is turned on, reset the launch force and the UI
		m_CurrentLaunchForce = m_MinLaunchForce;
		m_AimSlider.value = m_MinLaunchForce;
	
	}//End OnEnable()


	private void Start ()
	{
		//For playing on PC
		m_FireButton = "Fire1";

		// The rate that the launch force charges up is the range of possible forces by the max charge time.
		m_ChargeSpeed = (m_MaxLaunchForce - m_MinLaunchForce) / m_MaxChargeTime;

		playerShell = GameObject.FindGameObjectWithTag ("PlayerRocket");
		m_Shell = playerShell.GetComponent<Rigidbody> ();
	
	}//End Start()


	private void Update ()
	{
		// The slider should have a default value of the minimum launch force.
		m_AimSlider.value = m_MinLaunchForce;

		// If the max force has been exceeded and the shell hasn't yet been launched...
		if (m_CurrentLaunchForce >= m_MaxLaunchForce && !m_Fired) {
			// ... use the max force and launch the shell.
			m_CurrentLaunchForce = m_MaxLaunchForce;
			Fire ();
		
		} 
		
		if (fireButtonPressed == true) {//&& !m_Fired)
			// Increment the launch force and update the slider.
			m_CurrentLaunchForce += m_ChargeSpeed * Time.deltaTime;

			m_AimSlider.value = m_CurrentLaunchForce;

		}
		
	}//End Update()


	public void Fire ()
	{

		Debug.Log ("Firing");

		// Set the fired flag so only Fire is only called once.
		m_Fired = true;

		// Create an instance of the shell and store a reference to it's rigidbody.
		Rigidbody shellInstance =
			Instantiate (m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody; //possible change m_FireTransform.rotation to 90

		// Set the shell's velocity to the launch force in the fire position's forward direction.
		shellInstance.velocity = m_CurrentLaunchForce * m_FireTransform.forward;
		;

		// Reset the launch force.  This is a precaution in case of missing button events.
		m_CurrentLaunchForce = m_MinLaunchForce;
		Debug.Log ("Reset launch force");
		m_Fired = false;
	}//End Fire()

	 
	public void FireButtonPressed ()
	{
		fireButtonPressed = true;
	}//End FireButtonPressed()
		
	public void FireButtonReleased ()
	{
		fireButtonPressed = false;
	}//End FireButtonReleased()



	public void OnCollisionEnter (Collision other)
	{
		//If your rocket enters the enemies' hitbox
		if (other.gameObject.tag == "EnemyHitbox") {
			//Destory him (gameObject) (Maybe call this in EnemyAi Death() so can spawn parts and explode them out to look better
			Destroy (other.gameObject);


		}
	}//End OnCollisionEnter(Collision other )


}//End TankShooting
