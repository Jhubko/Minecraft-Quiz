using UnityEngine;

public class Redstone : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Na ile bloków starcza sygnał redstone?";
    private readonly string secondQuestion = "Ile redstone wypada z rudy wykopanej zwykłym kilofem bez enchantu?";
    private readonly string thirdQuestion = "Ile trwa jeden Tick?";
    private readonly string fourthQuestion = "Ile maksymalnie bloków może przesunąć tłok?";
    private readonly string fifthQuestion = "Ile dzwięków może wydobyć się z note blocka?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "10 bloków";
    private readonly string firstQuestionBAnswer = "12 bloków";
    private readonly string firstQuestionCAnswer = "15 bloków";
    private readonly string firstQuestionDAnswer = "16 bloków";

    private readonly string secondQuestionAAnswer = "3-4";
    private readonly string secondQuestionBAnswer = "4-5";
    private readonly string secondQuestionCAnswer = "5-6";
    private readonly string secondQuestionDAnswer = "6-8";

    private readonly string thirdQuestionAAnswer = "0.1 sekundy";
    private readonly string thirdQuestionBAnswer = "0.2 sekundy";
    private readonly string thirdQuestionCAnswer = "0.5 sekundy";
    private readonly string thirdQuestionDAnswer = "1.5 sekundy";

    private readonly string fourthQuestionAAnswer = "8";
    private readonly string fourthQuestionBAnswer = "12";
    private readonly string fourthQuestionCAnswer = "14";
    private readonly string fourthQuestionDAnswer = "16";

    private readonly string fifthQuestionAAnswer = "12";
    private readonly string fifthQuestionBAnswer = "16";
    private readonly string fifthQuestionCAnswer = "20";
    private readonly string fifthQuestionDAnswer = "24";

    private int firstQuestionPoints = 100;
    private int secondQuestionPoints = 150;
    private int thirdQuestionPoints = 200;
    private int fourthQuestionPoints = 250;
    private int fifthQuestionPoints = 300;


    public void FirstQuestion()
    {
        //For Normal question
        NormalQuestionMethod(firstQuestionAAnswer, firstQuestionBAnswer, firstQuestionCAnswer, firstQuestionDAnswer, firstQuestionCAnswer, firstQuestionPoints, question: firstQuestion);
    }
    public void SecondQuestion()
    {
        NormalQuestionMethod(secondQuestionAAnswer, secondQuestionBAnswer, secondQuestionCAnswer, secondQuestionDAnswer, secondQuestionBAnswer, secondQuestionPoints, question: secondQuestion);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionAAnswer, thirdQuestionPoints, question: thirdQuestion);
    }
    public void FourthQuestion()
    {
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionBAnswer, fourthQuestionPoints, question: fourthQuestion);
    }
    public void FifthQuestion()
    {
        NormalQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionDAnswer, fifthQuestionPoints, question: fifthQuestion);
    }

}
