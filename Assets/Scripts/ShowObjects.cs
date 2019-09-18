using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowObjects : MonoBehaviour {

    public GameObject[] objectsToShow;
	
    public void Show(){
        foreach (GameObject objectToShow in objectsToShow){
            objectToShow.SetActive(true);
        }
    }
}
