using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{
    public Text textSword;

    private ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateTextSword();
    }

    private void UpdateTextSword()
    {
        textSword.text = "Price : " + shopManager.swordPrice + " Amount Left : " + shopManager.swordAmount;
    }
}
