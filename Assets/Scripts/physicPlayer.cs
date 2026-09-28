using UnityEngine;

public class physicPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public float jumpForce = 300f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-speed, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(speed, 0, 0));
        }
    }
}
