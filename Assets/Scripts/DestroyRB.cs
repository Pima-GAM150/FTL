﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyRB : MonoBehaviour {

    public Text countText;
    public Text winText;
    private int count;

    private void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Followers Saved: " + count.ToString();
        if (count >= 10)
        {
            winText.text = "YOU ARE A HERO";
        }
    }
}
