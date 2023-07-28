using UnityEngine;

public class SpawnCat : MonoBehaviour
{
    [SerializeField] GameObject evilCommonCat; 
    [SerializeField] GameObject goodCommonCat; 
    [SerializeField] GameObject evilRareCat; 
    [SerializeField] GameObject goodRareCat; 
    [SerializeField] GameObject evilLegendaryCat; 
    [SerializeField] GameObject goodLegendaryCat;  
    [SerializeField] Buttons buttons;
    [SerializeField] Transform spawnPoint;

    void Start()
    {
        Invoke("InstantiateCats", 1.0f);
    }

    void InstantiateCats()
    {
        for (int i = 0; i < buttons.evilCommonCat; i++)
        {
            // Instantiate the prefab at the desired position and rotation
            Instantiate(evilCommonCat, spawnPoint.position, spawnPoint.rotation);
        }

        for (int i = 0; i < buttons.goodCommonCat; i++)
        {
            // Instantiate the prefab at the desired position and rotation
            Instantiate(goodCommonCat, spawnPoint.position, spawnPoint.rotation);
        }

        for (int i = 0; i < buttons.evilRareCat; i++)
        {
            // Instantiate the prefab at the desired position and rotation
            Instantiate(evilRareCat, spawnPoint.position,spawnPoint.rotation);
        }

        for (int i = 0; i < buttons.goodRareCat; i++)
        {
            // Instantiate the prefab at the desired position and rotation
            Instantiate(goodRareCat, spawnPoint.position,spawnPoint.rotation);
        }

        for (int i = 0; i < buttons.evilLegendaryCat; i++)
        {
            // Instantiate the prefab at the desired position and rotation
            Instantiate(evilLegendaryCat, spawnPoint.position,spawnPoint.rotation);
        }

        for (int i = 0; i < buttons.goodLegendaryCat; i++)
        {
            // Instantiate the prefab at the desired position and rotation
            Instantiate(goodLegendaryCat, spawnPoint.position,spawnPoint.rotation);
        }
    }      
}