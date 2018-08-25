using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedRobot : MonoBehaviour {

    private Animator animator;

    // Use this for initialization
    void Start () {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Jump()
    {
        this.animator.SetTrigger("JumpTrigger");
    }
}
