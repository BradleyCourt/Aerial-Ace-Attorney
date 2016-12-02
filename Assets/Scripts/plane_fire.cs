using UnityEngine;
using System.Collections;

public class plane_fire : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot_level_1();
    }
    void Shoot_level_1()
    {
   
        if (Input.GetButtonDown("Fire1"))
        {
            object_pool activate = GameObject.Find("object_pool").GetComponent<object_pool>();
            if (Input.GetButtonDown("Fire1")) activate.initiate_object();

           // InstantiatedProjectile.velocity = transform.TransformDirection(new Vector2(speed, 0));

            //if(GetComponent<Renderer>().isVisible)
            //{
            //    Destroy(projectile);
            //}
        }
    }
}
