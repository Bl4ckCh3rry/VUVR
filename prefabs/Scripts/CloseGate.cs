using UnityEngine;
using System.Collections;

public class CloseGate : MonoBehaviour {

    public GameObject openDoor;
    public bool isExited;
    int wait;
	// Use this for initialization
	void Start () {
        isExited = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isExited)
        {
            if (openDoor.transform.position.y > 5)
                openDoor.transform.Translate(0, -10 * Time.deltaTime, 0);
            else
                isExited = false;
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController" && openDoor.transform.position.y >= 12.5)
        {
            isExited = true;
        }
    }
}
