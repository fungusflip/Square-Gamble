using UnityEngine;	
using UnityEngine.UI;
using TMPro;


public class IllegalCatsButton : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] private CashMoney cashMoney;
	[SerializeField] private HouseManager houseManager;
	[SerializeField] private TextMeshProUGUI tm;
	
	private void Update() 
	{
		int cost = cashMoney.cost;
		int cash = cashMoney.cash;
		if (cash >= cost)
		{
            button.interactable = true;
            
        }
		if (HouseManager.Instance.illegalLevel >= 2)
		{ button.interactable = false;
		tm.text = "0";}

		tm.text = "Cost:" + cost;
	}
}