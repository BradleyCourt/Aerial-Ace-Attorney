using UnityEngine;
using System.Collections;

public class redPlaneController : MonoBehaviour
{
    public int speed = 5;
    


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0) * speed * Time.deltaTime;
    }
}

