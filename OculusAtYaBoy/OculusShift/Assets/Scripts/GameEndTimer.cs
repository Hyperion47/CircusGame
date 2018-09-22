using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndTimer : MonoBehaviour {

    public int seconds = 0;

    public void Start()
    {
        StartCoroutine(ActivateOnTimer());
    }

    public void Update()
    {
        BackToStart();
    }

    public void BackToStart()
    {
        if (seconds >= 100)
        {
            SceneManager.LoadScene("StartScreen");
        }
    }

    IEnumerator ActivateOnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            //stuff that happens every second happens here:
            seconds++;
        }
    }

}
