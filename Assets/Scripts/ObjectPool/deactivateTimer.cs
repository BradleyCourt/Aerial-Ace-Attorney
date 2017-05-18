using UnityEngine;
using System.Collections;

public class deactivateTimer : MonoBehaviour
{
    // how long it exists for before its removed
    public float lifespan;

    // keeps track of time
    private float timer;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
    
	    //if(Time.time > timer + lifespan)        
     //   {
     //       timer = Time.time;
     //       gameObject.SetActive(false);
     //       transform.position = Vector3.zero;

     //   }
	}
}
