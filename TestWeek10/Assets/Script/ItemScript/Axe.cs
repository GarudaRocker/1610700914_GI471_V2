using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Axe : MonoBehaviour
{
    public Text textAxe;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextAxe();
    }

    private void UpdateTextAxe()
    {
        textAxe.text = "Price : " + shopManager.axePrice + " Amount Left : " + shopManager.axeAmount;
    }
}
