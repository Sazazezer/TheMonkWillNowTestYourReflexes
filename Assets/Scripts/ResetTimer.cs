using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResetTimer : MonoBehaviour {

    public int difficultyLevel = 1;
    private float duration = 2f;
    public UnityEvent onTimerEnd = new UnityEvent();

    public void StartTimer() {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {      
        yield return new WaitForSeconds(duration);
        onTimerEnd.Invoke();
    }
}
