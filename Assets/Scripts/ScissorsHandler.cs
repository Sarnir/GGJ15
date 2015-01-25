using UnityEngine;
using System.Collections;

public class ScissorsHandler : MonoBehaviour
{
	public GameObject stringOwner;

	void Start ()
	{
	}

	void Update ()
	{
	}

	void OnMouseDown()
	{
		Destroy(stringOwner.GetComponent<DistanceJoint2D>());
	}
}
