using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helmet : MonoBehaviour
{
    public Text textHelmet;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextHelmet();
    }

    private void UpdateTextHelmet()
    {
        textHelmet.text = "Price : " + shopManager.helmetPrice + " Amount Left : " + shopManager.helmetAmount;
    }
}
