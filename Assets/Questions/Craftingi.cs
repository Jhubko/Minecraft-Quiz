using UnityEngine;

public class Craftingi : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Ile buraków potrzebnych jest do barszczu?";
    private readonly string secondQuestion = "Co to za crafting?";
    private readonly string thirdQuestion = "Z czego craftuje się cement?";
    private readonly string fourthQuestion = "Ile różnych rodzajów strzał może być wycraftowane?";
    private readonly string fifthQuestion = "Z czego craftuje się utwardzone błoto?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "6";
    private readonly string firstQuestionBAnswer = "4";
    private readonly string firstQuestionCAnswer = "3";
    private readonly string firstQuestionDAnswer = "2";

    private readonly string secondQuestionAAnswer = "Siodło";
    private readonly string secondQuestionBAnswer = "Zbroja dla konia";
    private readonly string secondQuestionCAnswer = "Sakwa";
    private readonly string secondQuestionDAnswer = "Elytra";

    private readonly string thirdQuestionAAnswer = "1x barwnik + 4x piasek + 4x glina";
    private readonly string thirdQuestionBAnswer = "1x barwnik + 4x piasek + 4x żwir";
    private readonly string thirdQuestionCAnswer = "1x barwnik + 4x dirt + 4x żwir";
    private readonly string thirdQuestionDAnswer = "1x barwnik + 4x dirt + 4x piasek";

    private readonly string fourthQuestionAAnswer = "17";
    private readonly string fourthQuestionBAnswer = "16";
    private readonly string fourthQuestionCAnswer = "12";
    private readonly string fourthQuestionDAnswer = "10";

    private readonly string fifthQuestionAAnswer = "Błoto + Namorzynowe korzenie";
    private readonly string fifthQuestionBAnswer = "Błoto + Piasek";
    private readonly string fifthQuestionCAnswer = "Błoto + Pszenica";
    private readonly string fifthQuestionDAnswer = "Błoto + Glina";

    public Sprite secondQuestionImage;

    private int firstQuestionPoints = 100;
    private int secondQuestionPoints = 150;
    private int thirdQuestionPoints = 200;
    private int fourthQuestionPoints = 250;
    private int fifthQuestionPoints = 300;


    public void FirstQuestion()
    {
        NormalQuestionMethod(firstQuestionAAnswer, firstQuestionBAnswer, firstQuestionCAnswer, firstQuestionDAnswer, firstQuestionAAnswer, firstQuestionPoints, question: firstQuestion);     
    }
    public void SecondQuestion()
    {
        NormalQuestionMethod(secondQuestionAAnswer, secondQuestionBAnswer, secondQuestionCAnswer, secondQuestionDAnswer, secondQuestionBAnswer, secondQuestionPoints, question: secondQuestion, image: secondQuestionImage);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionBAnswer, thirdQuestionPoints, question: thirdQuestion);

    }
    public void FourthQuestion()
    {
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionBAnswer, fourthQuestionPoints, question: fourthQuestion);

    }
    public void FifthQuestion()
    {
        NormalQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionCAnswer, fifthQuestionPoints, question: fifthQuestion);
    }

}
