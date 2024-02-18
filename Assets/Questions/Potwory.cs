using UnityEngine;

public class Potwory : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Czego boją się creepery?";
    private readonly string secondQuestion = "Co dropił zombie zanim wprowadzono zgniłe mięso? ";
    private readonly string thirdQuestion = "Przez ile dni gracz musi nie spać żeby zaatakował go Phantom?";
    private readonly string fourthQuestion = "Ile punktów życia ma enderdragon?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "Psów";
    private readonly string firstQuestionBAnswer = "Lisów";
    private readonly string firstQuestionCAnswer = "Papóg";
    private readonly string firstQuestionDAnswer = "Kotów";

    private readonly string secondQuestionAAnswer = "Piórko";
    private readonly string secondQuestionBAnswer = "Steak";
    private readonly string secondQuestionCAnswer = "Żelazo";
    private readonly string secondQuestionDAnswer = "Skórę";

    private readonly string thirdQuestionAAnswer = "3";
    private readonly string thirdQuestionBAnswer = "4";
    private readonly string thirdQuestionCAnswer = "7";
    private readonly string thirdQuestionDAnswer = "5";

    private readonly string fourthQuestionAAnswer = "500";
    private readonly string fourthQuestionBAnswer = "600";
    private readonly string fourthQuestionCAnswer = "200";
    private readonly string fourthQuestionDAnswer = "400";

    private readonly string fifthQuestionAAnswer = "Phantom";
    private readonly string fifthQuestionBAnswer = "Shulker";
    private readonly string fifthQuestionCAnswer = "Blaze";
    private readonly string fifthQuestionDAnswer = "SilverFish";

    public AudioClip fifthQuestionClip;

    private int firstQuestionPoints = 100;
    private int secondQuestionPoints = 150;
    private int thirdQuestionPoints = 200;
    private int fourthQuestionPoints = 250;
    private int fifthQuestionPoints = 300;


    public void FirstQuestion()
    {
        NormalQuestionMethod(firstQuestionAAnswer, firstQuestionBAnswer, firstQuestionCAnswer, firstQuestionDAnswer, firstQuestionDAnswer, firstQuestionPoints, question: firstQuestion);        
    }
    public void SecondQuestion()
    {
        NormalQuestionMethod(secondQuestionAAnswer, secondQuestionBAnswer, secondQuestionCAnswer, secondQuestionDAnswer, secondQuestionAAnswer, secondQuestionPoints, question: secondQuestion);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionAAnswer, thirdQuestionPoints, question: thirdQuestion);
    }
    public void FourthQuestion()
    {
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionCAnswer, fourthQuestionPoints, question: fourthQuestion);;
    }
    public void FifthQuestion()
    {
        MusicQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionAAnswer, fifthQuestionPoints, fifthQuestionClip);
    }

}
