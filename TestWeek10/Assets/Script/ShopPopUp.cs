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

    private PopUpState popUpState;

    private ShopManager shopManager;

    public delegate void DelegateHandlePopUpState(PopUpState popUpState);
    public event DelegateHandlePopUpState OnPopUpStateChange;

    private void Start()
    {
        //textPopUp.text = "!!! Welcome to Shop !!!";
        ChangeState(PopUpState.PopUp);

        shopManager = FindObjectOfType<ShopManager>();
    }

    private void Update()
    {
        UpdateShopState();
        UpdateTextPopUp();
    }

    private void UpdateShopState()
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
                    UpdateTextPopUp();
                    break;
                }
        }
    }

    private void UpdateTextPopUp()
    {


        if (shopManager.coin < shopManager.applePrice)
        {
            NotEnoughCoin();
            
        }

        else if (shopManager.appleAmount == 0)
        {
            OutOfStock();
            
        }

        else if (shopManager.coin >= shopManager.applePrice)
        {
            FinishBuy();
            
        }


        ChangeState(PopUpState.Idle);








        //UpdateNotEnoughCoin();
        //UpdateOutOfStock();
        //UpdateFinishBuy();
        UpdateCancel();

        // ยังแก้ไม่ได้
    }

    private void UpdateCancel()
    {
        ChangeState(PopUpState.Idle);
    }

    private void UpdatePopUp()
    {
        ChangeState(PopUpState.PopUp);
    }


    //private void UpdateNotEnoughCoin()
    //{
    //    if (shopManager.coin < shopManager.applePrice)
    //    {
    //        NotEnoughCoin();
    //        ChangeState(PopUpState.Idle);
    //    }      
    //}

    //private void UpdateOutOfStock()
    //{
    //    if (shopManager.appleAmount == 0)
    //    {
    //        OutOfStock();
    //        ChangeState(PopUpState.Idle);
    //    }
    //}

    //private void UpdateFinishBuy()
    //{
    //    if (shopManager.coin >= shopManager.applePrice)
    //    {
    //        FinishBuy();
    //        ChangeState(PopUpState.Idle);
    //    }        
    //}


///
/// ////////////////////////////////////////////////////////////////////////////
///




    public void Cancel()
    {
        ChangeState(PopUpState.Cancel);
    }

    public void PopUp()
    {
        ChangeState(PopUpState.PopUp);
    }

    public void NotEnoughCoin()
    {
        textPopUp.text = "You Have Not Enough Coin !!!";
        UpdateCancel();
    }

    public void OutOfStock()
    {
        textPopUp.text = "Item Is Out of Stock !!!";
        UpdateCancel();
    }

    public void FinishBuy()
    {
        textPopUp.text = "Buying Successfully";
        UpdateCancel();
    }









    ///
    /// /////////////////////////////////////////////////////////////////////
    ///








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
