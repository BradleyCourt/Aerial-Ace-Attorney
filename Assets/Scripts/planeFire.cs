using UnityEngine;
using System.Collections;
using InControl;
using UnityEngine.SceneManagement;

public class planeFire : MonoBehaviour
{
    public Rigidbody projectile;

    public Transform muzzlePoint;       // Added a parameter for the bullet's fire point to be specified. I noticed you already had an empty GameObject called plane_gun attached to the plane
    public Transform BulUpgrade1;
    public Transform BulUpgrade2;
     
    public float speed = 20;
    public float lifespan;
    private float timer;
    public InputDevice device;
    public int currentPool = 0;
    public objectPool[] bulletPools;

    //Collectables
    public GameObject firePower1;
    public GameObject firePower2;
    public GameObject firePower3;
    public GameObject BulletUpgrade;
    public GameObject levelComplete;

    public float frenzyDur = 10.0f;
    bool frenzy = false;

    // Use this for initialization      
    void Start()
    {
        device = InputManager.ActiveDevice;
    }

    // Update is called once per frame
    void Update()
    {
        if (frenzy == true)
        {
            frenzyDur -= Time.deltaTime;
        }
        if (frenzyDur <= 0)
        {
            frenzy = false;
            frenzyDur = 10;
            projectile.transform.position = muzzlePoint.position;
        }


        if (Input.GetKeyDown(KeyCode.P) || (device != null && device.Action4.WasPressed))
        {
            currentPool++;
            if (currentPool >= bulletPools.Length)
                currentPool = 0;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) || (device != null && device.Action1.WasPressed))       // If the player is firing
        {

            GameObject projectile = GetBullet();

            // We now have a bullet to fire! Make the bullet shoot here

            // Activate the projectile
            projectile.SetActive(true);

            // Reset the position of the projectile to the plane's gun position (as it will still have the position from the last time it was used in the pool)



            if (frenzy != true)
            {
    
                if (muzzlePoint)        // If the muzzlePoint has been specified in the inspector
                    projectile.transform.position = muzzlePoint.position;       // Use the specified point
                else
                    projectile.transform.position = transform.position;     // Use the plane's position
            }
            else
            {
               
                if (muzzlePoint) // If the muzzlePoint has been specified in the inspector
                {
                    projectile.transform.position = muzzlePoint.position;
                }
                if (BulUpgrade1) // If the muzzlePoint has been specified in the inspector
                {
                    projectile = GetBullet();
                    projectile.transform.position = BulUpgrade1.position;
                }
                if(BulUpgrade2)
                {
                    projectile = GetBullet();
                    projectile.transform.position = BulUpgrade2.position;  // Use the specified point
                }

            }
            // Reset the velocity of the projectile
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            if (rb)     // If the projectile has a rigidbody component attached
                rb.velocity = Vector3.zero;

            StartCoroutine(despawn_timer(projectile));      // Make the bullet despawn after 'lifespan' seconds
                                                            // Note that the bullet is passed into the coroutine function as a parameter so it knows which one to deactivate after enough time has transpired
        }
    }

    GameObject GetBullet()
    {
        objectPool pool = bulletPools[currentPool];

        // Now that we have the pool, we need to find the first object available in the pool
        GameObject projectile = null;
        foreach (GameObject g in pool.objects)
        {
            if (!g.activeSelf)      // If the bullet is inactive (and therefore available to use)...
            {
                projectile = g;     // Save this object
                break;      // Stop searching
            }
        }

        if (projectile == null)     // If all the bullets in the pool are already in use...
        {
            // We need to create a new bullet in the pool
            projectile = Instantiate(pool.object_to_instantiate, pool.transform) as GameObject;
            pool.objects.Add(projectile);
        }

        // We now have a bullet to fire! Make the bullet shoot here

        // Activate the projectile
        projectile.SetActive(true);

        return projectile;
    }

    // ref gameobject
    IEnumerator despawn_timer(GameObject obj)
    {
        yield return new WaitForSeconds(lifespan);
        obj.SetActive(false);
        Debug.Log("despawning object");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "firePowerUp1")
        {
            Destroy(firePower1);
            currentPool = 1;
        }
       if (col.gameObject.tag == "firePowerUp2")
        {
            Destroy(firePower2);
            currentPool = 2;
        }
        if (col.gameObject.tag == "firePowerUp3")
        {
            Destroy(firePower3);
            currentPool = 3;
        }
        if (col.gameObject.tag == "levelComplete")
        {
            Destroy(levelComplete);
            SceneManager.LoadScene("Level_2");
            currentPool = 0;
        }
        if (col.gameObject.tag == "BulletUpgrade")
        {
            Destroy(BulletUpgrade);
         
            frenzy = true;
        }

  
    }
    
}




