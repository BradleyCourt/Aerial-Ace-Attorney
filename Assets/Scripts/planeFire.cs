using UnityEngine;
using System.Collections;

public class planeFire : MonoBehaviour
{
    public Rigidbody projectile;
	public Transform muzzlePoint;		// Added a parameter for the bullet's fire point to be specified. I noticed you already had an empty GameObject called plane_gun attached to the plane
    public float speed = 20;
    public float lifespan;
    private float timer;

    public int currentPool = 0;
    public objectPool[] bulletPools;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        /* OLD CODE:
		 * Please note the second if statement was not attached to the braces, and instead would run the activate.initiate_object() line of code.
		 * 
		 */
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    object_pool activate = GameObject.Find("object_pool").GetComponent<object_pool>();
        //    if (Input.GetButtonDown("Fire1")) activate.initiate_object();
        //    {
        //        StartCoroutine(despawn_timer());
        //    }
        //    
        //}

        /* NEW CODE: */

        if (Input.GetKeyDown(KeyCode.P))
        {
            currentPool++;
            if (currentPool >= bulletPools.Length)
                currentPool = 0;
        }


		if (Input.GetButtonDown("Fire1"))		// If the player is firing
		{
            // Find the pool object in the scene
            //GameObject poolHolder = GameObject.Find("object_pool");
            //if (poolHolder == null)		// Check if the object exists in the scene
            //{
            //	// The object needs to be created
            //	poolHolder = new GameObject();
            //	poolHolder.name = "object_pool";
            //}

            // Now find the pooling script on the object
            //objectPool pool = poolHolder.GetComponent<objectPool>();

            objectPool pool = bulletPools[currentPool]; 
			//if (pool == null)		// Check if the script exists
			//{
				// The pooling script needs to be created
				//pool = poolHolder.AddComponent<objectPool>();
				//pool.pool_size = 50;		// Maybe determine a default pool size elsewhere?
			//}

			// Now that we have the pool, we need to find the first object available in the pool
			GameObject projectile = null;
			foreach (GameObject g in pool.objects)
			{
				if (!g.activeSelf)		// If the bullet is inactive (and therefore available to use)...
				{
					projectile = g;		// Save this object
					break;		// Stop searching
				}
			}

			if (projectile == null)		// If all the bullets in the pool are already in use...
			{
				// We need to create a new bullet in the pool
				projectile = Instantiate(pool.object_to_instantiate, pool.transform) as GameObject;
				pool.objects.Add(projectile);
			}

			// We now have a bullet to fire! Make the bullet shoot here

			// Activate the projectile
			projectile.SetActive(true);

			// Reset the position of the projectile to the plane's gun position (as it will still have the position from the last time it was used in the pool)
			if (muzzlePoint)		// If the muzzlePoint has been specified in the inspector
				projectile.transform.position = muzzlePoint.position;		// Use the specified point
			else
				projectile.transform.position = transform.position;		// Use the plane's position

			// Reset the velocity of the projectile
			Rigidbody rb = projectile.GetComponent<Rigidbody>();
			if (rb)		// If the projectile has a rigidbody component attached
				rb.velocity = Vector3.zero;

			// Give the projectile a force, using the plane's right vector
			/* NOTE: The bullet does not actually need a force, since it has a script which handles its movement already.
			 * In future, if you are using bullets without this script, add a force to the rigidbody 'rb' here
			 */

			StartCoroutine(despawn_timer(projectile));		// Make the bullet despawn after 'lifespan' seconds
			// Note that the bullet is passed into the coroutine function as a parameter so it knows which one to deactivate after enough time has transpired
		}
    }

    // ref gameobject
	IEnumerator despawn_timer(GameObject obj)
    {
        yield return new WaitForSeconds(lifespan);
        //projectile.gameObject.SetActive(false);
		obj.SetActive(false);
        Debug.Log("despawning object");  
    }

    void Shoot_level_1()
    {

       
    }
}




