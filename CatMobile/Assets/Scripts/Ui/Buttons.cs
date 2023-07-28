using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour, IDataPersistence
{
    [SerializeField] private Transform spawnPoint; 
    [SerializeField] private GameObject breedMenu;  
    [SerializeField] private GameObject shopItemIllegal;
    [SerializeField] private GameObject catEnclopedia;
    [SerializeField] private List<GameObject> commonCats;
    [SerializeField] private List<GameObject> rareCats;
    [SerializeField] private List<GameObject> legendaryCats;
    [SerializeField] private CashMoney cashMoney;
    [SerializeField] private GameObject gambleMenu;

    public int evilCommonCat;
    public int goodCommonCat;
    public int evilRareCat;
    public int goodRareCat;
    public int evilLegendaryCat;
    public int goodLegendaryCat;

    public void SpawnACat()
    {
       cashMoney.cash -= 1400;
       float randomChance = Random.Range(0f, 1f);
       int commonCatsRandom = Random.Range(0, commonCats.Count);
       int rareCatsRandom = Random.Range(0, rareCats.Count);
       int legendaryCatsRandom = Random.Range(0, legendaryCats.Count);

       GameObject objectRandomCommon = commonCats[commonCatsRandom];
       GameObject objectRandomRare = rareCats[rareCatsRandom];
       GameObject objectRandomlegendary = legendaryCats[legendaryCatsRandom];
       Quirk quirkCommon = objectRandomCommon.GetComponent<Quirk>();
       Quirk quirkRare = objectRandomCommon.GetComponent<Quirk>();
       Quirk quirkLegendary = objectRandomCommon.GetComponent<Quirk>();
       
       
       if (randomChance > 0.0f && randomChance < 0.5f)
       {
        
         GameObject spawnedCat = Instantiate(objectRandomCommon, spawnPoint.position, spawnPoint.rotation);

        }

      

        if (randomChance > 0.5f && randomChance < 0.8f)
      {
        GameObject spawnedCat = Instantiate(objectRandomRare, spawnPoint.position, spawnPoint.rotation);
      }

        
        if (randomChance > 0.8f && randomChance < 0.9f)
      {
        GameObject spawnedCat = Instantiate(objectRandomlegendary, spawnPoint.position, spawnPoint.rotation);
      }

       if(quirkCommon.evil == true && quirkCommon.common == true){
        evilCommonCat++;
        Debug.Log("1saved");
       }
       if(quirkCommon.good  == true && quirkCommon.common == true){
        goodCommonCat++;
        Debug.Log("2saved");
       }
       if(quirkRare.evil == true && quirkRare.rare == true){
        evilRareCat++;
        Debug.Log("3saved");
       }
       if(quirkRare.good == true && quirkRare.rare == true){
        goodRareCat++;
        Debug.Log("4saved");
       }
       if(quirkLegendary.evil == true && quirkLegendary.legendary == true){
        evilLegendaryCat++;
        Debug.Log("5saved");
       }
       if(quirkLegendary.good == true && quirkLegendary.legendary == true){
        goodLegendaryCat++;
        Debug.Log("6saved");
       }
       
    }

    public void ShopButtonActive()
    { 
      breedMenu.SetActive(true);
    }

    public void ShopButtonOff()
    {
	    breedMenu.SetActive(false);

    }
     
    public void IllegalButton()
    {
	    shopItemIllegal.SetActive(true);
      cashMoney.MoneyLaunderingLevel();
    }

    public void catEnclopediaButton()
    {
	    catEnclopedia.SetActive(true);
    }

    public void catEnclopediaButtonOff()
    {
	    catEnclopedia.SetActive(false);
    }

    public void GambelButtonActive()
    { 
      gambleMenu.SetActive(true);
    }

    public void GambelButtonOff()
    {
	    gambleMenu.SetActive(false);

    }
     
    public void SaveData(ref GameData data)
    {
    data.evilCommonCat = this.evilCommonCat;
    data.goodCommonCat = this.goodCommonCat;
    data.evilRareCat = this.evilRareCat;
    data.goodRareCat = this.goodRareCat;
    data.evilLegendaryCat = this.evilLegendaryCat;
    data.goodLegendaryCat = this.goodLegendaryCat;

    }   

    public void LoadData(GameData data)
    {
      this.evilCommonCat = data.evilCommonCat;
      this.goodCommonCat = data.goodCommonCat;
      this.evilRareCat = data.evilRareCat;
      this.goodRareCat = data.goodRareCat;
      this.evilLegendaryCat = data.evilLegendaryCat;
      this.goodLegendaryCat = data.goodLegendaryCat;

    }

    

}

	
	

