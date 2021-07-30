using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keluar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if player input escape button
        if (Input.GetKeyUp(KeyCode.Escape))

            // run application quit
            Application.Quit();
    }
}
