using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Belt : MonoBehaviour
{
    public Text textBelt;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextBelt();
    }

    private void UpdateTextBelt()
    {
        textBelt.text = "Price : " + shopManager.beltPrice + " Amount Left : " + shopManager.beltAmount;
    }
}
