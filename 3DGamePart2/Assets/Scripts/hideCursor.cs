using UnityEngine;
using System.Collections;

public class hideCursor : MonoBehaviour {
    bool Locked;
	// Use this for initialization
	void Start () {

        CursorLock(true);
	
	}

    void CursorLock(bool Locked)
    {
        this.Locked = Locked;
        Screen.lockCursor = Locked;
        Cursor.visible = !Locked;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
            CursorLock(!Locked);
	
	}
}
