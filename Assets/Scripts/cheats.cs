﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheats : MonoBehaviour {

    private string[] cheatCode;
    private int index;

    void Start()
    {
        // Code is "idkfa", user needs to input this in the right order
        cheatCode = new string[] { "c", "h", "e", "a", "t" };
        index = 0;
    }

    void Update()
    {
        // Check if any key is pressed
        if (Input.anyKeyDown)
        {
            // Check if the next key in the code is pressed
            if (Input.GetKeyDown(cheatCode[index]))
            {   
                // Add 1 to index to check the next key in the code
                index++;
            }
            // Wrong key entered, we reset code typing
            else
            {
                index = 0;
            }
        }

        // If index reaches the length of the cheatCode string, 
        // the entire code was correctly entered
        if (index == cheatCode.Length)
        {
            index = 0;
            // Cheat code successfully inputted!
            // Unlock crazy cheat code stuff
            Debug.Log("You activated me!");
            
        }
    }
    public void activateCheats()
    {

    }
}
