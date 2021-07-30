using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        // the timer will increase by a fraction of a second
        timer += Time.deltaTime;

        // if timer still higher than 2, 
        if (timer > 2)
        {
            // set score in Data class into 0
            Data.score = 0;

            // open the Gameplay scene
            SceneManager.LoadScene("Gameplay");
        }
    }
}