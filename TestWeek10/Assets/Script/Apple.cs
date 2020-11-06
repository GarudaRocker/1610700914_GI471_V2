using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apple : MonoBehaviour
{
    public Text textApple;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextApple();
    }

    private void UpdateTextApple()
    {
        textApple.text = "Price : " + shopManager.applePrice + " Amount Left : " + shopManager.appleAmount;
    }
}
