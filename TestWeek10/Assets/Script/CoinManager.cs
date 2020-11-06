using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public Text textCoin;

    private ShopManager shopManager;

    public void Start()
    {
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
