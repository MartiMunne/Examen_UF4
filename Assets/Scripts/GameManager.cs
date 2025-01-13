using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    private int coins;
    public TextMeshProUGUI coinText;
    public void Awake()
    {
        if(GameManager.gameManager != null && GameManager.gameManager != this)
        {
            Destroy(gameObject);
        }
        else
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void CoinCollected()
    {
        coins++;
        coinText.text = "Coins: " + coins;
    }
}
