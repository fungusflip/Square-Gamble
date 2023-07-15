using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistence
{
    // Interface call for LoadData 
    void LoadData(GameData data);
       
    // Interface call for SaveData
    void SaveData(ref GameData data);
  
}
