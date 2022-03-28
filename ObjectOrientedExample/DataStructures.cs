using System;
using System.Collections.Generic;
using System.Text;

class DataStructures
{ 
    static void Main(string[] args)
    {
        Player[] players = new Player[100];

        List<Player> plList = new List<Player>();
        //plList[0]
        foreach(Player pl in plList)
        {

        }

        Dictionary<string, Player> playerDict = new Dictionary<string, Player>();

        playerDict.Add("George123456", new Player("George"));
        if(playerDict.ContainsKey("George123456"))
        {
            playerDict["George123456"] = new Player("Chiara");
        }
        else
        {
            playerDict.Add("George123456", new Player("George"));
        }

        foreach(string key in playerDict.Keys)
        {
            //playerDict[key]...
        }
        foreach(Player pl in playerDict.Values)
        {
            //pl
        }

        foreach(KeyValuePair<string, Player> pair in playerDict)
        {
            //pair.Key...
            //pair.Value...
        }

    }
}