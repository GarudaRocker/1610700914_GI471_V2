using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public Text textCoin;
    public Button addCoinButton;

    private ShopManager shopManager;

    public void Start()
    {
        addCoinButton = GetComponent<Button>();

        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextCoin();       
    }

    private void UpdateTextCoin()
    {
        textCoin.text = "Coin : " + shopManager.coin;
    }


}
