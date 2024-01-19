using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    // Start is called before the first frame update
    void Awake()
    {
        RangeOfAttack = 1.5f;
        AttackDelay = 1.1f;
		enemyRb = GetComponent<Rigidbody>();
    }

	private void FixedUpdate()
	{
		if (player != null && AttackTimer())
		{
			Attack();
		}
	}

	protected override void Attack()
	{
		enemyRb.AddForce((player.transform.position - transform.position).normalized * 10f, ForceMode.Impulse);
	}
}
