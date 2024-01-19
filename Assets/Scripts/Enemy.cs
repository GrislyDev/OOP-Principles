using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	private float attackSpeed;
	private float attackDelay;
	private float damage;
	private float rangeOfAttack;
	private int health;

	[SerializeField] protected GameObject player;
	[SerializeField] protected GameObject AttackRangeCollider;
	[SerializeField]
	protected float AttackSpeed
	{
		set
		{
			if (value <= 1)
			{
				Debug.LogError("Attack speed value must be greater than 1");
			}
			else
			{
				attackSpeed = value;
			}
		}
	}
	[SerializeField]
	protected float AttackDelay
	{
		set 
		{
			if (value <= 1)
			{
				Debug.LogError("Attack delay value must be greater than 1");
			}
			else
			{
				attackDelay = value;
			}
		}
	}
	[SerializeField]
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
	[SerializeField]
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
	[SerializeField]
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

	public void CheckAttackZone()
	{
		// Checks the presence of a player in the attack zone
	}

	public virtual void Attack()
	{
		// Attacks a player
	}
}
