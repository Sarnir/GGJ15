using UnityEngine;
using System.Collections;

public class ScissorsHandler : MonoBehaviour
{
    public DistanceJoint2D stringToCut;

	void Start ()
	{
	}

	void Update ()
	{
	}

	void OnMouseDown()
	{
        Destroy(stringToCut);
	}
}
