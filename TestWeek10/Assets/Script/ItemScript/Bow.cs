using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bow : MonoBehaviour
{
    public Text textBow;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextBow();
    }

    private void UpdateTextBow()
    {
        textBow.text = "Price : " + shopManager.bowPrice + " Amount Left : " + shopManager.bowAmount;
    }
}
