using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // add this line to use the UI Text component

public class Pickup : MonoBehaviour
{
    public int count; // variable to store the number of pick ups
    public Text countText; // reference to the UI Text component

    void Start()
    {
        count = 0; // set the initial count to 0
        SetCountText(); // update the UI Text with the current count
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            Debug.Log("Collided");
            other.gameObject.SetActive(false); // deactivate the pick up object
            count = count + 1; // increment the count by 1
            SetCountText(); // update the UI Text with the current count
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString(); // update the UI Text with the current count
    }
}
