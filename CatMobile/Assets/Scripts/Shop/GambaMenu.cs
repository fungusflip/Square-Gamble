using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GambaMenu : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] CashMoney cashMoney;
    private GameObject catgamba;

    void Update()
    {
        if(cashMoney.cash >= 1400)
        {
            button.interactable = true;
        }   
        else
        {
            button.interactable = false;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }
    }
}
