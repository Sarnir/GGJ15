using UnityEngine;
using System.Collections;

public class ScissorsHandler : MonoBehaviour
{
    public DistanceJoint2D stringToCut;

	void OnMouseDown()
	{
        Destroy(stringToCut);
	}
}