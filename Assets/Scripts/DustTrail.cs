using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrail;

    private void OnCollisionEnter2D(Collision2D other)
    {
        //start particle
        dustTrail.Play();
        if (other.gameObject.tag == "Level")
        {
            dustTrail.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        //stop particle
        if (other.gameObject.tag == "Level")
        {
        dustTrail.Stop();
        }
    }
}
