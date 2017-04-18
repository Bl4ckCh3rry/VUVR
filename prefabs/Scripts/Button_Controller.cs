using UnityEngine;
using System.Collections;

public class Button_Controller : MonoBehaviour {

    public GameObject openDoor;
    public bool isEntered;
	// Use this for initialization
	void Start () {
        isEntered = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isEntered)
        {
            if (openDoor.transform.position.y < 12.5)
                openDoor.transform.Translate(0, 10 * Time.deltaTime, 0);
            else
                isEntered = false; 
        }
	}

    void OnTriggerEnter(Collider other)
    {    
        if (other.gameObject.name == "FPSController" && openDoor.transform.position.y < 12.5)
        {
            isEntered = true;
            //openDoor.transform.Translate(new Vector3(0, (float)8.5, 0));
        }
    }
}
