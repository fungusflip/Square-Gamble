using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatLaundering : MonoBehaviour
{
	private Button button;

	public void Start() 
	{

	        Button = gameObject.GetComponent<Button>;


		if (DataHandler.Instance.Cash >= 50)
		{

			button.interactable = true;
		}

	}



}
