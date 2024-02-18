using UnityEngine;

public class YouTube : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Na czyim kanale znajduje się piosenka \"Znowu Mam Bana\"?";
    private readonly string secondQuestion = "Jak nazywała się pierwsza seria na YT, na której wielu youtuberów grało na jednym serwerze?";
    private readonly string thirdQuestion = "Ile odcinków miała seria przygody z Minecraft sezon 2 na Kanale JJayJoker?";
    private readonly string fourthQuestion = "Jaki tytuł nosił pierwszy polski film z Minecraft?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "Stuu";
    private readonly string firstQuestionBAnswer = "Blowek";
    private readonly string firstQuestionCAnswer = "Masterczułek";
    private readonly string firstQuestionDAnswer = "Rezi";

    private readonly string secondQuestionAAnswer = "Kanciasta Codzienność";
    private readonly string secondQuestionBAnswer = "Kwadratowa Masakra";
    private readonly string secondQuestionCAnswer = "Kanciasta Dolina";
    private readonly string secondQuestionDAnswer = "Kwadratowa Codzienność";

    private readonly string thirdQuestionAAnswer = "12";
    private readonly string thirdQuestionBAnswer = "10";
    private readonly string thirdQuestionCAnswer = "11";
    private readonly string thirdQuestionDAnswer = "14";

    private readonly string fourthQuestionAAnswer = "Minecraft - Poradnik #001 - Pierwsza noc";
    private readonly string fourthQuestionBAnswer = "Autostrada w Minecraftcie :F (Highway in Minecraft)";
    private readonly string fourthQuestionCAnswer = "Moj domek Minecraft + Proœba";
    private readonly string fourthQuestionDAnswer = "Miasto w minecraft City in minecraft";

    private readonly string fifthQuestionAAnswer = "Hidden Agenda";
    private readonly string fifthQuestionBAnswer = "Sneaky Adventure";
    private readonly string fifthQuestionCAnswer = "Kool Kats";
    private readonly string fifthQuestionDAnswer = "Sneaky Snitch";

    public AudioClip fifthQuestionClip;

    private int firstQuestionPoints = 100;
    private int secondQuestionPoints = 150;
    private int thirdQuestionPoints = 200;
    private int fourthQuestionPoints = 250;
    private int fifthQuestionPoints = 300;


    public void FirstQuestion()
    {
        NormalQuestionMethod(firstQuestionAAnswer, firstQuestionBAnswer, firstQuestionCAnswer, firstQuestionDAnswer, firstQuestionBAnswer, firstQuestionPoints, question: firstQuestion);        
    }
    public void SecondQuestion()
    {
        NormalQuestionMethod(secondQuestionAAnswer, secondQuestionBAnswer, secondQuestionCAnswer, secondQuestionDAnswer, secondQuestionCAnswer, secondQuestionPoints, question: secondQuestion);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionCAnswer, thirdQuestionPoints, question: thirdQuestion);
    }
    public void FourthQuestion()
    {
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionBAnswer, fourthQuestionPoints, question: fourthQuestion);;
    }
    public void FifthQuestion()
    {
        MusicQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionDAnswer, fifthQuestionPoints, fifthQuestionClip);
    }

}
