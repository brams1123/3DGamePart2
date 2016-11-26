using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyDestroy : MonoBehaviour {

   
    private int killCount;
    public Text CountText;

    void Start()
    {
        killCount = 0;
        SetKillText();
    }

    public void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            
            Destroy(col.gameObject);
            killCount = killCount + 1;
            SetKillText ();

        }

    }

    void SetKillText ()
    {
        CountText.text = "Total Kills:" + killCount.ToString();
    }
}
