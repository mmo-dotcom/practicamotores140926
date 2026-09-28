using UnityEngine;

public class physicPlayer : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 forceDirection;
    void Start()
    {
        rb.AddForce(forceDirection);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 300, 0));
        }
    }
}
