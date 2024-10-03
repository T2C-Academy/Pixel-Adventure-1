using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float InputX = Input.GetAxis("Horizontal");

        rigidbody2D.velocity = new Vector3(InputX * moveSpeed, rigidbody2D.velocity.y, 0);
    }
}