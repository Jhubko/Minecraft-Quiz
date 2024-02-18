using UnityEngine;

public class Techniczne : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Jakiej wielkości jest chunk?";
    private readonly string secondQuestion = "Jaki jest limit budowania w górę?";
    private readonly string thirdQuestion = "Jak długi jest dzień w Minecraft?";
    private readonly string fourthQuestion = "Jak daleko od spawna jest granica mapy?";
    private readonly string fifthQuestion = "Ile jest achievementów w Minecraft?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "12x12";
    private readonly string firstQuestionBAnswer = "16x16";
    private readonly string firstQuestionCAnswer = "32x32";
    private readonly string firstQuestionDAnswer = "64x64";

    private readonly string secondQuestionAAnswer = "180";
    private readonly string secondQuestionBAnswer = "240";
    private readonly string secondQuestionCAnswer = "260";
    private readonly string secondQuestionDAnswer = "320";

    private readonly string thirdQuestionAAnswer = "15 minut";
    private readonly string thirdQuestionBAnswer = "20 minut";
    private readonly string thirdQuestionCAnswer = "25 minut";
    private readonly string thirdQuestionDAnswer = "30 minut";

    private readonly string fourthQuestionAAnswer = "15 milionów bloków";
    private readonly string fourthQuestionBAnswer = "20 milionów bloków";
    private readonly string fourthQuestionCAnswer = "30 milionów bloków";
    private readonly string fourthQuestionDAnswer = "40 milionów bloków";

    private readonly string fifthQuestionAAnswer = "100";
    private readonly string fifthQuestionBAnswer = "111";
    private readonly string fifthQuestionCAnswer = "110";
    private readonly string fifthQuestionDAnswer = "123";

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
        NormalQuestionMethod(secondQuestionAAnswer, secondQuestionBAnswer, secondQuestionCAnswer, secondQuestionDAnswer, secondQuestionDAnswer, secondQuestionPoints, question: secondQuestion);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionBAnswer, thirdQuestionPoints, question: thirdQuestion);
    }
    public void FourthQuestion()
    {
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionCAnswer, fourthQuestionPoints, question: fourthQuestion);
    }
    public void FifthQuestion()
    {
        NormalQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionCAnswer, fifthQuestionPoints, question: fifthQuestion);
    }

}
