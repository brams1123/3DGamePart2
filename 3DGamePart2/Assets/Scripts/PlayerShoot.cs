using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public GameObject bullet;
    public float delayTime = 8;


    private float counter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.Mouse0) && counter > delayTime)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            counter = 0;
        }
        counter += Time.deltaTime;
	
	}
}
