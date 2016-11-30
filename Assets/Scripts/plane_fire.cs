using UnityEngine;
using System.Collections;

public class plane_fire : MonoBehaviour
{
    public Rigidbody projectile;

    public float speed = 10;
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
            Rigidbody InstantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

            InstantiatedProjectile.velocity = transform.TransformDirection(new Vector2(speed, 0));

            //if(GetComponent<Renderer>().isVisible)
            //{
            //    Destroy(projectile);
            //}
        }
    }
}
