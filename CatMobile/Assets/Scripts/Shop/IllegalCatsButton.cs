using UnityEngine;	
using UnityEngine.UI;
using TMPro;


public class IllegalCatsButton : MonoBehaviour
{
    [SerializeField] Button houseButton;
    [SerializeField] private CashMoney cashMoney;
	[SerializeField] private HouseManager houseManager;
	[SerializeField] private TextMeshProUGUI tm;
	
	private void Update() 
	{
		int cost = cashMoney.cost;
		int cash = cashMoney.cash;
		if (cash >= cost)
		{
            houseButton.interactable = true;
            
        }
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }
		if (HouseManager.Instance.illegalLevel >= 2)
		{ houseButton.interactable = false;
		tm.text = "0";}

		tm.text = "Cost:" + cost;
	}
}