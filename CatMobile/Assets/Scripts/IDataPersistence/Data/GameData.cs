using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    	
    public int cash;	
   
   //the values define in this constructer will be the default values
   // the game starts with no data to Load

   //todo add house and shop GameData with dictonary int lvl and bool bought
   //todo cat object save maybe with what house it is in? https://www.youtube.com/watch?v=aUi9aijvpgs&t=500s
    public GameData()
    {
       this.cash = 0; 
    }
}
