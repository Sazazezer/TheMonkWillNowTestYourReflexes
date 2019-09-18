using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour {

    public float clock = 0f;
    public bool clockStarter = false;
    public float bestTime = 1000000000f;
    public Text clockText;
    public Text bestTimeText;
    public string clockTime = "00:00";

	// Use this for initialization
	void Start () {
        //PlayerPrefs.SetString("BestTime", "0ms");
        bestTimeText.text =PlayerPrefs.GetString("BestTime", "0ms");
        
	}

    void Update(){
        if(clockStarter == true){
            clock++;  
            clockTime = FormatTime(clock);
            clockText.text = clockTime + "ms";
        }
        
    }
	
    public void StartClock(){
        clockStarter = true;
    }

    public void StopClock(){
        clockStarter = false;
        RecordBestTime();
        clock = 0;
        clockTime = FormatTime(clock);
        clockText.text = clockTime + "ms";
    }

    public void ResetClock(){
        clockStarter = false;
        clock = 0;
        clockTime = FormatTime(clock);
        clockText.text = clockTime + "ms";
    }

    public void RecordBestTime(){
        Debug.Log("Recording");
        if (bestTime > clock){
            Debug.Log("It's a record!");
            bestTime = clock;
            clockTime = FormatTime(bestTime);
            bestTimeText.text = clockTime + "ms";
            PlayerPrefs.SetString("BestTime", bestTimeText.text);
        }
    }

    public string FormatTime( float _time ){
        int minutes = (int) _time / 60000 ;
        int seconds = (int) _time / 1000 - 60 * minutes;
        int milliseconds = (int) _time - minutes * 60000 - 1000 * seconds;
        return string.Format("{0:0}", milliseconds);
    }


}
