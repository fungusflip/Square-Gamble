using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class IDataPersistenceManager : MonoBehaviour
{
    public static IDataPersistenceManager instance { get; private set; }

    private GameData gameData;

    private List <IDataPersistence> dataPersistenceObjects;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("NO INSTANCE");
        }
        instance = this;
    }

    private void Start()
    {
	    this.dataPersistenceObjects = FindAllDataPersistenceObjects();
	    LoadGame();

    }

    public void NewGame()
    {
        this.gameData = new GameData(); 
    }

    public void SaveGame()
    {
        // Get data from Scriptus
        // Save to juicepresser
	
	foreach (IDataPersistence dataPersistenceObj in  dataPersistenceObjects)
	{
		dataPersistenceObj.SaveData(ref gameData);
	}
	Debug.Log("Saved");
    }

    public void LoadGame()
    {
        // Load from Scriptus
        // Get new game if it doesn't exist

        if (this.gameData == null)
        {
		Debug.Log("Penis");
            NewGame();
        }

	foreach (IDataPersistence dataPersistenceObj in dataPersistenceObjects)
	{
		dataPersistenceObj.LoadData(gameData);

	}
	Debug.Log("Loaded");
    }

    private List <IDataPersistence> FindAllDataPersistenceObjects()
    {
	    IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>();

		    return new List<IDataPersistence>(dataPersistenceObjects);
    }
}

