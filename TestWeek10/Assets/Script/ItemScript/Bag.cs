using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{
    public Text textBag;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextBag();
    }

    private void UpdateTextBag()
    {
        textBag.text = "Price : " + shopManager.bagPrice + " Amount Left : " + shopManager.bagAmount;
    }
}
