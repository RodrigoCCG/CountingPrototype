using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDestroyer : MonoBehaviour
{
    [SerializeField] ParticleSystem splatter;   

    private void OnTriggerEnter(Collider other)
    {
        //Destroy Fruit
        if(other.gameObject.CompareTag("Fruit")){
            splatter.transform.position = other.transform.position;
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().Play(0);
            splatter.Play();
            Destroy(other.gameObject);
        }
    }
}
