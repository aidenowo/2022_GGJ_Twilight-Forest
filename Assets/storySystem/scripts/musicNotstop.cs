using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicNotstop : MonoBehaviour
{
    public AudioClip[] audios;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Storyscene1")
        {

            this.GetComponent<AudioSource>().clip = audios[0];
            this.GetComponent<AudioSource>().Play();
        }
        if (SceneManager.GetActiveScene().name == "Storyscene1")
        {

            this.GetComponent<AudioSource>().clip = audios[0];
            this.GetComponent<AudioSource>().Play();
        }
        if (SceneManager.GetActiveScene().name == "Storyscene1")
        {

            this.GetComponent<AudioSource>().clip = audios[0];
            this.GetComponent<AudioSource>().Play();
        }
        if (SceneManager.GetActiveScene().name == "Storyscene1")
        {

            this.GetComponent<AudioSource>().clip = audios[0];
            this.GetComponent<AudioSource>().Play();
        }
        if (SceneManager.GetActiveScene().name == "Storyscene1")
        {

            this.GetComponent<AudioSource>().clip = audios[0];
            this.GetComponent<AudioSource>().Play();
        }
    }
}