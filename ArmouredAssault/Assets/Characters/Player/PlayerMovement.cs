using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler

{

	private Image joystickBackgroundImage;
	private Image joystickImage;

	public Vector3 inputDirection{ set; get; }



	// Use this for initialization
	void Start () {

		joystickBackgroundImage = GetComponent<Image> ();
		//Get image component from first child
		joystickImage = transform.GetChild (0).GetComponent<Image> ();
		inputDirection = Vector3.zero;

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


			joystickImage.rectTransform.anchoredPosition = new Vector3 (inputDirection.x * (joystickBackgroundImage.rectTransform.sizeDelta.x / 3)
				, inputDirection.z * (joystickBackgroundImage.rectTransform.sizeDelta.y / 3 ));

			Debug.Log (inputDirection);
		}

	}//End OnDrag


	public virtual void  OnPointerDown(PointerEventData ped)
	{
		Debug.Log ("OnPointerDown");
		OnDrag (ped); //Fix for if you just do a single press in the joystickBackgroundImage
	}//End OnPointerDown


	public virtual void  OnPointerUp(PointerEventData ped)
	{
		Debug.Log ("OnPointerUp");

		//Resets joystick and recenters image after letting go
		inputDirection = Vector3.zero;
		joystickImage.rectTransform.anchoredPosition = Vector3.zero;

	}//End OnPointerUp





	// Update is called once per frame
	void Update () {
		
	}
}
