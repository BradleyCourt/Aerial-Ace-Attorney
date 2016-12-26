using UnityEngine;
using System.Collections;
public class obstacles : MonoBehaviour {
    public GameObject Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
    
	}
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            Debug.Log("collision");
            
            Destroy(Player);
        }
    }
    //not working 
    //void onTriggerEntry(Collision col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        Debug.Log("collided");
    //        Destroy(col.gameObject);
    //    }
    //}
}
