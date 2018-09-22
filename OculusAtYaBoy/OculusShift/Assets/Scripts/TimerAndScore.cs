using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerAndScore : MonoBehaviour {

    public Text text;
    public GameObject scorer;
    public GameObject timer;

    public void Update()
    {
        text.text = "Score: " + scorer.GetComponent<ScoreStreak>().score.ToString() + " Time: " + timer.GetComponent<GameEndTimer>().seconds.ToString() + "/100";
    }
}