using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{

    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ani.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
	ani.SetFloat("Vertical", Input.GetAxis("Vertical"));
    }
}
