using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager : MonoBehaviour
{
    public AudioClip explosionsound ,BulletSound;
    void playExplosionSound()
    {
        GetComponent<AudioSource>().PlayOneShot(explosionsound);
    }
    void playBulletSound()
    {
        GetComponent<AudioSource>().PlayOneShot(BulletSound);
    }
}
