using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cloak : MonoBehaviour
{
    public Text textCloak;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextCloak();
    }

    private void UpdateTextCloak()
    {
        textCloak.text = "Price : " + shopManager.cloakPrice + " Amount Left : " + shopManager.cloakAmount;
    }
}
