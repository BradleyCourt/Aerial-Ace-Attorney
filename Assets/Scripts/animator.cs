using UnityEngine;
using System.Collections;

public class animator : MonoBehaviour
    {
    Animator animate;
	// Use this for initialization
	void Start ()
    {
        animate = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown (KeyCode.F))
        {
            animate.SetTrigger("startFlip");
        }
    }
}
