using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class CashMoney : MonoBehaviour, IDataPersistence
{
	[SerializeField] TextMeshProUGUI textMeshPro;
	[SerializeField] GameObject houseObject;

	int goldIncome = 2;
	public int cash{get; private set;}

	public int GoldIncome{
		
		get { return goldIncome; }
		set { goldIncome = value;
	        UpdateText();}
	}

    void Start()
    {
	    StartCoroutine(GoldIncrease());
	    textMeshPro.SetText("Filips Cash " + cash);
	    
    }
    

    IEnumerator GoldIncrease()
    {
	    while (true) 
	    {
		    cash += GoldIncome;
		    UpdateText();
		    yield return new WaitForSeconds(1f);


	    }
    }

	    
    void UpdateText()
    {
	    textMeshPro.SetText("Filips Cash " + cash);
    }

    public void MoneyLaundering()
    {
	    if(houseObject.activeSelf)
	    {
	    houseObject.SetActive(true);
	    }

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
