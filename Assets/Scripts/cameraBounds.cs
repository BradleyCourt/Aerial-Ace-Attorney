using UnityEngine;
using System.Collections;

public class cameraBounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        Boundary();
    }
    void Boundary ()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

        pos.x = Mathf.Clamp(pos.x, 0.03f, 0.95f);

        pos.y = Mathf.Clamp(pos.y, 0.03f, 0.95f);

        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
