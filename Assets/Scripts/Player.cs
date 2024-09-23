using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Character")]
    [SerializeField] Animator playerAnimator;
    //[SerializeField] QuestionSO question;
    Quiz quiz;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CorrectAnim()
    {
        if(quiz.correct == true)
        {
            playerAnimator.SetBool("Correct", true);
        }
        else
        {
            playerAnimator.SetBool("Correct", false);
        }
    }
}
