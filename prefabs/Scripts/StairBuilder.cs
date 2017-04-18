using UnityEngine;
using System.Collections;

public class StairBuilder : MonoBehaviour
{
    GameObject stair;
    int i;
    bool stairUp,collided;
	// Use this for initialization
	void Start ()
    {
        i = 0;
        stairUp = true;
        collided = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (collided)
        {
            if (i == 100)
            {
                Destroy(this);
            }
            if (stairUp)
            {
                stair = GameObject.CreatePrimitive(PrimitiveType.Cube);
                stair.transform.localScale = new Vector3(1, (float).5, 8);
                stair.transform.position = transform.position + new Vector3((float).5 * i + 5, 0, 0);
                //stair = (GameObject)Instantiate(stair, transform.position + new Vector3((float).5 * i + 5, 0, 0), new Quaternion());
                stairUp = false;
            }
            if (!stairUp)
            {
                if (stair.transform.position.y < (float).25 * i)
                    stair.transform.Translate(new Vector3(0, i * Time.deltaTime, 0));
                else
                {
                    stair.transform.position = transform.position + new Vector3((float).5 * i + 5, (float).25 * i, 0);
                    stairUp = true;
                    i++;
                }
            }
        }
	}

    void onTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "FPSController")
        {
            Debug.Log("Collided");
            collided = true;
        }
    }
}
