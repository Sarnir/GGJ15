using UnityEngine;
using System.Collections;

public class IgnoreFirstCollision : MonoBehaviour
{
	private int ignoreLayer = 8;
	private int defaultLayer = 0;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (gameObject.layer == ignoreLayer && collision.gameObject.tag == "cat")
		{
			gameObject.layer = defaultLayer;
		}
	}
}