using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSphere : Projectile
{
	protected override void ProjectileMovement()
	{
		bulletRb.AddForce((player.transform.position - transform.position).normalized * 5f);
	}
}
