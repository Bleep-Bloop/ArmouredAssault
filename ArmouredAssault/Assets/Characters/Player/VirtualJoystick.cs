using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler {

	private Image joystickBackgroundImage;
	private Image joystickImage;
	private Vector3 inputDirection; //used to be inputVector

	public TankController test;


	// Use this for initialization
	void Start () {

		joystickBackgroundImage = GetComponent<Image> ();
		joystickImage = transform.GetChild (0).GetComponent<Image> ();

	}

	public virtual void OnDrag(PointerEventData ped)
	{
		Debug.Log ("OnDrag");



		Vector2 pos = Vector2.zero;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle
			(joystickBackgroundImage.rectTransform, ped.position, ped.pressEventCamera, out pos))
		{
			pos.x = (pos.x / joystickBackgroundImage.rectTransform.sizeDelta.x);
			pos.y = (pos.y / joystickBackgroundImage.rectTransform.sizeDelta.y);

			float x = (joystickBackgroundImage.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
			float y = (joystickBackgroundImage.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;

			//dont want to move on vertical plane so - for middle
			inputDirection = new Vector3 (x, 0, y);
			inputDirection = (inputDirection.magnitude > 1) ? inputDirection.normalized : inputDirection;


			joystickImage.rectTransform.anchoredPosition = new Vector3 (inputDirection.x * (joystickBackgroundImage.rectTransform.sizeDelta.x / 3) //change this 3 and below to slightly change how joystick looks
				, inputDirection.z * (joystickBackgroundImage.rectTransform.sizeDelta.y / 3 ));

			Debug.Log (inputDirection);
		}

	}//End OnDrag

	public virtual void OnPointerDown(PointerEventData ped)
	{
		OnDrag (ped);

	}

	public virtual void OnPointerUp(PointerEventData ped)
	{
		inputDirection = Vector3.zero;
		joystickImage.rectTransform.anchoredPosition = Vector3.zero;
	}

	public float Horizontal()
	{
		if (inputDirection.x != 0)
			return inputDirection.x;
		else
			return Input.GetAxis ("Horizontal");
	}

	public float Vertical()
	{
		if (inputDirection.z != 0)
			return inputDirection.z;
		else
			return Input.GetAxis ("Vertical");
	}


	// Update is called once per frame
	void Update () {
		
	}
}
