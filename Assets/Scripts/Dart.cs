using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dart : MonoBehaviour
{
    public AudioClip shootSFX;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DartBoard")
        {
            Destroy(this.GetComponent<MeshCollider>());
            Destroy(this.GetComponent<Rigidbody>());
            //this.GetComponent<Animation>().Play("moving_board");
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
       // if (other.gameObject.tag == "audio_play_trigger")
        {
            
            if (shootSFX)
            {
                if (this.GetComponent<AudioSource>())
                { // the projectile has an AudioSource component
                  // play the sound clip through the AudioSource component on the gameobject.
                  // note: The audio will travel with the gameobject.   
                    this.GetComponent<AudioSource>().PlayOneShot(shootSFX);
                }
                else
                {
                    // dynamically create a new gameObject with an AudioSource
                    // this automatically destroys itself once the audio is done
                    AudioSource.PlayClipAtPoint(shootSFX, this.transform.position);
                }
            }
        }
    }
}
