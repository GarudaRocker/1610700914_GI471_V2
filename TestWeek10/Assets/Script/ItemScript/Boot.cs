using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boot : MonoBehaviour
{
    public Text textBoot;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextBoot();
    }

    private void UpdateTextBoot()
    {
        textBoot.text = "Price : " + shopManager.bootPrice + " Amount Left : " + shopManager.bootAmount;
    }
}
