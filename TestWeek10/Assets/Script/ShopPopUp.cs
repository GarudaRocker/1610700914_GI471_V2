using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPopUp : MonoBehaviour
{
    public enum PopUpState
    {
        Idle,
        Cancel,
        PopUp,
    }

    public Text textPopUp;
    public Image shopPopUp;
    public Image cancelButton;

    private bool coinZero = false;
    private bool itemZero = false;
    private PopUpState popUpState;

    private ShopManager shopManager;

    public delegate void DelegateHandlePopUpState(PopUpState popUpState);
    public event DelegateHandlePopUpState OnPopUpStateChange;

    private void Start()
    {
        //textPopUp.text = "!!! Welcome to Shop !!!";
        ChangeState(PopUpState.Cancel);

        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateShopPopUp();
        UpdateTextPopUp();       
    }

    private void UpdateTextPopUp()
    {
        
        UpdatePopUp();
    }

    private void UpdateShopPopUp()
    {
        switch (popUpState)
        {
            case PopUpState.Idle:
                {
                    break;
                }
            case PopUpState.Cancel:
                {
                    UpdateCancel();
                    break;
                }
            case PopUpState.PopUp:
                {
                    UpdatePopUp();
                    UpdateAmountCheck();                   
                    break;
                }
        }
    }



    private void UpdateCancel()
    {
        ChangeState(PopUpState.Idle);
    }

    private void UpdatePopUp()
    {
        ChangeState(PopUpState.Idle);
    }

    private void UpdateCoinCheck()
    {


        if (shopManager.coin < shopManager.applePrice)
        {           
            NotEnoughCoin();
        }
        else
        {           
            BuyingSuccessfully();
        }
    }

    

    private void UpdateAmountCheck()
    {
        if(itemZero == true)
        {
            ItemIsOut();
        }

        else
        {
            
            UpdateCoinCheck();
            AmountZeroCheck();
        }
    }

/// <summary>
/// ////////////////////////////////////////////////////////////////
/// </summary>


    private void BuyingSuccessfully()
    {
        textPopUp.text = "Buying Successfully";
        Debug.Log("Buying Successfully");
    }

    private void NotEnoughCoin()
    {
        textPopUp.text = "You Have Not Enough Coin !!!";
        Debug.Log("You Have Not Enough Coin");
    }

    private void ItemIsOut()
    {
        textPopUp.text = "Item Is Out of Stock !!!";
        Debug.Log("Item Is Out of Stock !!!");
    }

    private void AmountZeroCheck()
    {
        if (shopManager.appleAmount == 0)
        {
            itemZero = true;
        }
        else
        {
            itemZero = false;
        }
    }

    private void CoinZeroCheck()
    {
        if (shopManager.coin == 0)
        {
            coinZero = true;
            Debug.Log("coin is 0");
        }
        else
        {
            coinZero = false;
            Debug.Log("coin is not 0");
        }
    }


    /// <summary>
    /// /////////////////////////////////////////////////////////////////
    /// </summary>


    public void Cancel()
    {
        ChangeState(PopUpState.Cancel);
    }

    public void PopUp()
    {
        ChangeState(PopUpState.PopUp);
    }


    /// <summary>
    /// ////////////////////////////////////////////////////////
    /// </summary>

    private void ChangeState(PopUpState toChange)
    {
        if (popUpState != toChange)
        {
            if (OnPopUpStateChange != null)
                OnPopUpStateChange(toChange);

            popUpState = toChange;

            switch (popUpState)
            {
                case PopUpState.Idle:
                    {
                        break;
                    }
                case PopUpState.Cancel:
                    {                        
                        shopPopUp.gameObject.SetActive(false);
                        cancelButton.gameObject.SetActive(false);
                        break;
                    }
                case PopUpState.PopUp:
                    {                       
                        shopPopUp.gameObject.SetActive(true);
                        cancelButton.gameObject.SetActive(true);
                        break;
                    }

            }
        }
    }
}
