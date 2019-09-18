using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideObjects : MonoBehaviour {

    public GameObject[] objectsToHide;
	
    public void Hide(){
        foreach (GameObject objectToHide in objectsToHide){
            objectToHide.SetActive(false);
        }
    }
}
