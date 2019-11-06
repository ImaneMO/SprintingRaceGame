using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField]
    public TMP_Text text;
    public TMP_Text text1;
    public TMP_Text text2;


    int score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore (int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
        text1.text =  score.ToString();
        text2.text = score.ToString();

    }
}
