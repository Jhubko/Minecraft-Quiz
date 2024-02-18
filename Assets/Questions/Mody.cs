using UnityEngine;

public class Mody : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Z czego robi się portal do nieba w modzie Aether?";
    private readonly string secondQuestion = "Która modyfikacja wprowadza temperaturę oraz pragnienie?";
    private readonly string thirdQuestion = "Ile powstało wersji Pingwin Packa?";
    private readonly string fourthQuestion = "Jaka jest poprawna kolejność bossów w modzie Twilight Forest?";
    private readonly string fifthQuestion = "Kto jest twórcą moda Mo' Creatures?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "Glowstone";
    private readonly string firstQuestionBAnswer = "Bloków diamentu";
    private readonly string firstQuestionCAnswer = "Soulsand";
    private readonly string firstQuestionDAnswer = "Bloków złota";

    private readonly string secondQuestionAAnswer = "Tough As Nails";
    private readonly string secondQuestionBAnswer = "Spice Of Life";
    private readonly string secondQuestionCAnswer = "Pam's Harvestcraft";
    private readonly string secondQuestionDAnswer = "Tinker's Construct";

    private readonly string thirdQuestionAAnswer = "3";
    private readonly string thirdQuestionBAnswer = "4";
    private readonly string thirdQuestionCAnswer = "5";
    private readonly string thirdQuestionDAnswer = "6";

    private readonly string fourthQuestionAAnswer = "Naga - Twilight Litch - Minoshroom - Hydra - Ur-Ghast - Knight Phantom - Alpha Yeti - Troll Cave - Snow Queen - Kobold";
    private readonly string fourthQuestionBAnswer = "Naga - Twilight Litch - Minoshroom - Hydra - Knight Phantom - Ur-Ghast - Alpha Yeti - Snow Queen - Troll Cave - Kobold";
    private readonly string fourthQuestionCAnswer = "Naga - Twilight Litch - Hydra - Minoshroom - Knight Phantom - Ur-Ghast - Snow Queen - Alpha Yeti - Troll Cave - Kobold";
    private readonly string fourthQuestionDAnswer = "Naga - Minoshroom - Twilight Litch - Knight Phantom - Hydra - Alpha Yeti - Ur-Ghast - Troll Cave - Snow Queen - Kobold";

    private readonly string fifthQuestionAAnswer = "DrZharky";
    private readonly string fifthQuestionBAnswer = "Marglyph";
    private readonly string fifthQuestionCAnswer = "mezz";
    private readonly string fifthQuestionDAnswer = "Benimatic";

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
        NormalQuestionMethod(secondQuestionAAnswer, secondQuestionBAnswer, secondQuestionCAnswer, secondQuestionDAnswer, secondQuestionAAnswer, secondQuestionPoints, question: secondQuestion);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionCAnswer, thirdQuestionPoints, question: thirdQuestion);
    }
    public void FourthQuestion()
    {
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionBAnswer, fourthQuestionPoints, question: fourthQuestion);
    }
    public void FifthQuestion()
    {
        NormalQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionAAnswer, fifthQuestionPoints, question: fifthQuestion);
    }

}
