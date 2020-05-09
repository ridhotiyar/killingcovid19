using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class timecount : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerText;
    private float startTime;
    private bool finnished= false;
    public static string finalTime;

    void Start ()
    {
        startTime = Time.time;
    }

    void Update ()
    {
        if(finnished)
            return;

        float t = Time.time - startTime;

        int minutes = ((int) t /60);
        int seconds = ((int)t % 60);
        int seconds100Int = (int)(Mathf.Floor((t - (seconds + minutes*60)) *100));

        string minutesA = (minutes < 10) ? "0" + minutes : minutes.ToString();
        string secondsA = (seconds < 10) ? "0" + seconds : seconds.ToString();
        string seconds100IntA = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();

        timerText.text= minutesA + ":" + secondsA + ":" + seconds100IntA;
        finalTime = timerText.text;
    }

    public void Finnish ()
    {
        finnished = true;
    }
    //this code is to show the basic counter
    // public float timeStart = 0;
    // public Text textBox;

    // void Start()
    // {
    //     textBox.text = timeStart.ToString();   
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     timeStart += Time.deltaTime;
    //     textBox.text = Mathf.Round(timeStart).ToString();
    // }
    
    
    //this code is to show current time
    // private Text textClock;
    // void Start()
    // {
    //     textClock = GetComponent<Text>();
    // }

    // void Update()
    // {
    //     DateTime time = DateTime.Now;

    //     string hour = LeadingZero( time.Hour );
    //     string minute = LeadingZero( time.Minute );
    //     string second = LeadingZero( time.Second );
    //     textClock.text = hour + ":" + minute + ":" + second;
    // }

    // string LeadingZero(int n)
    // {
    //     return n.ToString().PadLeft(2, '0');
    // }
}
