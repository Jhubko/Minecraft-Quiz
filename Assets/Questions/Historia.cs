using UnityEngine;

public class Historia : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Jak nazywa się twórca Minecraft?";
    private readonly string secondQuestion = "W jakim roku wyszedł Minecraft?";
    private readonly string thirdQuestion = "Jak nazywała się pierwsza wersja Minecraft?";
    private readonly string fourthQuestion = "Za ile Microsoft kupił Mojang?";
    private readonly string fifthQuestion = "Jaka była pierwsza nazwa Minecraft";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "Jens Bergensten";
    private readonly string firstQuestionBAnswer = "Markus Persson";
    private readonly string firstQuestionCAnswer = "Andrew Spinks";
    private readonly string firstQuestionDAnswer = "David Baszucki";

    private readonly string secondQuestionAAnswer = "2011";
    private readonly string secondQuestionBAnswer = "2010";
    private readonly string secondQuestionCAnswer = "2012";
    private readonly string secondQuestionDAnswer = "2009";

    private readonly string thirdQuestionAAnswer = "Alpha";
    private readonly string thirdQuestionBAnswer = "Infdev";
    private readonly string thirdQuestionCAnswer = "Classic";
    private readonly string thirdQuestionDAnswer = "Indev";

    private readonly string fourthQuestionAAnswer = "5 miliardów dolarów";
    private readonly string fourthQuestionBAnswer = "2 miliardy dolarów";
    private readonly string fourthQuestionCAnswer = "2.5 miliarda dolarów";
    private readonly string fourthQuestionDAnswer = "1.5 miliarda dolarów";

    private readonly string fifthQuestionAAnswer = "Minecraft";
    private readonly string fifthQuestionBAnswer = "Cave Game";
    private readonly string fifthQuestionCAnswer = "Mine Game";
    private readonly string fifthQuestionDAnswer = "Craft Game";

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
        NormalQuestionMethod(secondQuestionAAnswer, secondQuestionBAnswer, secondQuestionCAnswer, secondQuestionDAnswer, secondQuestionAAnswer, secondQuestionPoints, question: secondQuestion);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionCAnswer, thirdQuestionPoints, question: thirdQuestion);
    }
    public void FourthQuestion()
    {
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionCAnswer, fourthQuestionPoints, question: fourthQuestion);
    }
    public void FifthQuestion()
    {
        NormalQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionBAnswer, fifthQuestionPoints, question: fifthQuestion);
    }

}
