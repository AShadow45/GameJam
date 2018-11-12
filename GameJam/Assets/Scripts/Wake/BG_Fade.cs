using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Fade : MonoBehaviour {

    Animator anim;
    bool p_fade;

    void Start () {
        anim = GetComponent<Animator>();
        p_fade = false;
    }
	
	
	void Update () {

        doFade();

    }

    public void doFade() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            p_fade = true;
        }

        anim.SetBool("doFade", p_fade);
    }
}
