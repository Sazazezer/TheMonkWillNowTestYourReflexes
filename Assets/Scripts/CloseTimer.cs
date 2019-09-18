using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CloseTimer : MonoBehaviour {

    public int difficultyLevel = 1;
    public float duration = 5f;
    public UnityEvent onTimerEnd = new UnityEvent();

    public void CloseHandTimer() {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {      
        yield return new WaitForSeconds(duration);
        onTimerEnd.Invoke();
    }

    public void SetDuration(float _max){
        duration = Random.Range(1f,_max);
    }
}
