using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class objectPool : MonoBehaviour
{
    // sets all items in array to null
	//public GameObject[] objects = null;		
	[HideInInspector] public List<GameObject> objects;		// NOTE: This needs to be public so other classes accessing the pool can use it. Also now using a list so bullets can be added much easier
    public Transform Target;
    // allows designers to dictate what object is getting pooled
    public GameObject object_to_instantiate;
    // determines the max size of the pool
    public int pool_size = 0;
    // Use this for initialization
    
    void Start()
    {
		/* New code, works with List<GameObject> */
		for (int i = 0; i < pool_size; i++)
		{
			objects.Add(Instantiate(object_to_instantiate, this.transform) as GameObject);
			objects[i].SetActive(false);
		}
    }
    // Update is called once per frame
    public void initiate_object()
    {    
        for (int i = 0; i < pool_size; i++)
        {
            if (objects[i].activeInHierarchy == false)
            {
                objects[i].transform.position = Target.transform.position;
                objects[i].SetActive(true);
                return;
            }       
        }
    }

    void Update ()
    {
	
	}
}
