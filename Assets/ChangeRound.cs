using System.Linq;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRound : MonoBehaviour
{
    public GameObject firstRoundPanel;
    public GameObject secondRoundPanel;
    public GameObject PlayerPanel;
    public GameObject NormalQuestion;
    public GameObject TrueFalseQuestion;
    public GameObject MusicQuestion;
    public GameObject ChangeRoundScreen;
    public GameObject EndGamePanel;
    public GameObject WinnerText;
    public Image BackGround;
    public Sprite SecondRoundBackGround;
    public Sprite FirstRoundBackGround;
    public ScoreCounter sc;
    public ReadImput ri;


    public void ChangeRoundPanel()
    {
        
        if (firstRoundPanel.gameObject.activeInHierarchy)
        {
            firstRoundPanel.gameObject.SetActive(false);
            secondRoundPanel.gameObject.SetActive(true);
            BackGround.sprite = SecondRoundBackGround;
            SetActiveMethod();
        }
        else
        {
            firstRoundPanel.gameObject.SetActive(true);
            secondRoundPanel.gameObject.SetActive(false);
            BackGround.sprite = FirstRoundBackGround;
            SetActiveMethod();
        }
    }
    public async void SetActiveMethod()
    {
        ChangeRoundScreen.SetActive(true);
        PlayerPanel.gameObject.SetActive(true);
        NormalQuestion.gameObject.SetActive(true);
        TrueFalseQuestion.gameObject.SetActive(true);
        MusicQuestion.SetActive(true);
        await Task.Delay(500);
        PlayerPanel.gameObject.SetActive(false);
        NormalQuestion.gameObject.SetActive(false);
        TrueFalseQuestion.gameObject.SetActive(false);
        MusicQuestion.SetActive(false);
        ChangeRoundScreen.SetActive(false);
    }

    public void EndGame()
    {
        EndGamePanel.SetActive(true);
        int winnedIndex = sc.playersCurrentScore.IndexOf(sc.playersCurrentScore.Max());
        WinnerText.GetComponent<TMP_Text>().text = sc.playersList[winnedIndex];
    }
}
