using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,10)]
    [SerializeField]string question = "Enter new Question";
    [SerializeField]string[] answers = new string[4];
    [SerializeField]int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswerIndex(int index)
    {
        return answers[index];
    }


}
