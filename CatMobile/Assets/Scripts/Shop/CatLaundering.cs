using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatLaundering : MonoBehaviour
{
	[SerializeField] Button button;

	public void Update() 
	{

		if (DataHandler.Instance.Cash >= 10)
		{

			button.interactable = true;

		}

	}



}
