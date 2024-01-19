using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private Rigidbody bulletRb;
	private GameObject player;

	private void Start()
	{
		bulletRb = GetComponent<Rigidbody>();
		player = GameObject.FindWithTag("Player");
		Destroy(gameObject, 2f);
	}

	private void FixedUpdate()
	{
		bulletRb.AddRelativeForce(Vector3.forward, ForceMode.Impulse);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}
