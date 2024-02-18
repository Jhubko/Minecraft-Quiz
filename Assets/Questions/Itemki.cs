using UnityEngine;

public class Itemki : CategoryTemplate
{
    //Questions
    private readonly string firstQuestion = "Jaka jest najrzadsza ruda w MC?";
    private readonly string secondQuestion = "Jak zdobyć płyty (poza skrzynkami)?";
    private readonly string thirdQuestion = "Ile kawałków ma ciasto?";
    private readonly string fourthQuestion = "Na ile starcza diamentowy kilof z enchantem ubreaking 3?";

    //Answers for A/B/C/D questions 
    private readonly string firstQuestionAAnswer = "Deepslate Emerald";
    private readonly string firstQuestionBAnswer = "Deepslate Węgiel";
    private readonly string firstQuestionCAnswer = "Netherite";
    private readonly string firstQuestionDAnswer = "Deepslate Diament";

    private readonly string secondQuestionAAnswer = "Creeper musi zabić szkieleta";
    private readonly string secondQuestionBAnswer = "Naładowany creeper musi zabić szkieleta";
    private readonly string secondQuestionCAnswer = "Szkielet musi zabić creepera";
    private readonly string secondQuestionDAnswer = "Szkielet musi zabić naładowanego creepera";

    private readonly string thirdQuestionAAnswer = "4";
    private readonly string thirdQuestionBAnswer = "5";
    private readonly string thirdQuestionCAnswer = "6";
    private readonly string thirdQuestionDAnswer = "7";

    private readonly string fourthQuestionAAnswer = "ok. 2,564 urzyć";
    private readonly string fourthQuestionBAnswer = "ok. 5,063 urzyć";
    private readonly string fourthQuestionCAnswer = "ok. 5,948 urzyć";
    private readonly string fourthQuestionDAnswer = "ok. 6,144 urzyć";

    private readonly string fifthQuestionAAnswer = "Chrip";
    private readonly string fifthQuestionBAnswer = "Blocks";
    private readonly string fifthQuestionCAnswer = "Mall";
    private readonly string fifthQuestionDAnswer = "Mellohi";

    public AudioClip fifthQuestionClip;

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
        NormalQuestionMethod(secondQuestionAAnswer, secondQuestionBAnswer, secondQuestionCAnswer, secondQuestionDAnswer, secondQuestionCAnswer, secondQuestionPoints, question: secondQuestion);
    }
    public void ThirdQuestion()
    {
        NormalQuestionMethod(thirdQuestionAAnswer, thirdQuestionBAnswer, thirdQuestionCAnswer, thirdQuestionDAnswer, thirdQuestionDAnswer, thirdQuestionPoints, question: thirdQuestion);
    }
    public void FourthQuestion()
    {
        NormalQuestionMethod(fourthQuestionAAnswer, fourthQuestionBAnswer, fourthQuestionCAnswer, fourthQuestionDAnswer, fourthQuestionDAnswer, fourthQuestionPoints, question: fourthQuestion);

    }
    public void FifthQuestion()
    {
        MusicQuestionMethod(fifthQuestionAAnswer, fifthQuestionBAnswer, fifthQuestionCAnswer, fifthQuestionDAnswer, fifthQuestionAAnswer, fifthQuestionPoints, fifthQuestionClip);
    }

}
