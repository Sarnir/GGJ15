using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Touchable : MonoBehaviour {

	bool isTouched;
	Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
		isTouched = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		isTouched = Input.GetMouseButtonDown(0);

		//rigidbody
	}
}
