using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class IDataPersistenceManager : MonoBehaviour
{
    [Header ("File Storage Config")]

    [SerializeField] private string fileName;
    public static IDataPersistenceManager instance { get; private set; }

    private GameData gameData;

    private List <IDataPersistence> dataPersistenceObjects;

    private FileDataHandler dataHandler;

// singleton setup
    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("NO INSTANCE");
        }
        instance = this;
    }

//assign list for objects and assign standard directive to save data in unity project
    private void Start()
    {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
	    this.dataPersistenceObjects = FindAllDataPersistenceObjects();
	    LoadGame();

    }



//NewGameMethod
    public void NewGame()
    {
        this.gameData = new GameData(); 
    }



//SaveGame method with foreach for gameobjects with ref to gameData
    public void SaveGame()
    {
        // Get data from Scriptus
        // Save to juicepresser
	
	foreach (IDataPersistence dataPersistenceObj in  dataPersistenceObjects)
	{
		dataPersistenceObj.SaveData(ref gameData);
	}
	
     dataHandler.Save(gameData);
    }



//LoadGame method Penis if not and foreach with list
    public void LoadGame()
    {
        // Load from Scriptus
        this.gameData = dataHandler.Load();
        // Get new game if it doesn't exist

        if (this.gameData == null)
        {
		Debug.Log("null data");
            NewGame();
        }

	foreach (IDataPersistence dataPersistenceObj in dataPersistenceObjects)
	{
		dataPersistenceObj.LoadData(gameData);

	}
	
    }
//cool list assigment finding obecj
    private List <IDataPersistence> FindAllDataPersistenceObjects()
    {
	    IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>();

		    return new List<IDataPersistence>(dataPersistenceObjects);
    }

    private void OnApplicationQuit() {
        SaveGame();
    }
}

