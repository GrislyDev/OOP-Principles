using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	protected Rigidbody bulletRb;
	protected GameObject player;
	private void Start()
	{
		bulletRb = GetComponent<Rigidbody>();
		player = GameObject.FindWithTag("Player");
		Destroy(gameObject, 2f);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}

	private void FixedUpdate()
	{
		ProjectileMovement();
	}

	protected virtual void ProjectileMovement() { }
}
