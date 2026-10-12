using UnityEngine;

public class itemTrigger : MonoBehaviour
{
    public GameControllerItems gamecontroller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gamecontroller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerItems>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger zone of: " + gameObject.name);

            Destroy(gameObject);

            gamecontroller.CollectItem();
        }
    }
}
