using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class CashMoney : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI textMeshPro;
	[SerializeField] GameObject houseObject;

	int goldIncome = 2;

	public int GoldIncome{
		
		get { return goldIncome; }
		set { goldIncome = value;
	        UpdateText();}
	}


    // Start is called before the first frame update
    void Start()
    {
	    StartCoroutine(GoldIncrease());
	    textMeshPro.SetText("Filips Cash " + DataHandler.Instance.Cash);
	    
    }
    
    void update()
    {
	    Debug.Log(GoldIncome);
   
    }

    IEnumerator GoldIncrease()
    {
	    while (true) 
	    {
		    DataHandler.Instance.Cash += GoldIncome;
		    UpdateText();
		    yield return new WaitForSeconds(1f);


	    }
    }

	    
    void UpdateText()
    {
	    textMeshPro.SetText("Filips Cash " + DataHandler.Instance.Cash);
    }

    public void MoneyLaundering()
    {
	    if(houseObject.activeSelf)
	    {
	    houseObject.SetActive(true);
	    }

    }

}
