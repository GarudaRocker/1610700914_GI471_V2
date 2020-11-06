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
        Axe,
        Bow,
        Bag,
        Shield,
        Helmet,
        Cloak,
        Belt,
        Boot,
    }

    public float coin = 10000;
    public float addCoinAmount = 1000;

    public int applePrice = 500;
    public int appleAmount = 5;

    public int swordPrice = 3000;
    public int swordAmount = 5;

    public int axePrice = 4000;
    public int axeAmount = 5;

    public int bowPrice = 2000;
    public int bowAmount = 5;

    public int bagPrice = 7500;
    public int bagAmount = 5;

    public int shieldPrice = 3000;
    public int shieldAmount = 5;

    public int helmetPrice = 4000;
    public int helmetAmount = 5;

    public int cloakPrice = 6000;
    public int cloakAmount = 5;

    public int beltPrice = 3000;
    public int beltAmount = 5;

    public int bootPrice = 2000;
    public int bootAmount = 5;

    private ItemID itemId;

    public delegate void DelegateHandleItemID(ItemID itemId);
    public event DelegateHandleItemID OnItemIDBuy;

    private void Update()
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
                    UpdateSword();
                    break;
                }
            case ItemID.Axe:
                {
                    UpdateAxe();
                    break;
                }
            case ItemID.Bow:
                {
                    UpdateBow();
                    break;
                }
            case ItemID.Bag:
                {
                    UpdateBag();
                    break;
                }
            case ItemID.Shield:
                {
                    UpdateShield();
                    break;
                }
            case ItemID.Helmet:
                {
                    UpdateHelmet();
                    break;
                }
            case ItemID.Cloak:
                {
                    UpdateCloak();
                    break;
                }
            case ItemID.Belt:
                {
                    UpdateBelt();
                    break;
                }
            case ItemID.Boot:
                {
                    UpdateBoot();
                    break;
                }
        }
    }

    private void UpdateApple()
    {
        if (appleAmount > 0)
        {
            appleAmount--;
            coin -= applePrice;
            UpdateCoin();
        }        
    }

    private void UpdateSword()
    {
        if (swordAmount > 0)
        {
            swordAmount--;
            coin -= swordPrice;
            UpdateCoin();
        }
    }

    private void UpdateAxe()
    {
        if (axeAmount > 0)
        {
            axeAmount--;
            coin -= axePrice;
            UpdateCoin();
        }
    }

    private void UpdateBow()
    {
        if (bowAmount > 0)
        {
            bowAmount--;
            coin -= bowPrice;
            UpdateCoin();
        }
    }

    private void UpdateBag()
    {
        if (bagAmount > 0)
        {
            bagAmount--;
            coin -= bagPrice;
            UpdateCoin();
        }
    }

    private void UpdateShield()
    {
        if (shieldAmount > 0)
        {
            shieldAmount--;
            coin -= shieldPrice;
            UpdateCoin();
        }
    }

    private void UpdateHelmet()
    {
        if (helmetAmount > 0)
        {
            helmetAmount--;
            coin -= helmetPrice;
            UpdateCoin();
        }
    }

    private void UpdateCloak()
    {
        if (cloakAmount > 0)
        {
            cloakAmount--;
            coin -= cloakPrice;
            UpdateCoin();
        }
    }

    private void UpdateBelt()
    {
        if (beltAmount > 0)
        {
            beltAmount--;
            coin -= beltPrice;
            UpdateCoin();
        }
    }

    private void UpdateBoot()
    {
        if (bootAmount > 0)
        {
            bootAmount--;
            coin -= bootPrice;
            UpdateCoin();
        }
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
    }

    public void AppleBuy()
    {
        if (coin >= applePrice)
        {
            ChangeItemID(ItemID.Apple);          
        }
    }

    public void SwordBuy()
    {
        if (coin >= swordPrice)
        {
            ChangeItemID(ItemID.Sword);
        }
    }

    public void AxeBuy()
    {
        if (coin >= axePrice)
        {
            ChangeItemID(ItemID.Axe);
        }
    }

    public void BowBuy()
    {
        if (coin >= bowPrice)
        {
            ChangeItemID(ItemID.Bow);
        }
    }

    public void BagBuy()
    {
        if (coin >= bagPrice)
        {
            ChangeItemID(ItemID.Bag);
        }
    }

    public void ShieldBuy()
    {
        if (coin >= shieldPrice)
        {
            ChangeItemID(ItemID.Shield);
        }
    }

    public void HelmetBuy()
    {
        if (coin >= helmetPrice)
        {
            ChangeItemID(ItemID.Helmet);
        }
    }

    public void CloakBuy()
    {
        if (coin >= cloakPrice)
        {
            ChangeItemID(ItemID.Cloak);
        }
    }

    public void BeltBuy()
    {
        if (coin >= beltPrice)
        {
            ChangeItemID(ItemID.Belt);
        }
    }

    public void BootBuy()
    {
        if (coin >= bootPrice)
        {
            ChangeItemID(ItemID.Boot);
        }
    }



    ///
    /// //////////////////////////////////////////////////////////////////////////////
    ///




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
                case ItemID.Axe:
                    {                        
                        break;
                    }
                case ItemID.Bow:
                    {
                        break;
                    }
                case ItemID.Bag:
                    {
                        break;
                    }
                case ItemID.Shield:
                    {
                        break;
                    }
                case ItemID.Helmet:
                    {
                        break;
                    }
                case ItemID.Cloak:
                    {
                        break;
                    }
                case ItemID.Belt:
                    {
                        break;
                    }
                case ItemID.Boot:
                    {
                        break;
                    }
            }
        }

    }

}
