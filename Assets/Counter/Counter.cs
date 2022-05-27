using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int Count = 0;

    private void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Fruit")){
            //Increase score as player picks up fruit.
            Count += 1;
            CounterText.text = "Count : " + Count;
        }
    }
}
