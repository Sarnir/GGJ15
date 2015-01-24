using UnityEngine;
using System.Collections;

public class balloonHandler : MonoBehaviour
{
	void Start () {
	
	}

	void Update ()
	{
	}

	void OnMouseDown()
	{
		Destroy (gameObject);
	}
}
