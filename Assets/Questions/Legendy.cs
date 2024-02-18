using UnityEngine;

public class Legendy : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Kim rzekomo był Herobrine?";
    private readonly string secondQuestion = "Czy ceglane piramidy naturalnie występowały kiedykolwiek w Minecraft?";
    private readonly string thirdQuestion = "Co dropił Notch po zabiciu?";
    private readonly string fifthQuestion = "Jaki Seed był rzekomo nawiedzony?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "Kolegą Notcha";
    private readonly string firstQuestionBAnswer = "Ojcem Notcha";
    private readonly string firstQuestionCAnswer = "Bratem Notcha";
    private readonly string firstQuestionDAnswer = "Wujkiem Notcha";

    //Answers for true/false question
    private readonly string trueQuestionAnswer = "Prawda";

    private readonly string thirdQuestionAAnswer = "Jabłko";
    private readonly string thirdQuestionBAnswer = "Złote jabłko";
    private readonly string thirdQuestionCAnswer = "Enchantowane złote jabłko";
    private readonly string thirdQuestionDAnswer = "Diament";

    private readonly string fourthQuestionAAnswer = "Płyta 12";
    private readonly string fourthQuestionBAnswer = "Płyta 9";
    private readonly string fourthQuestionCAnswer = "Płyta 10";
    private readonly string fourthQuestionDAnswer = "Płyta 11";

    private readonly string fifthQuestionAAnswer = "1493028";
    private readonly string fifthQuestionBAnswer = "6666666";
    private readonly string fifthQuestionCAnswer = "2803941";
    private readonly string fifthQuestionDAnswer = "3028149";

    public AudioClip fourthQuestionClip;

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
        TrueFalseQuestionMethod(trueQuestionAnswer, secondQuestionPoints, question: secondQuestion);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionAAnswer, thirdQuestionPoints, question: thirdQuestion);
    }
    public void FourthQuestion()
    {
        MusicQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionDAnswer, fourthQuestionPoints, fourthQuestionClip);
    }
    public void FifthQuestion()
    {
        NormalQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionAAnswer, fifthQuestionPoints, question: fifthQuestion);
    }

}
