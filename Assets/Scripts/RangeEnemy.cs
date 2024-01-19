using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RangeEnemy : Enemy
{
	[SerializeField] private GameObject bullet;

	private void Awake()
	{
		AttackDelay = 2f;
		RangeOfAttack = 6f;
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
		Instantiate(bullet, transform.position, Quaternion.LookRotation(player.transform.position - transform.position));
	}
}
