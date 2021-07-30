using UnityEngine;
using UnityEngine.UI;

public class DeteksiSampah : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

    // Use this for initialization
    void Start()
    {
        // assign the MediaPlayerBenar audio
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        MediaPlayerBenar.clip = audioBenar;

        // assign the MediaPlayerSalah audio
        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audioSalah;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // if trash bin detect the collider of true trash as target
        if (collision.tag.Equals(nameTag))
        {
            // add score by 10
            Data.score += 10;

            // display the textScore as progress
            textScore.text = Data.score.ToString();

            // destroy the trash
            Destroy(collision.gameObject);

            // play the MediaPlayerBenar audio
            MediaPlayerBenar.Play();
        }

        // if trash bin detect the collider of false trash
        else
        {
            // substract score by 15
            Data.score -= 15;

            // display the textScore as progress
            textScore.text = Data.score.ToString();

            // destroy the trash
            Destroy(collision.gameObject);

            // play the MediaPlayerSalah audio
            MediaPlayerSalah.Play();
        }
    }
}