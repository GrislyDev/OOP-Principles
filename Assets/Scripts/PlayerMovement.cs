using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float maxSpeed = 10f;
    private float horizontalInput = 0;
    private float verticalInput = 0;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

	private void FixedUpdate()
	{
        MovePlayer();
	}

	void Update()
    {
        GetInput();
    }

    void MovePlayer()
    {
		playerRb.AddForce(Vector3.forward * verticalInput * speed);
        playerRb.AddForce(Vector3.right * horizontalInput * speed);
        if (playerRb.velocity.magnitude > maxSpeed)
        {
            playerRb.velocity = playerRb.velocity.normalized * maxSpeed;
        }
	}

    void GetInput()
    {
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");
	}
}
