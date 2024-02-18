using UnityEngine;

public class Potki : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Jaki jest bazowy składnik większości mikstur?";
    private readonly string secondQuestion = "Jaki składnik jest potrzebny do stworzenia miotanej mikstury?";
    private readonly string thirdQuestion = "Jakie składniki są potrzebne do stworzenia mikstury odporności na ogień?";
    private readonly string fourthQuestion = "Jakie składniki potrzebne są do stworzenia mikstury osłabienia?";
    private readonly string fifthQuestion = "Z czego zrobić gęstą miksturę w Minecraft?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "Proch";
    private readonly string firstQuestionBAnswer = "Netherowa Brodawka";
    private readonly string firstQuestionCAnswer = "Oko pająka";
    private readonly string firstQuestionDAnswer = "Blaze Powder";

    private readonly string secondQuestionAAnswer = "Redstone";
    private readonly string secondQuestionBAnswer = "Proch";
    private readonly string secondQuestionCAnswer = "Glowstone";
    private readonly string secondQuestionDAnswer = "Cukier";

    private readonly string thirdQuestionAAnswer = "Netherowa Brodawka i Blaze Powder";
    private readonly string thirdQuestionBAnswer = "Netherowa Brodawka i Łza Ghasta";
    private readonly string thirdQuestionCAnswer = "Netherowa Brodawka i Błyszczący arbuz";
    private readonly string thirdQuestionDAnswer = "Netherowa Brodawka i Magma Cream";

    private readonly string fourthQuestionAAnswer = "Tylko oko pająka";
    private readonly string fourthQuestionBAnswer = "Netherowa Brodawka i oko pająka";
    private readonly string fourthQuestionCAnswer = "Tylko fermentowane oko pająka";
    private readonly string fourthQuestionDAnswer = "Netherowa Brodawka i fermentowane oko pająka";

    private readonly string fifthQuestionAAnswer = "Glowstone";
    private readonly string fifthQuestionBAnswer = "Redstone";
    private readonly string fifthQuestionCAnswer = "Królicza łapka";
    private readonly string fifthQuestionDAnswer = "Oko pająka";

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
        NormalQuestionMethod(secondQuestionAAnswer, secondQuestionBAnswer, secondQuestionCAnswer, secondQuestionDAnswer, secondQuestionBAnswer, secondQuestionPoints, question: secondQuestion);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionDAnswer, thirdQuestionPoints, question: thirdQuestion);

    }
    public void FourthQuestion()
    {
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionCAnswer, fourthQuestionPoints, question: fourthQuestion);

    }
    public void FifthQuestion()
    {
        NormalQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionAAnswer, fifthQuestionPoints, question: fifthQuestion);
    }

}
