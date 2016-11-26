using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {

    public float max_Time = 100f;
    public float cur_Time = 0f;
    public GameObject timeBar;

	// Use this for initialization
	void Start () {
        cur_Time = max_Time;
        InvokeRepeating("decreasetime", 1f, 1f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void decreasetime()
    {
        cur_Time -= 1f;
        float calc_Time = cur_Time / max_Time;
        SetHealthBar(calc_Time);
        
    }

    public void SetHealthBar(float myHealth)
    {
        timeBar.transform.localScale = new Vector3(myHealth, timeBar.transform.localScale.y, timeBar.transform.localScale.z);
    }
}
