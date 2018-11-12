using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiStartDialogue : MonoBehaviour {

    Animator anim;
  

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
  
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            anim.SetTrigger("DoMove");
            Debug.Log("hit,DoMove");
            if (collision.gameObject.tag == "Player") {
                anim.SetTrigger("DoFollow");
                Debug.Log("hit,DoFollow");
            }
        }
    }
}
