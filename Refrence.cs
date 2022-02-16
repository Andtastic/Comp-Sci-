using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refrence : MonoBehaviour
{
    // Start is called before the first frame update
    //(This is a comment!)
    //It has the ability to show sentences, like this one, without it affecting the code.

    int x = 5;
    //This is a variable!
    //A variable is a named value that can change. The "x" is a variable in this case.
    //We have set the variable to a set number "1"

    void Start()
    {
        Debug.Log("Hello World!");
        //This is a statement!
        //This is a statement. A statement is an instruction given to the computer that executes a command
        //Every line of code is a statement, including this print statement.


        for (int i = 0; i < x; i++)
        {
            Debug.Log("Adding numbers..." + i);
            //This is a loop!
            //A Loop is a statement that is repeated 2 to infinitely many times
            //This is a loop that repeats 5 times
        }


    }

    // Update is called once per frame
    void Update()
    // This is defining a function
    //A function is a group of statements that has inputs and outputs
    //This function is the part that when called, will execute whatever was defined.


    {

    }
}

// Start: code runs on the first frame only
//Update: code runs on every frame(updates)