using UnityEngine;
using TMPro;

public class CashMoney : MonoBehaviour
{
	private int money = 0;
	public TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
	    textMeshPro.SetText("Cash " + money);
        
    }

    void UpdateText()
    {
	    textMeshPro.SetText("Cash " + money);
    }
}