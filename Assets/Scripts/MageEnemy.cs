using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageEnemy : Enemy
{
	[SerializeField] private GameObject magicSphere;

	// Start is called before the first frame update
	void Awake()
    {
        RangeOfAttack = 4f;
        AttackDelay = 4f;
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
		Instantiate(magicSphere, transform.position, Quaternion.identity);
	}
}
