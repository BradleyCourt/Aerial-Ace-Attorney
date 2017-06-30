using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTouch : MonoBehaviour
{
    public GameObject Player;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("collision");

            Destroy(Player);
        }
    }

}
