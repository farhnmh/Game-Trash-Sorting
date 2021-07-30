using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AturSkor : MonoBehaviour
{
    public bool firstPlay = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if firstPlay is true and the score higher than 0
        if (firstPlay && Data.score > 0)

            // set firstPlay into false
            firstPlay = false;

        // if firstPlay is false and the score less than equal to 0
        if (!firstPlay && Data.score <= 0)

            // open the GameOver scene
            SceneManager.LoadScene("GameOver");
    }
}
