using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager
{
    private static HouseManager instance;

    // Private fields for managing data within the singleton
    public bool illegalHouse = false;
    public int illegalLevel = 0;
    public int illegalCats = 0;

    public static HouseManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new HouseManager();
            }
            return instance;
        }
    }

    // Other methods and properties of the singleton class go here.
}
