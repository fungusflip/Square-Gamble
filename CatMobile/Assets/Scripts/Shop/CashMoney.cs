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
	public int goldIncrease = 0;
	public int cost = 400;
	public int cash;
	int level = HouseManager.Instance.illegalLevel;
	int cats = HouseManager.Instance.illegalCats;

    void Start()
    {
	    StartCoroutine(GoldIncrease());
	    textMeshPro.SetText("Filips Cash " + cash);
		
		if (HouseManager.Instance.illegalHouse == true)
		{
		 houseObject.SetActive(true);
		}
		if (HouseManager.Instance.illegalLevel == 2)
		{
			cost = 1400;
		}
		if (HouseManager.Instance.illegalLevel == 1)
		{
			cost = 800;
		}
		if (HouseManager.Instance.illegalLevel == 0)
		{
			cost = 400;
		}
		goldIncrease = (level*25);
	    
    }

	public void MoneyLaunderingLevel()
    {
		HouseManager.Instance.illegalLevel++;
	    if(houseObject.activeSelf)
	    {	
			
			HouseManager.Instance.illegalHouse = true;
			level++;
			goldIncrease = (level*25);
			cash -= cost;
			cost += 400;
			
	    }

    }
    
    IEnumerator GoldIncrease()
    {
	    while (true) 
	    {
		    cash += goldIncome + goldIncrease;
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
		HouseManager.Instance.illegalHouse = data.illegalHouse;
		HouseManager.Instance.illegalLevel = data.illegalHouseLevel;
    }

    public void SaveData(ref GameData data)
    {
	    data.cash = this.cash;
		data.illegalHouseLevel = HouseManager.Instance.illegalLevel;
		data.illegalHouse = HouseManager.Instance.illegalHouse;
    }   

}
