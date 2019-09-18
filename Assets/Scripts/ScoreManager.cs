using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text text;
    public int score;

    public void IncreaseScore(){
        score++;
        text.text = score.ToString();
    }

    public void ResetScore(){
        score = 0;
        text.text = score.ToString();
    }
}
