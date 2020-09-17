using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListener : Duplicate
{
    public Button someButton;
    public GameObject car1;
    public SpriteRenderer sr1;
    public void OnEnable()
    {
        
        //Register Button Events
        someButton.onClick.AddListener(() => buttonCallBack(instantiated, 88));
        sr1 = instantiated.GetComponent<SpriteRenderer>();
    }

    private void buttonCallBack(GameObject instantiated, int v)
    {
        sr1 = instantiated.GetComponent<SpriteRenderer>();
    }
    void OnDisable()
    {
        //Un-Register Button Events
        someButton.onClick.RemoveAllListeners();
    }
}
