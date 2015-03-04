using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(BoxCollider2D))]
public class Windzone : MonoBehaviour
{
	[SerializeField]
	Vector2 windForce;

	// Internal list that tracks objects that enter this object's "zone"
	List<Collider2D> objects = new List<Collider2D> ();

	void FixedUpdate ()
	{
		// For every object being tracked
		for (int i = 0; i < objects.Count; i++)
		{
			if (objects [i] == null)
			{
				objects.RemoveAt (i);
			}
			else
			{
				// Get the rigid body for the object.
				Rigidbody2D body = objects[i].attachedRigidbody;

				// Apply the force
				if (body)
					body.AddForce (windForce);
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.attachedRigidbody)
		{
			objects.Add (other);
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		objects.Remove (other);
	}
}