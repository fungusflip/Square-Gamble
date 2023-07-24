using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllegalCatHous : MonoBehaviour
{
	[SerializeField] HouseManager HouseManager;
	[SerializeField] CashMoney cashmoney;
	private GameObject house;

    //cool Collider moment
    private void OnTriggerStay2D(Collider2D other)
    {
	   Drag otherDrag = other.GetComponent<Drag>();
	   Quirk otherQuirk= other.GetComponent<Quirk>();
	   if (otherDrag.dropped == true && other.gameObject.CompareTag("Cat"))
	   {
		   other.gameObject.SetActive(false);
		   if(otherQuirk.evil == true)
		   {
			
			cashmoney.goldIncrease += 5;
		   }
		   if(otherQuirk.evil == false)
		   {
			cashmoney.goldIncrease += 1;
		   }
	   }
		  

    }
}
