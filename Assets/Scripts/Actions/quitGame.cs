using UnityEngine;
using System.Collections;

public class quitGame : action {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public override void execute()
    {
        Application.Quit();
        Debug.Log("i quit");
    }
}
