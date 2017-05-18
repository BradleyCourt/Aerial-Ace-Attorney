using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectables : MonoBehaviour {
    public GameObject Player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Collectable")
        {
            Debug.Log("collected");

            Destroy(this);
            
        }
    }
}
