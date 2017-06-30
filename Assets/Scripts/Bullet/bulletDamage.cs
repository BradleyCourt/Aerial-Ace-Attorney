using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{

    public int bulletDmg = 0;

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collision");
        //If it hit something that should be damaged
        if (col.gameObject.tag == "Enemy")
        {
            //Get characterstats
            playerStats stats = col.gameObject.GetComponent<playerStats>();

            //If hit gameobject has characterstats
            if (stats)
            {
                //Apply damage
                stats.RemoveHealth(bulletDmg);
               
            }
        }

        gameObject.SetActive(false);
    }
}
