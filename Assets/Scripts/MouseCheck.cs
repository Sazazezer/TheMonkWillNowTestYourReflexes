using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseCheck : MonoBehaviour {

    public UnityEvent onMouseHover = new UnityEvent();
    public UnityEvent onMouseNotHover = new UnityEvent();
    public bool mouseSwitch = false;

    void OnMouseOver(){
        //If your mouse hovers over the GameObject with the script attached, output this message
        if (mouseSwitch == false){
            Debug.Log("Mouse is on GameObject.");
            mouseSwitch = true;
            onMouseHover.Invoke();
        }
    }

    void OnMouseExit(){
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
        mouseSwitch = false;
        onMouseNotHover.Invoke();
        
    }
}
