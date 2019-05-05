using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacaoController: MonoBehaviour
{
    // Start is called before the first frame update

    Animator animator;
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator> (); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.D)){
            // dancando verdadeiro
            animator.SetBool("dancando", true);
        }

        if(Input.GetKeyUp (KeyCode.D)){
            // dancando false
            animator.SetBool("dancando", false);

        }

        if(Input.GetKeyDown (KeyCode.Space)){
            // dancando verdadeiro
            animator.SetBool("pulando", true);
        }

        if(Input.GetKeyUp (KeyCode.Space)){
            // dancando false
            animator.SetBool("pulando", false);

        }

        if(Input.GetKeyDown (KeyCode.B)){
            // dancando verdadeiro
            animator.SetBool("breaking", true);
        }

        if(Input.GetKeyUp (KeyCode.B)){
            // dancando false
            animator.SetBool("breaking", false);

        }
    }
}
