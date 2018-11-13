using System.Collections;
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
            Destroy(other.gameObject);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
