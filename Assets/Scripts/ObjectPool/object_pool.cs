using UnityEngine;
using System.Collections;

public class object_pool : MonoBehaviour
{
    // sets all items in array to null
    private GameObject[] objects = null;
    public Transform Target;
    // allows designers to dictate what object is getting pooled
    public GameObject object_to_instantiate;
    // determines the max size of the pool
    public int pool_size = 0;
    // Use this for initialization
    
    void Start()
    {
        objects = new GameObject[pool_size];
        for (int i = 0; i < pool_size; i++)
        {
            objects[i] = Instantiate(object_to_instantiate) as GameObject;
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
