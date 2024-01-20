using UnityEngine;

public class RangeEnemy : Enemy
{
	[SerializeField] private GameObject bullet;
	private float attackDelay = 2f;
	private float rangeOfAttack = 6f;

	private void Awake()
	{
		AttackDelay = attackDelay;
		RangeOfAttack = rangeOfAttack;
	}

	protected override void Attack()
	{
		Instantiate(bullet, transform.position, Quaternion.LookRotation(player.transform.position - transform.position));
	}
}
