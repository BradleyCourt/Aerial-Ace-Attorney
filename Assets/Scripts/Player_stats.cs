using UnityEngine;
using System.Collections;

public class Player_stats : MonoBehaviour
{
    public bool isdead;
    public int Health;
    public int Damage;


	// Use this for initialization
	void Start ()
    {
        isdead = false; // alive
        Health = 10; // base hp
        Damage = 10; // base dmg
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
