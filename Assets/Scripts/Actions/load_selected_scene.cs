using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class load_selected_scene : action
{
    public string scenename = ""; 

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    public override void execute()
    {
        SceneManager.LoadScene(scenename);
    }
}

