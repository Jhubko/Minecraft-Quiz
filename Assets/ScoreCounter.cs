using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text currentPlayerObject;
    public List<int> playersCurrentScore;
    public List<string> playersList;
    public List<TMP_Text> playersScoreObject;
    public string currentPlayer;
    public ReadImput ri;
    public PowerUps pu;

    public void setPlayer(string index)
    {
        currentPlayer = playersList[int.Parse(index)];
    }
    // Update is called once per frame
    private void Update()
    {
        currentPlayerObject.text = "Gracz: " + currentPlayer;

        for (int i = 0; i < playersCurrentScore.Count; i++) 
        {
            playersScoreObject[i].text = playersCurrentScore[i].ToString();
            ri.playersStreakList[i].text = "STREAK: " + pu.playersStreak[i].ToString();
        }
    }
}
