using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReadImput : MonoBehaviour
{
    public List<TMP_Text> playersGameObjectsList;
    public List<TMP_Text> playersStreakList;
    public ScoreCounter sc;

    public void Start()
    {
        foreach (TMP_Text playerGO in playersGameObjectsList)
        {
            playerGO.gameObject.SetActive(false);
        }
    }

    public void ReadPlayerInput(string s)
    {
        sc.playersList.Add(s);
        for (int i = 0; i < sc.playersList.Count; i++)
        {
            playersGameObjectsList[i].text = sc.playersList[i];
            playersGameObjectsList[i].gameObject.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        transform.gameObject.SetActive(false);
        Debug.Log(sc.playersList[0]);
        sc.currentPlayer = sc.playersList[0];
        GameObject.FindGameObjectWithTag("NormalQuestion").SetActive(false);
        GameObject.FindGameObjectWithTag("TrueFalseQuestion").SetActive(false);
        GameObject.FindGameObjectWithTag("MusicQuestion").SetActive(false); 
    }
}
