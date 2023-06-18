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


    public int catIntCommon = 0;
    public int catIntRare = 0;
    public int catIntLegendary = 0;
    // Count variable
    // random variable with count int
    // Index with count int 
    
    


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
         catIntCommon++;
         Debug.Log(catIntCommon);
        
        }

        
        if (randomChance > 0.5f && randomChance < 0.8f)
      {
        GameObject spawnedCat = Instantiate(objectRandomRare, spawnPoint.position, spawnPoint.rotation);
        catIntRare++;
        Debug.Log(catIntRare);
      }
        
        if (randomChance > 0.8f && randomChance < 0.9f)
      {
        GameObject spawnedCat = Instantiate(objectRandomlegendary, spawnPoint.position, spawnPoint.rotation);
        catIntLegendary++;
        Debug.Log(catIntLegendary);
      }
       
    }

    public void BreedButtonActive()
    {
        
        breedMenu.SetActive(true);

    }
}
