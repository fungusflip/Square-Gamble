using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    	
    public int cash;	
    public bool illegalHouse;
    public int illegalHouseLevel;
    public int evilCommonCat;
    public int goodCommonCat;
    public int evilRareCat;
    public int goodRareCat;
    public int evilLegendaryCat;
    public int goodLegendaryCat;
    
   
    public GameData()
    {
       this.cash = 0; 
       this.illegalHouse = false;
       this.illegalHouseLevel = 0;
       this.evilCommonCat = 0;
       this.goodCommonCat = 0;
       this.evilRareCat = 0;
       this.goodRareCat = 0;
       this.evilLegendaryCat = 0;
       this.goodLegendaryCat = 0;
       
    }
}
