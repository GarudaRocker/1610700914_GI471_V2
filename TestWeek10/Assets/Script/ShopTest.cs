using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTest : MonoBehaviour
{
    [System.Serializable]
    public struct Item
    {
        public string itemName;
        public int itemPrice;
        public int itemAmount;
    }

    public List<Item> itemDatabase = new List<Item>();
    //public List<string> itemNameList = new List<string>();
    //public List<string> itemPriceList = new List<string>();
    //public List<int> itemAmountList = new List<int>();

    private void Start()
    {
        Item item01;
        item01.itemName = "Apple";
        item01.itemPrice = 500;
        item01.itemAmount = 5;

        itemDatabase.Add(item01);
    }



}
