using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    public float targetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    public Transform Target;
    Rigidbody theRigidbody;
    Renderer myRender;

	// Use this for initialization
	void Start () {

        myRender = GetComponent<Renderer>();
        theRigidbody = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        targetDistance = Vector3.Distance(Target.position, transform.position);
        if(targetDistance<enemyLookDistance)
        {
            myRender.material.color=Color.yellow;
            lookAtPlayer();
            print("look at player Please:");
        }
        if(targetDistance<attackDistance)
        {
            attackPlease();
            print("Attack");
        }
	
	}

    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(Target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }

    void attackPlease()
    {
        theRigidbody.AddForce(transform.forward * enemyMovementSpeed);
    }
}
