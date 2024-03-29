using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
	private float attackDelay;
	private float damage;
	private float rangeOfAttack;
	private int health;
	private float time;
	

	[SerializeField] protected GameObject player;
	protected Rigidbody enemyRb;

	protected float AttackDelay
	{
		set 
		{
			if (value <= 0)
			{
				Debug.LogError("Attack delay value must be greater than 0");
			}
			else
			{
				attackDelay = value;
			}
		}
		get { return attackDelay; }
	}
	protected float Damage
	{
		set 
		{
			if (value <= 0)
			{
				Debug.LogError("Damage value must be greater than 0");
			}
			else
			{
				damage = value;
			}
		}
		get { return damage; }
	}
	protected float RangeOfAttack
	{
		set 
		{
			if (value <= 0)
			{
				Debug.LogError("Range of attack value must be greater than 0");
			}
			else
			{
				rangeOfAttack = value;
			}
		}
	}
	protected int Health
	{
		set
		{
			if (value < 0)
			{
				Debug.LogError("Health value can't be less 0");
			}
			else
			{
				health = value;
			}
		}
		get { return health; }
	}

	private void Start()
	{
		GetComponent<SphereCollider>().radius = rangeOfAttack;
	}

	private void FixedUpdate()
	{
		if (player != null && AttackTimer())
		{
			Attack();
		}
	}

	protected abstract void Attack();

	protected bool AttackTimer()
	{
		if (time >= AttackDelay)
		{
			time = 0;
			return true;
		}
		else
		{
			time += 0.02f;
			return false;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			player = other.gameObject;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			player = null;
		}
	}
}
