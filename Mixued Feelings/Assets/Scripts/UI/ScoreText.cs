using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    
    private int score = 0;
    public int Score {
        get { return score; }
        set {
            score = value;
            GetComponent<TMP_Text>().text = "Score: " + score;
        }
    }

    void Start() {
        Score = 0;
    }

}
