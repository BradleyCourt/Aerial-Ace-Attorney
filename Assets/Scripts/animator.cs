using UnityEngine;
using System.Collections;
using InControl;

public class animator : MonoBehaviour
    {
    Animator animate;
    public InputDevice device;
    // Use this for initialization
    void Start ()
    {
        animate = GetComponent<Animator>();
        device = InputManager.ActiveDevice;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown (KeyCode.F) || (device != null && device.RightTrigger.WasPressed))
        {
            if (animate.IsInTransition(0) == false)
            {
                animate.SetTrigger("startFlip");
                Debug.Log("flipped");
            }
        }
    }
}
