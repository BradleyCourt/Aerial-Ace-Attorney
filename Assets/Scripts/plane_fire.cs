using UnityEngine;
using System.Collections;

public class plane_fire : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    public float lifespan;
    private float timer;
  
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            object_pool activate = GameObject.Find("object_pool").GetComponent<object_pool>();
            if (Input.GetButtonDown("Fire1")) activate.initiate_object();
            {
                StartCoroutine(despawn_timer());
            }
            
        }
    }
    // ref gameobject
    IEnumerator despawn_timer()
    {
        yield return new WaitForSeconds(lifespan);
        projectile.gameObject.SetActive(false);
        Debug.Log("work");  
    }
    void Shoot_level_1()
    {

       
    }
}




