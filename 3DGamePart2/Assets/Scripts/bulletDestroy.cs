using UnityEngine;
using System.Collections;

public class bulletDestroy : MonoBehaviour
{

    // Use this for initialization
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "bullet")
        {

            Destroy(col.gameObject);
            
        }
    }

    void upDate()
    {

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
    
