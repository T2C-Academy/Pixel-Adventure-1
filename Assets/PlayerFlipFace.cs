using UnityEngine;

public class PlayerFlipFace : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        float InputX = Input.GetAxisRaw("Horizontal");
        if (InputX != 0)
        {
            transform.localScale = new Vector3(InputX, 1, 1);
        }
    }
}