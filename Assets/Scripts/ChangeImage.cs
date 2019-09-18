using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour {

    public Sprite[] sprite;
    private SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Change(int _imageNumber){
        spriteRenderer.sprite = sprite[_imageNumber];
    }
}
