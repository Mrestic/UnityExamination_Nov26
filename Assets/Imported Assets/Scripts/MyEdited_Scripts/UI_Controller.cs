using UnityEngine;
using TMPro;

public class UI_Controller : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    public int coinCount = 0;
    public GameObject addGameObject;
    public GameObject removeGameObject;


    private void Update() 
    {
        if (coinCount >= 2)
        {
            addGameObject.SetActive(true);
            removeGameObject.SetActive(false);
        }
    }
    void Start()
    {
        coinText.text = "Coins: " + coinCount;
    }
    
    public void AddCoin()
    {
        coinCount++;
        coinText.text = "Coins: " + coinCount;
    }
}
