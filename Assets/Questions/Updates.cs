using UnityEngine;

public class Updates : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "W jakiej wersji Minecrafta dodano łóżka?";
    private readonly string secondQuestion = "W jakiej wersji Minecrafta dodano pasek głodu?";
    private readonly string thirdQuestion = "W jakiej wersji Minecrafta po raz pierwszy usunięto Herobrine?";
    private readonly string fourthQuestion = "Jaka była wiadomość przed wersją 1.0, gdy gracz zgniął przez strzałę z dozownika?";
    private readonly string fifthQuestion = "W jakiej wersji Minecrafta dodano patrole Villagerów?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "1.3";
    private readonly string firstQuestionBAnswer = "1.2";
    private readonly string firstQuestionCAnswer = "1.4";
    private readonly string firstQuestionDAnswer = "1.1";

    private readonly string secondQuestionAAnswer = "1.7";
    private readonly string secondQuestionBAnswer = "1.8";
    private readonly string secondQuestionCAnswer = "1.9";
    private readonly string secondQuestionDAnswer = "1.6";

    private readonly string thirdQuestionAAnswer = "Beta 1.6.6";
    private readonly string thirdQuestionBAnswer = "1.0.0";
    private readonly string thirdQuestionCAnswer = "Beta 1.8";
    private readonly string thirdQuestionDAnswer = "1.6";

    private readonly string fourthQuestionAAnswer = "[gracz] został zabity przez: dozownik";
    private readonly string fourthQuestionBAnswer = "[gracz] umarł";
    private readonly string fourthQuestionCAnswer = "[gracz] został zastrzelony przez Herobrine";
    private readonly string fourthQuestionDAnswer = "[gracz] został zastrzelony przez strzałę";

    private readonly string fifthQuestionAAnswer = "1.15";
    private readonly string fifthQuestionBAnswer = "1.13";
    private readonly string fifthQuestionCAnswer = "1.14";
    private readonly string fifthQuestionDAnswer = "1.16";


    private int firstQuestionPoints = 100;
    private int secondQuestionPoints = 150;
    private int thirdQuestionPoints = 200;
    private int fourthQuestionPoints = 250;
    private int fifthQuestionPoints = 300;


    public void FirstQuestion()
    {
        //For Normal question
        NormalQuestionMethod(firstQuestionAAnswer, firstQuestionBAnswer, firstQuestionCAnswer, firstQuestionDAnswer, firstQuestionAAnswer, firstQuestionPoints, question: firstQuestion);
        
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
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionCAnswer, fourthQuestionPoints, question: fourthQuestion);
    }
    public void FifthQuestion()
    {
        NormalQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionCAnswer, fifthQuestionPoints, question: fifthQuestion);
    }

}
