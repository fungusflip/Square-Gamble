using UnityEngine;	
using UnityEngine.UI;
    
    public class IllegalCatsButton : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] private CashMoney cashMoney;
	[SerializeField] private HouseManager houseManager;

	private void Start()
	{
		cashMoney = GetComponent<CashMoney>();
	}
	private void Update() 
	{
		int cash = cashMoney.cash;
		if (HouseManager.Instance.illegalLevel == 0 && cash >= 400)
		{
            button.interactable = true;
            //Todo fix level acces and different effects for different levels
        }

	}
}