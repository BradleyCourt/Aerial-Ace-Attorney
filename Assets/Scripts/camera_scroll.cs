using UnityEngine;
using System.Collections;

public class camera_scroll : MonoBehaviour
{
    public Vector3 speed = new Vector3(0, 0, 0);   
    public GameObject cam;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        cam.transform.position += speed * Time.deltaTime;
    }
}
