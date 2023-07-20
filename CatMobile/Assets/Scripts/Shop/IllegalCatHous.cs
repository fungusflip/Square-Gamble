using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllegalCatHous : MonoBehaviour
{
	[SerializeField] HouseManager HouseManager;
	[SerializeField] CashMoney cashmoney;
    //cool Collider moment
    private void OnTriggerStay2D(Collider2D other)
    {
	   Drag otherObject = other.GetComponent<Drag>();
	   if (otherObject.dropped == true && other.gameObject.CompareTag("Cat"))
	   {
		   other.gameObject.SetActive(false);
		   HouseManager.Instance.illegalCats++;
		   cashmoney.MoneyLaundering();

	   }
		  

    }
}
