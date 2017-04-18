using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public GameObject lazyRotate;
    public Transform teleportTo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        { 
            other.transform.position = teleportTo.transform.position;
            lazyRotate.transform.Rotate(0,90,0);
        }
    }
}
