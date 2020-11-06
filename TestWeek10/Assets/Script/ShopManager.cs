using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public enum ItemID
    {
        Idle,
        Apple,
        Sword,
        Gun,       
    }

    public float coin = 10000;
    public float addCoinAmount = 1000;

    public int applePrice = 500;
    public int appleAmount = 5;

    private ItemID itemId;

    public delegate void DelegateHandleItemID(ItemID itemId);
    public event DelegateHandleItemID OnItemIDBuy;

    public void Update()
    {
        UpdateItemID();
        UpdateCoin();
    }

    private void UpdateCoin()
    {
        if (coin >= 0)
        {
            ChangeItemID(ItemID.Idle);
        }
       
    }

    private void UpdateItemID()
    {
        switch (itemId)
        {
            case ItemID.Idle:
                {
                    break;
                }
            case ItemID.Apple:
                {
                    UpdateApple();
                    break;
                }
            case ItemID.Sword:
                {
                    //UpdateSword();
                    break;
                }
        }
    }

    private void UpdateApple()
    {
        appleAmount -= 1;
        coin -= applePrice;
        UpdateCoin();
    }

    /// 
    /// /////////////////////////////////////////////////////////////////////////
    /// 

    public void AddCoin()
    {
        if (coin < 99999)
        {
            coin += addCoinAmount;
            UpdateCoin();
        }
        else
        {
            return;
        }
    }

    private void AppleBuy()
    {
        if (coin >= applePrice)
        {
            ChangeItemID(ItemID.Apple);          
        }
    }







    private void ChangeItemID(ItemID toChange)
    {
        if (itemId != toChange)
        {
            if (OnItemIDBuy != null)
                OnItemIDBuy(toChange);

            itemId = toChange;

            switch (itemId)
            {
                case ItemID.Idle:
                    {
                        break;
                    }
                case ItemID.Apple:
                    {
                        
                        break;
                    }
                case ItemID.Sword:
                    {
                        
                        break;
                    }
                case ItemID.Gun:
                    {
                        
                        break;
                    }
            }
        }

    }

}
