using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Projectile
{
	protected override void ProjectileMovement()
	{
		bulletRb.AddRelativeForce(Vector3.forward, ForceMode.Impulse);
	}
	
}
