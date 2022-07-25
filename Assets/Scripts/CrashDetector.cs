using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool gameOver = false;

    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Level" & !gameOver)
        {
            gameOver = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene",loadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
        gameOver = false;
    }

}
