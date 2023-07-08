using UnityEngine;

public class DataHandler : MonoBehaviour
{
    public static DataHandler instance;
    public int CommonCats { get; set;}
    public int RareCats { get; set;}
    public int LegendaryCats { get; set;}
    public int Cash { get; set;}	

    public static DataHandler Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataHandler>();
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    instance = singletonObject.AddComponent<DataHandler>();
                    singletonObject.name = typeof(DataHandler).ToString() + " (Singleton)";
                    DontDestroyOnLoad(singletonObject);
                }
            }
            return instance;
        }
    }
}
