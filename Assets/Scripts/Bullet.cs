using UnityEngine;

sealed class Bullet : Projectile
{
	protected override void ProjectileMovement()
	{
		bulletRb.AddRelativeForce(Vector3.forward, ForceMode.Impulse);
	}
}
