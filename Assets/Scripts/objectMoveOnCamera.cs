using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMoveOnCamera : MonoBehaviour
{
    public Transform Target;
    Camera cam;

	// Use this for initialization
	void Start ()
    {
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(Target.position);
        if (viewPos.x > 0.5F)
        {
            print("target is on the right side!");
        }
        else
        {
            print("target is on the left side!");
        }
    }
}
