using UnityEngine;
using System.Collections;

public class playerStats : MonoBehaviour
{
    public bool isdead;
    public int currentHealth;
    public int maxHealth;


	// Use this for initialization
	void Start ()
    {
        isdead = false; // alive
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void RemoveHealth(int bulletdmg)
    {
        currentHealth -= bulletdmg;
        checkIsDead();
    }

    void checkIsDead()
    {
        if (currentHealth <= 0)
        {
            isdead = true;
            Debug.Log("im dead");
            Destroy(gameObject);
        }
    }

}

