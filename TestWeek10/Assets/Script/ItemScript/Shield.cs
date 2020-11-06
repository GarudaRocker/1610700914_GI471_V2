using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    public Text textShield;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextShield();
    }

    private void UpdateTextShield()
    {
        textShield.text = "Price : " + shopManager.shieldPrice + " Amount Left : " + shopManager.shieldAmount;
    }
}
