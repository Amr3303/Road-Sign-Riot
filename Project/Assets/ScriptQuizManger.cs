using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptQuizManger : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionText;

    private void Start()
    {
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++) 
        {
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

        }
    }

    void generateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);
        QuestionText.text = QnA[currentQuestion].Question;
    }
}
