using UnityEngine;
using System.Collections;

public class bullet_move : MonoBehaviour
{
    public GameObject projectile;
    public Vector3 speed = new Vector3(0,0,0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
       projectile.transform.position += speed * Time.deltaTime;
        //projectile.GetComponent<Rigidbody>().AddForce(20, 0, 0);
    }
}
