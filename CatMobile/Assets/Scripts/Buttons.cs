using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject prefabRed; // Right now what cat spawns
    [SerializeField] private Transform spawnPoint; // Position for CatSpawning
    [SerializeField] private GameObject breedMenu;  // BreedMenu
    [SerializeField] private List<GameObject> commonCats;
    [SerializeField] private List<GameObject> rareCats;
    [SerializeField] private List<GameObject> legendaryCats;


    void Start()
    {
	    dataHandler = DataHandler.instance;
    }
    
    


    public void SpawnACat()
    {
       float randomChance = Random.Range(0f, 1f);
       int commonCatsNumber = commonCats.Count;
       int rareCatsNumber = rareCats.Count;
       int legendaryCatsNumber = legendaryCats.Count;
       int commonCatsRandom = Random.Range(0, commonCatsNumber);
       int rareCatsRandom = Random.Range(0, rareCatsNumber);
       int legendaryCatsRandom = Random.Range(0, legendaryCatsNumber);

       GameObject objectRandomCommon = commonCats[commonCatsRandom];
       GameObject objectRandomRare = rareCats[rareCatsRandom];
       GameObject objectRandomlegendary = legendaryCats[legendaryCatsRandom];

       
       if (randomChance > 0.0f && randomChance < 0.5f)
       {
         GameObject spawnedCat = Instantiate(objectRandomCommon, spawnPoint.position, spawnPoint.rotation);
         dataHandler.CommonCats++;
        
        }

        
        if (randomChance > 0.5f && randomChance < 0.8f)
      {
        GameObject spawnedCat = Instantiate(objectRandomRare, spawnPoint.position, spawnPoint.rotation);
        dataHandler.RareCats++;
      }
        
        if (randomChance > 0.8f && randomChance < 0.9f)
      {
        GameObject spawnedCat = Instantiate(objectRandomlegendary, spawnPoint.position, spawnPoint.rotation);
        dataHandler.LegendaryCats++;
	Debug.Log(dataHandler.LegendaryCats);
      }
       
    }

    public void BreedButtonActive()
    {
        
        breedMenu.SetActive(true);

    }

    public void BreedButtonOff()
    {
	breedMenu.SetActive(false);
    }
	
}
