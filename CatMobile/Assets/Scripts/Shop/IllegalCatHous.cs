using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllegalCatHous : MonoBehaviour
{
    //cool Collider moment
    private void OnTriggerStay2D(Collider2D other)
    {
	   Drag otherObject = other.GetComponent<Drag>();
	   if (otherObject.dropped == true && other.gameObject.CompareTag("Cat"))
	   {
		   Debug.Log("IT WORKED");
	   }
		  

    }
}
