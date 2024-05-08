using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ch3Leave : MonoBehaviour
{
    private Animator ch3LeaveAnimator;

    // Start is called before the first frame update
    void Start()
    {
        ch3LeaveAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ch3LeaveSequence());
        }
    }

    IEnumerator ch3LeaveSequence()
    {
        Bored();
        yield return new WaitForSeconds(5f);
        Stand();
        yield return new WaitForSeconds(2f);
        Leave();
    }

    void Bored()
    {
        ch3LeaveAnimator.SetBool("bored", true);
    }

    void Stand()
    {
        ch3LeaveAnimator.SetBool("bored", false);
        ch3LeaveAnimator.SetBool("stand up", true);
    }

    void Leave()
    {
        ch3LeaveAnimator.SetBool("walk away", true);
    }
}
