using UnityEngine;

public class MeleeEnemy : Enemy
{
    private float forceSpeed = 10f;

    void Awake()
    {
        RangeOfAttack = 1.5f;
        AttackDelay = 1.1f;
		enemyRb = GetComponent<Rigidbody>();
    }

	protected override void Attack()
	{
		enemyRb.AddForce((player.transform.position - transform.position).normalized * forceSpeed, ForceMode.Impulse);
	}
}
