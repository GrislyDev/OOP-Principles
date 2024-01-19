using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSphere : MonoBehaviour
{
	private Rigidbody bulletRb;
	private GameObject player;
	private float speed = 5f;

	private void Start()
	{
		bulletRb = GetComponent<Rigidbody>();
		player = GameObject.FindWithTag("Player");
		Destroy(gameObject, 2f);
	}

	// Update is called once per frame
	void FixedUpdate()
    {
		bulletRb.AddForce((player.transform.position - transform.position).normalized * speed);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}
