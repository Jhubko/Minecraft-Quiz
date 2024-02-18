using System.Threading.Tasks;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Reflection;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine.Assertions;

public class CheckAnswer : MonoBehaviour
{
    public string currentRightAnswer;
    public int currentpoints;
    public bool isSecondTry;
    public bool isTrueFalseQuestion;
    public bool isDoublePowerUp;
    public bool isRandomAnswer;

    public ScoreCounter scoreCounter;
    public ReadImput Ri;
    public PowerUps pu;

    [Header("Answer buttons")]
    public List<GameObject> buttonList;
    public List<GameObject> currentButtonList;
    public List<GameObject> wrongAnswers;
    public GameObject goodAnswer;

    [Header("Normal Question")]
    public Image questionImageObject;
    public GameObject questionPanel;
    public GameObject questionTextObject;

    [Header("Normal Question")]
    public Image trueFalseImageObject;
    public GameObject trueFalseTextObject;
    public GameObject trueFalseQuestionPanel;

    [Header("Music Question")]
    public GameObject MusicQuestionPanel;
    public GameObject audioEffectObject;

    public AudioSource soundPlayer;
    public AudioClip rightClip;
    public AudioClip wrongClip;


    public void Start()
    {
        audioEffectObject = GameObject.FindGameObjectWithTag("MainAudioSource");
        isDoublePowerUp = false;
        isRandomAnswer = false;
    }

    public void GetQuestionData(string rightAnswer, int points, bool secondTry, bool TrueFalseQuestion)
    {
        currentpoints = points;
        currentRightAnswer = rightAnswer;
        isSecondTry = secondTry;
        isTrueFalseQuestion = TrueFalseQuestion;
        GetAnswersButtons();
    }

    public async void AnswerCheck()
    {
        GameObject clickedAnswer = EventSystem.current.currentSelectedGameObject;

            if (clickedAnswer.GetComponentInChildren<TMP_Text>().text == currentRightAnswer)
            {
                clickedAnswer.GetComponent<Image>().color = Color.green;
                RightAnswer(clickedAnswer);
            }
            else
            {
                audioEffectObject.GetComponent<AudioSource>().clip = wrongClip;
                soundPlayer.Play();
                clickedAnswer.GetComponent<Image>().color = Color.red;

                if (!isSecondTry)
                {
                    foreach (string player in scoreCounter.playersList)
                    {

                        int index = scoreCounter.playersList.IndexOf(player);
                        if (player == scoreCounter.currentPlayer)
                        {
                            if (isDoublePowerUp)
                            {
                                pu.playersStreak[index] = 0;
                                scoreCounter.playersCurrentScore[index] -= currentpoints * 2;
                            }
                            else
                            {
                                pu.playersStreak[index] = 0;
                                scoreCounter.playersCurrentScore[index] -= Convert.ToInt32(currentpoints / 4);
                            }
                        }
                    }

                    await Task.Delay(2000);
                    isSecondTry = true;
                    ChangeCurrentPlayer();
                    clickedAnswer.GetComponent<Image>().color = Color.white;
                }
                else
                {
                    await Task.Delay(2000);
                    clickedAnswer.GetComponent<Image>().color = Color.white;
                    EndQuestion();
                }
            }
    }

    public async void CheckRandomAnswer(GameObject answer)
    {
        if (answer.GetComponentInChildren<TMP_Text>().text == currentRightAnswer)
        {
            answer.GetComponent<Image>().color = Color.green;
            RightAnswer(answer);
        }
        else
        {
            audioEffectObject.GetComponent<AudioSource>().clip = wrongClip;
            soundPlayer.Play();
            answer.GetComponent<Image>().color = Color.red;

            foreach (string player in scoreCounter.playersList)
            {

                int index = scoreCounter.playersList.IndexOf(player);
                if (player == scoreCounter.currentPlayer)
                {
                    if (isDoublePowerUp)
                    {
                        pu.playersStreak[index] = 0;
                        scoreCounter.playersCurrentScore[index] -= currentpoints * 2;
                    }
                    else
                    {
                        pu.playersStreak[index] = 0;
                        scoreCounter.playersCurrentScore[index] -= Convert.ToInt32(currentpoints / 4);
                    }
                }
            }
            await Task.Delay(2000);
            isSecondTry = true;
            ChangeCurrentPlayer();
            EndQuestion();
            answer.GetComponent<Image>().color = Color.white;
        }
    }

    public void ChangeCurrentPlayer()
    {
        int currentPlayerIndex = scoreCounter.playersList.IndexOf(scoreCounter.currentPlayer);

        if (currentPlayerIndex == scoreCounter.playersList.Count-1)
            scoreCounter.currentPlayer = scoreCounter.playersList[0];
        else
            scoreCounter.currentPlayer = scoreCounter.playersList[currentPlayerIndex + 1];
    }

    public void EndQuestion()
    {
        isDoublePowerUp = false;
        questionPanel.gameObject.SetActive(false);
        questionImageObject.gameObject.SetActive(false);
        trueFalseImageObject.gameObject.SetActive(false);
        trueFalseQuestionPanel.gameObject.SetActive(false);
        MusicQuestionPanel.gameObject.SetActive(false);
        questionTextObject.GetComponent<TMP_Text>().text = "";
        trueFalseTextObject.GetComponent<TMP_Text>().text = "";
        wrongAnswers.Clear();
        foreach (var button in buttonList)
        {
            button.GetComponent<Image>().enabled = true;
        }
        ResetImageAndTextPosition();
    }

    public void ResetImageAndTextPosition()
    {
        questionImageObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(473, 225);
        questionImageObject.transform.localPosition = new Vector3(-4, 112, 0);
        questionTextObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(310, 139);
        questionTextObject.transform.localPosition = new Vector3(0, 108, 0);
    }

    public async void DeleteHalfOfAnswers()
    {
        int randomNumber;
        int lastNumber = new();

        await Task.Delay(2000);

        for (int i = 0; i < 2;)
        {
            randomNumber = Random.Range(0, 3);

            if (randomNumber == lastNumber)
            {
                randomNumber = Random.Range(0, 3);
            }
            else
            {
                lastNumber = randomNumber;
                wrongAnswers[randomNumber].GetComponent<Image>().enabled = false;
                currentButtonList.RemoveAt(randomNumber);
                i++;
            }
        }
    }

    public void GetAnswersButtons()
    {
        currentButtonList.Clear();
        currentButtonList.AddRange(buttonList);
        foreach (GameObject x in currentButtonList)
        {
            if (x.GetComponentInChildren<TMP_Text>().text != currentRightAnswer)
                wrongAnswers.Add(x);
            else
                goodAnswer = x;
        }
    }

    public async void RightAnswer(GameObject givenAnswer)
    {
        audioEffectObject.GetComponent<AudioSource>().clip = rightClip;
        soundPlayer.Play();
        await Task.Delay(2000);
        foreach (string player in scoreCounter.playersList)
        {
            int index = scoreCounter.playersList.IndexOf(player);
            if (player == scoreCounter.currentPlayer)
            {
                if (isDoublePowerUp)
                {
                    pu.playersStreak[index] += 1;
                    scoreCounter.playersCurrentScore[index] += isSecondTry && !isTrueFalseQuestion ? currentpoints : currentpoints * 2;
                }
                else
                {
                    pu.playersStreak[index] += 1;
                    scoreCounter.playersCurrentScore[index] += isSecondTry && !isTrueFalseQuestion ? currentpoints / 2 : currentpoints;
                }
            }
        }
        EndQuestion();
        ChangeCurrentPlayer();
        givenAnswer.GetComponent<Image>().color = Color.white;
    }
}
