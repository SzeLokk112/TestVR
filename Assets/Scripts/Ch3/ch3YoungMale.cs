using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ch3YoungMale : MonoBehaviour
{
    private Animator ch3YoungMaleAnimator;

    // Start is called before the first frame update
    void Start()
    {
        ch3YoungMaleAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ch3YoungMaleSequence());
        }
    }

    IEnumerator ch3YoungMaleSequence()
    {
        yield return new WaitForSeconds(10f);
        Stand();
        yield return new WaitForSeconds(2f);
        Talk();
    }

    void Talk()
    {
        ch3YoungMaleAnimator.SetBool("talk", true);
    }

    void Stand()
    {
        ch3YoungMaleAnimator.SetBool("bored", false);
        ch3YoungMaleAnimator.SetBool("stand up", true);
    }
}
