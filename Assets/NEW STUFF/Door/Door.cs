using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    GameObject door;
    Animator animator;
    void Start()
    {
        door = this.gameObject;
        animator = door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //JUST TO TEST THE ANIMATOR
        if (Input.GetKeyDown(KeyCode.E)) animator.SetTrigger("Open");
    }
}
