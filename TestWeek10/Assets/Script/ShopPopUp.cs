using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPopUp : MonoBehaviour
{
    public enum PopUpState
    {
        Cancel,
        NotEnoughCoin,
        OutOfStock,
        FinishBuy,
    }

    public Text textPopUp;
    public Image shopPopUp;
    public Image cancelButton;

    private PopUpState popUpState;

    private ShopManager shopManager;

    public delegate void DelegateHandlePopUpState(PopUpState popUpState);
    public event DelegateHandlePopUpState OnPopUpStateChange;

    private void Start()
    {
        shopPopUp.gameObject.SetActive(false);
        cancelButton.gameObject.SetActive(false);

        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateShopState();
    }

    private void UpdateShopState()
    {
        switch (popUpState)
        {
            case PopUpState.Cancel:
                {
                    break;
                }
            case PopUpState.NotEnoughCoin:
                {
                    UpdateNotEnoughCoin();
                    break;
                }
            case PopUpState.OutOfStock:
                {
                    UpdateNotOutOfStock();
                    break;
                }
            case PopUpState.FinishBuy:
                {
                    UpdateFinishBuy();
                    break;
                }
        }
    }

    private void UpdateNotEnoughCoin()
    {
        if (shopManager.coin < shopManager.applePrice)
        {
            textPopUp.text = "You Have Not Enough Coin !!!";
            ChangeState(PopUpState.NotEnoughCoin);
        }
               
    }

    private void UpdateNotOutOfStock()
    {
        if (shopManager.appleAmount <= 0)
        {
            textPopUp.text = "Item Is Out of Stock !!!";
            ChangeState(PopUpState.OutOfStock);
        }
    }

    private void UpdateFinishBuy()
    {
            textPopUp.text = "Buying Successful";
            ChangeState(PopUpState.FinishBuy);        
    }




    private void ChangeState(PopUpState toChange)
    {
        if (popUpState != toChange)
        {
            if (OnPopUpStateChange != null)
                OnPopUpStateChange(toChange);

            popUpState = toChange;

            switch (popUpState)
            {
                case PopUpState.Cancel:
                    {
                        shopPopUp.gameObject.SetActive(false);
                        cancelButton.gameObject.SetActive(false);
                        break;
                    }
                case PopUpState.NotEnoughCoin:
                    {
                        shopPopUp.gameObject.SetActive(true);
                        cancelButton.gameObject.SetActive(true);
                        break;
                    }
                case PopUpState.OutOfStock:
                    {
                        shopPopUp.gameObject.SetActive(true);
                        cancelButton.gameObject.SetActive(true);
                        break;
                    }
                case PopUpState.FinishBuy:
                    {
                        shopPopUp.gameObject.SetActive(true);
                        cancelButton.gameObject.SetActive(true);
                        break;
                    }
            }
        }

    }







    }
