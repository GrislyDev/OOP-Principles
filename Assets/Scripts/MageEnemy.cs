using UnityEngine;

sealed class MageEnemy : Enemy
{
	[SerializeField] private GameObject magicSphere;
	private float rangeOfAttack = 4f;
	private float attackDelay = 4f;

	void Awake()
    {
        RangeOfAttack = rangeOfAttack;
        AttackDelay = attackDelay;
    }

	protected override void Attack()
	{
		Instantiate(magicSphere, transform.position, Quaternion.identity);
	}
}
