using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestWin : MonoBehaviour {

    public UnityEvent onWin = new UnityEvent();
    public UnityEvent onLose = new UnityEvent();
    public int winTest;
    public int winValue;

    public void Test(){
        winTest = GameObject.Find("MonkFace").GetComponent<PlayRandomSound>().soundLastPlayed;
        if(winValue == winTest){
                onWin.Invoke();
                winTest=-1;
            } else {
                onLose.Invoke();
            }
    }
}