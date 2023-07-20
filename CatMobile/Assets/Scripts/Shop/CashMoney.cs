using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class CashMoney : MonoBehaviour, IDataPersistence
{
	[SerializeField] TextMeshProUGUI textMeshPro;
	[SerializeField] GameObject houseObject;
	
	private HouseManager shop;

	int goldIncome = 1;
	int goldIncrease = 0;
	public int cash;

	public int GoldIncome{
		
		get { return goldIncome; }
		set { goldIncome = value;}
	}

    void Start()
    {
	    StartCoroutine(GoldIncrease());
	    textMeshPro.SetText("Filips Cash " + cash);
	    
    }

	public void MoneyLaundering()
    {
		HouseManager.Instance.illegalLevel++;
	    if(houseObject.activeSelf)
	    {	
			HouseManager.Instance.illegalHouse = true;
			int level = HouseManager.Instance.illegalLevel;
			int cats = HouseManager.Instance.illegalCats;
			goldIncrease = (2*cats+1)+(level*25);
	    }

    }
    
    IEnumerator GoldIncrease()
    {
	    while (true) 
	    {
		    cash += GoldIncome + goldIncrease;
		    UpdateText();
		    yield return new WaitForSeconds(1f);


	    }
    }

	    
    void UpdateText()
    {
	    textMeshPro.SetText("Filips Cash " + cash);
    }

    public void LoadData(GameData data)
    {
	    this.cash = data.cash;
    }

    public void SaveData(ref GameData data)
    {
	    data.cash = this.cash;
    }   

}
