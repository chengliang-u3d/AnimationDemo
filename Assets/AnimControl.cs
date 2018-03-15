using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour {
    public Animation anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            anim["simpleMove"].speed = 1;
            //anim["simpleMove"].time = anim["simpleMove"].length;
            anim.Play("simpleMove");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            
            anim["simpleMove"].speed = -1;
            anim["simpleMove"].time = anim["simpleMove"].length;
            anim.Play("simpleMove");
        }
	}
}
