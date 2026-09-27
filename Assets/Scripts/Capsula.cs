using UnityEngine;

public class Capsula : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 startPosition;
    public CharacterController characterController;
    float gravity = -9.81f;
    public Vector3 moveDirection;


    void Start()
    {
        Debug.Log("Capsula script has started");
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        characterController.Move(moveDirection * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //MovetoStartPostion();
        }
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
            moveDirection =(new Vector3(0, 0, 1));
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
            moveDirection = (new Vector3(0, 0, -1));
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            moveDirection = (new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
            moveDirection = (new Vector3(1, 0, 0));
        }
        if(characterController.isGrounded == false)
        {
            characterController.Move(new Vector3(0, gravity, 0));
        }
    }
    private void MovetoStartPostion()
    {
        //Debug.Log("Space key pressed. Move to start position.");
        //transform.position = startPosition;
    }
}
