using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
	protected Rigidbody bulletRb;
	protected GameObject player;
	private float destroyTime = 2f;

	private void Start()
	{
		bulletRb = GetComponent<Rigidbody>();
		player = GameObject.FindWithTag("Player");
		Destroy(gameObject, destroyTime);
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

	protected abstract void ProjectileMovement();
}
