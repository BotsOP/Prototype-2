using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public Text scoreText;
    public int scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreBoard.ToString();
    }

    public void scoreBoardProgress(int progress)
    {
        scoreBoard = scoreBoard + progress;
    }
}
