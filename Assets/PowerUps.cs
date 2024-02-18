using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    public ReadImput Ri;
    public CheckAnswer Ca;

    [Header("Normal Question")]
    public Button firstPowerUpNormal;
    public Button secondPowerUpNormal;
    public Button thirdPowerUpNormal;
    public Button fourthPowerUpNormal;

    [Header("Music Question")]
    public Button firstPowerUpMusic;
    public Button secondPowerUpMusic;
    public Button thirdPowerUpMusic;
    public Button fourthPowerUpMusic;

    [Header("TrueFalse Question")]
    public Button firstPowerUpTrueFalse;
    public Button secondPowerUpTrueFalse;
    public Button thirdPowerUpTrueFalse;
    public Button fourthPowerUpTrueFalse;

    public List<Button> buttonList;
    public bool isTrueFalseQuestion;

    public List<int> playerOnePowerUps = new List<int>() { 1, 1, 1, 1 };
    public List<int> playerTwoPowerUps = new List<int>() { 1, 1, 1, 1 };
    public List<int> playerThreePowerUps = new List<int>() { 1, 1, 1, 1 };
    public List<int> playerFourPowerUps = new List<int>() { 1, 1, 1, 1 };

    public List<int> playersStreak = new List<int>() {0,0,0,0};

    private void Start()
    {
        buttonList.Add(firstPowerUpNormal);
        buttonList.Add(secondPowerUpNormal);
        buttonList.Add(thirdPowerUpNormal);
        buttonList.Add(fourthPowerUpNormal);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (string player in scoreCounter.playersList)
        {
            int index = scoreCounter.playersList.IndexOf(player);
            if (player == scoreCounter.currentPlayer)
            {
                switch (index)
                {
                    case 0:
                        SetActivePowerUps(playerOnePowerUps);
                        AddPowerUp(index, playerOnePowerUps);
                        break;
                    case 1:
                        SetActivePowerUps(playerTwoPowerUps);
                        AddPowerUp(index, playerTwoPowerUps);
                        break;
                    case 2:
                        SetActivePowerUps(playerThreePowerUps);
                        AddPowerUp(index, playerThreePowerUps);
                        break;
                    case 3:
                        SetActivePowerUps(playerFourPowerUps);
                        AddPowerUp(index, playerFourPowerUps);
                        break;
                }
            }
        }



    }

    public void DoubleOrNothing()
    {
        SetPowerUpInactive(1);
        Ca.isDoublePowerUp = true;
    }

    public void FiftyFifty()
    {
        SetPowerUpInactive(0);
        Ca.DeleteHalfOfAnswers();
    }

    public void RandomAnswer()
    {
        Ca.isRandomAnswer = true;
        SetPowerUpInactive(3);
        System.Random rnd = new System.Random();
        int chance = rnd.Next(1, 101);
        if (chance <= 70)
        {
            Ca.CheckRandomAnswer(Ca.goodAnswer);
        }
        else if (isTrueFalseQuestion && chance !<= 70)
        {
            Ca.CheckRandomAnswer(Ca.wrongAnswers[0]);
        }
        else
        {
            int answerChance = rnd.Next(0, 2);
            Ca.CheckRandomAnswer(Ca.wrongAnswers[answerChance]);

        }
        Ca.isRandomAnswer = false;
    }

    public void GetRandomPlayer()
    {
        SetPowerUpInactive(2);

        System.Random rnd = new System.Random();

        int randomIndex = rnd.Next(scoreCounter.playersList.Count);

        if (scoreCounter.currentPlayer == scoreCounter.playersList[randomIndex])
            GetRandomPlayer();
        else
            scoreCounter.currentPlayer = scoreCounter.playersList[randomIndex];
    }

    public void SetActivePowerUps(List<int> powerUpsList)
    {
        for (int i = 0; i < powerUpsList.Count; i++)
        {
            if (powerUpsList[i] == 0)
                buttonList[i].interactable = false;
            else
                buttonList[i].interactable = true;
            if (Ca.isSecondTry)
            {
                buttonList[i].interactable = false;
            }
        }
    }
    public void SetPowerUpInactive(int powerUpNumber)
    {
        foreach (string player in scoreCounter.playersList)
        {
            int index = scoreCounter.playersList.IndexOf(player);
            if (player == scoreCounter.currentPlayer)
            {
                switch (index)
                {
                    case 0:
                        playerOnePowerUps[powerUpNumber] = 0;
                        break;
                    case 1:
                        playerTwoPowerUps[powerUpNumber] = 0;
                        break;
                    case 2:
                        playerThreePowerUps[powerUpNumber] = 0;
                        break;
                    case 3:
                        playerFourPowerUps[powerUpNumber] = 0;
                        break;
                }
            }
        }
    }

    public void DeterminateButtons(int questionGenre)
    {
        buttonList.Clear();

        switch (questionGenre)
        {
            case 0:
                buttonList.Add(firstPowerUpNormal);
                buttonList.Add(secondPowerUpNormal);
                buttonList.Add(thirdPowerUpNormal);
                buttonList.Add(fourthPowerUpNormal);
                isTrueFalseQuestion = false;
                break;
            case 1:
                buttonList.Add(firstPowerUpMusic);
                buttonList.Add(secondPowerUpMusic);
                buttonList.Add(thirdPowerUpMusic);
                buttonList.Add(fourthPowerUpMusic);
                isTrueFalseQuestion = false;
                break;
            case 2:
                buttonList.Add(firstPowerUpTrueFalse);
                buttonList.Add(secondPowerUpTrueFalse);
                buttonList.Add(thirdPowerUpTrueFalse);
                buttonList.Add(fourthPowerUpTrueFalse);
                isTrueFalseQuestion = true;
                break;

        }

    }

    public void AddPowerUp(int playerIndex, List<int> playerPowerUps)
    {
        if (playersStreak[playerIndex] == 3)
        {
            for (int i = 0; i < playerPowerUps.Count; i++)
            {
                if (playerPowerUps[i] == 0)
                {
                    playerPowerUps[i] = 1;
                    playersStreak[playerIndex] = 0;
                    break;
                }
            }
        }
    }

}
