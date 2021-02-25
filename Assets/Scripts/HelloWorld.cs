// These using statements are just telling Unity we want to use some built in things
// in Unity to make things easier, don’t worry too much about them yet!

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Our default script in Unity creates one class. Think of it like a container for all
// our code and for now just remember that the outer curly brackets show where the class
// begins and ends.

// All our code will go inside this class.

public class HelloWorld : MonoBehaviour
{
    // These two code blocks are functions. A function is a block of code that we can call
    // (run) repeatedly from elsewhere in our script. For now just remember that any code
    // we want to put in a function will go inside the curly brackets.

    // Unity has two built in functions, Start() and Update().

    // Everything in Start() will run once when your game starts.
    // Everything in Update() will run every time a new frame is drawn.

    // Start is called before the first frame update
    void Start()
    {
        // Put code here to make it run once at the start!
        print("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {
        // Put code here to make it run every frame!
    }
}
