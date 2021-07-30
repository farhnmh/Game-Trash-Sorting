using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekSampah;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // the timer will increase by a fraction of a second
        timer += Time.deltaTime;

        // if timer higher than jeda
        if (timer > jeda)
        {
            // int that handle random value of objekSampah type (organic/anorganic)
            int random = Random.Range(0, obyekSampah.Length);

            // function that spawn obyekSampah type with the first position and rotation
            Instantiate(obyekSampah[random], transform.position, transform.rotation);
            
            // set timer into 0
            timer = 0;
        }
    }
}