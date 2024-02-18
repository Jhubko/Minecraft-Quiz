#nullable enable

using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CategoryTemplate : MonoBehaviour
{
    protected string cattegoryName;
    public string currentRightAnswer;
    public int currentpoints;
    public bool isCorrectAnswer;
    public bool isSecondTry;

    public ScoreCounter scoreCounter;
    public ReadImput Ri;
    public CheckAnswer ca;
    public PowerUps pa;

    [Header("Normal Question")]
    public GameObject questionPanel;
    public Image questionImageObject;
    public GameObject questionTextObject;
    public GameObject answerAObject;
    public GameObject answerBObject;
    public GameObject answerCObject;
    public GameObject answerDObject;
    [Header("Audio Question")]
    public GameObject audioQuestionPanel;
    public GameObject audioEffectObject;
    public GameObject audioAnswerAObject;
    public GameObject audioAnswerBObject;
    public GameObject audioAnswerCObject;
    public GameObject audioAnswerDObject;
    [Header("True/False Question")]
    public GameObject trueFalseQuestionPanel;
    public Image trueFalseImageObject;
    public GameObject trueFalseTextObject;
    public GameObject trueFalseAnswerAObject;
    public GameObject trueFalseAnswerBObject;


    public void Start()
    {
        scoreCounter = GameObject.FindGameObjectWithTag("Canvas").GetComponent<ScoreCounter>();
        Ri = GameObject.FindGameObjectWithTag("PlayerPanel").GetComponent<ReadImput>();
        ca = GameObject.FindGameObjectWithTag("NormalQuestion").GetComponent<CheckAnswer>();
        pa = GameObject.FindGameObjectWithTag("Canvas").GetComponent<PowerUps>();

        questionPanel = GameObject.FindGameObjectWithTag("NormalQuestion");
        questionImageObject = questionPanel.transform.GetChild(0).GetComponent<Image>();
        questionTextObject = questionPanel.transform.Find("QuestionText").gameObject;
        answerAObject = questionPanel.transform.Find("AnswerA").gameObject;
        answerBObject = questionPanel.transform.Find("AnswerB").gameObject;
        answerCObject = questionPanel.transform.Find("AnswerC").gameObject;
        answerDObject = questionPanel.transform.Find("AnswerD").gameObject;

        audioQuestionPanel = GameObject.FindGameObjectWithTag("MusicQuestion");
        audioEffectObject = audioQuestionPanel.transform.Find("AudioSource").gameObject;
        audioAnswerAObject = audioQuestionPanel.transform.Find("AnswerA").gameObject;
        audioAnswerBObject = audioQuestionPanel.transform.Find("AnswerB").gameObject;
        audioAnswerCObject = audioQuestionPanel.transform.Find("AnswerC").gameObject;
        audioAnswerDObject = audioQuestionPanel.transform.Find("AnswerD").gameObject;

        trueFalseQuestionPanel = GameObject.FindGameObjectWithTag("TrueFalseQuestion");
        trueFalseImageObject = trueFalseQuestionPanel.transform.GetChild(0).GetComponent<Image>();
        trueFalseTextObject = trueFalseQuestionPanel.transform.Find("QuestionText").gameObject;
        trueFalseAnswerAObject = trueFalseQuestionPanel.transform.Find("True").gameObject;
        trueFalseAnswerBObject = trueFalseQuestionPanel.transform.Find("False").gameObject;

    }
    public void NormalQuestionMethod(string answerA, string answerB, string answerC, string answerD, string rightAnswer,int questionpoints, string? question = null, Sprite? image = null) 
    {
        ca.buttonList.Clear();
        isSecondTry = false;
        currentpoints = questionpoints;
        currentRightAnswer = rightAnswer;
        questionPanel.gameObject.SetActive(true);
        if (image != null)
        {
            questionImageObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(937, 388);
            questionImageObject.transform.localPosition = new Vector3(-5, 210, 0);
            questionImageObject.sprite = image;
            questionImageObject.gameObject.SetActive(true);
            questionImageObject.GetComponent<Image>().preserveAspect = true;
        }
        if (question != null)
        {
            questionTextObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(938, 469);
            questionTextObject.transform.localPosition = new Vector3(-5, 222, 0);
            questionTextObject.GetComponent<TMP_Text>().text = question;
            questionTextObject.gameObject.SetActive(true);
        }

        if (question != null && image != null)
        {
            questionImageObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(937, 388);
            questionImageObject.transform.localPosition = new Vector3(0, 241, 0);
            questionTextObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1009, 82);
            questionTextObject.transform.localPosition = new Vector3(0, 478, 0);
        }

        answerAObject.GetComponentInChildren<TMP_Text>().text = answerA;
        answerBObject.GetComponentInChildren<TMP_Text>().text = answerB;
        answerCObject.GetComponentInChildren<TMP_Text>().text = answerC;
        answerDObject.GetComponentInChildren<TMP_Text>().text = answerD;

        ca.buttonList.Add(answerAObject);
        ca.buttonList.Add(answerBObject);
        ca.buttonList.Add(answerCObject);
        ca.buttonList.Add(answerDObject);

        pa.DeterminateButtons(0);

        EventSystem.current.currentSelectedGameObject.SetActive(false);
        ca.GetQuestionData(rightAnswer, questionpoints, isSecondTry, false);
       
    }

    public void TrueFalseQuestionMethod (string rightAnswer, int questionpoints, string? question = null, Sprite? image = null)
    {
        ca.buttonList.Clear();
        isSecondTry = true;
        currentpoints = questionpoints;
        currentRightAnswer = rightAnswer;
        trueFalseQuestionPanel.gameObject.SetActive(true);
        if (image != null)
        {
            trueFalseImageObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(937, 388);
            trueFalseImageObject.transform.localPosition = new Vector3(-5, 210, 0);
            trueFalseImageObject.sprite = image;
            trueFalseImageObject.gameObject.SetActive(true);
            trueFalseImageObject.GetComponent<Image>().preserveAspect = true;
        }
        if (question != null)
        {
            trueFalseTextObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(938, 469);
            trueFalseTextObject.transform.localPosition = new Vector3(-5, 222, 0);
            trueFalseTextObject.GetComponent<TMP_Text>().text = question;
            trueFalseTextObject.gameObject.SetActive(true);
        }
        if (question != null && image != null)
        {
            trueFalseImageObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(937, 388);
            trueFalseImageObject.transform.localPosition = new Vector3(0, 241, 0);
            trueFalseTextObject.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1009, 82);
            trueFalseTextObject.transform.localPosition = new Vector3(0, 478, 0);
        }

        ca.buttonList.Add(trueFalseAnswerAObject);
        ca.buttonList.Add(trueFalseAnswerBObject);

        pa.DeterminateButtons(2);

        EventSystem.current.currentSelectedGameObject.SetActive(false);
        ca.GetQuestionData(rightAnswer, questionpoints, isSecondTry, true);
    }
    public void MusicQuestionMethod(string answerA, string answerB, string answerC, string answerD, string rightAnswer, int questionpoints, AudioClip audioFile)
    {
        ca.buttonList.Clear();
        isSecondTry = false;
        currentpoints = questionpoints;
        currentRightAnswer = rightAnswer;
        audioQuestionPanel.gameObject.SetActive(true);

        audioEffectObject.GetComponent<AudioSource>().clip = audioFile;

        audioAnswerAObject.GetComponentInChildren<TMP_Text>().text = answerA;
        audioAnswerBObject.GetComponentInChildren<TMP_Text>().text = answerB;
        audioAnswerCObject.GetComponentInChildren<TMP_Text>().text = answerC;
        audioAnswerDObject.GetComponentInChildren<TMP_Text>().text = answerD;

        ca.buttonList.Add(audioAnswerAObject);
        ca.buttonList.Add(audioAnswerBObject);
        ca.buttonList.Add(audioAnswerCObject);
        ca.buttonList.Add(audioAnswerDObject);

        pa.DeterminateButtons(1);

        EventSystem.current.currentSelectedGameObject.SetActive(false);
        ca.GetQuestionData(rightAnswer, questionpoints, isSecondTry, false);
    }
}
