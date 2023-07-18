using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//with how we load in scripts we use these
public interface IDataPersistence
{
    // Interface call for LoadData 
    void LoadData(GameData data);
       
    // Interface call for SaveData
    void SaveData(ref GameData data);
  
}
