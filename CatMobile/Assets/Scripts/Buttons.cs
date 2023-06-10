using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject prefab; // Right now what cat spawns
    [SerializeField] private Transform spawnPoint; // Position for CatSpawning
    [SerializeField] private GameObject breedMenu;  // BreedMenu
    [SerializeField] private List<GameObject> commonCats;
    [SerializeField] private List<GameObject> rareCats;
    [SerializeField] private List<GameObject> legendaryCats;


    public int catIntRed = 0;
    public int catIntBlue = 0;
    
    


    public void SpawnACat()
    {
       float randomChance = Random.Range(0f, 1f);

       
       if (randomChance > 0.5f)
       {
         GameObject spawnedCat = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
         catIntRed++;
         Debug.Log(catIntRed);
        
         }
        
        if (randomChance > 0.7)
        {


        }
    }
       

    public void BreedButtonActive()
    {
        
        breedMenu.SetActive(true);

    }
}
