using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{

    public Transform player;
    public int moveSpeed;
    //public float playerDistance;
     public int rotationSpeed;

    void Start()
    {
        player = GameObject.Find("Player").transform;
        
    }

    void Update()
    {    
			if (player != null) 
			{

                Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            //Move Towards Target
            transform.position += (player.position - transform.position).normalized 
					* moveSpeed * Time.deltaTime;
			}
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}
