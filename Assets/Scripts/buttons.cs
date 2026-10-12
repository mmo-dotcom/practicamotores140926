using UnityEngine;
using UnityEngine.SceneManagement;
public class buttons : MonoBehaviour
{

    public void Siguientenivel()
    {
        SceneManager.LoadScene(2);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Primernivel()
    {
        SceneManager.LoadScene(1);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}