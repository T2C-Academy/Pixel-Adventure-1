using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float speedJump = 5;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, speedJump);
        }
    }
}