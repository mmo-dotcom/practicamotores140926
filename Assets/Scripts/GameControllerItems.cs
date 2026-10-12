using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class GameControllerItems : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int itemCollected;
    public int totalItems;
    public TextMeshProUGUI itemCountText;
    public GameObject Panel;
    void Start()
    {
        totalItems = GameObject.FindGameObjectsWithTag("Item").Length;
        Panel.SetActive(false);
        UpdateUI();
    }
    private void UpdateUI()
    {
        itemCountText.text = "Items collected: " + itemCollected + "/" + totalItems;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CollectItem()
    {
        itemCollected++;
        Debug.Log("Item collected. Total items: " + itemCollected);
        UpdateUI();
        if (itemCollected >= totalItems)
        {
            winGame();
        }
    }
    public void winGame()
    {
        Debug.Log("All items collected. Congrats!");
        Panel.SetActive(true);
    }

}
