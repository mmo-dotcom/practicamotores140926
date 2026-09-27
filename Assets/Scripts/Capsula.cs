using UnityEngine;

public class Capsula : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 startPosition;
    public CharacterController characterController;
    float gravity = -9.81f;
    void Start()
    {
        Debug.Log("Capsula script has started");
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MovetoStartPostion();
        }
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
            characterController.Move(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
            characterController.Move(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            characterController.Move(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
            characterController.Move(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if(characterController.isGrounded == false)
        {
            characterController.Move(new Vector3(0, gravity, 0)* speed * Time.deltaTime);
        }
    }
    private void MovetoStartPostion()
    {
        //Debug.Log("Space key pressed. Move to start position.");
        //transform.position = startPosition;
    }
}
