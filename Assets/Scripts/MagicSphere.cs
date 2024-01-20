sealed class MagicSphere : Projectile
{
	private float forceSpeed = 7f;

	protected override void ProjectileMovement()
	{
		bulletRb.AddForce((player.transform.position - transform.position).normalized * forceSpeed);
	}
}
