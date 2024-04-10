using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Emily : MonoBehaviour
{

    public static event Action EmilyStartedTalking;
    public static event Action EmilyStartedClapping;
    private Animator EmilyAnimator;
    private bool isStandingUp = false;
    private bool isTalking = false;
    private bool isListening = false;
    private bool isClapping = false;

    // Start is called before the first frame update
    void Start()
    {
        EmilyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(EmilySequence());
        }
    }

    IEnumerator EmilySequence()
    {
        Talk();
        yield return new WaitForSeconds(10f);
        StopTalking();

        SitDown();
        yield return new WaitForSeconds(2.24f);

        Listen();
        yield return new WaitForSeconds(10f);
        StopListening();

        ClapHands();
    }

    void Talk()
    {
        EmilyAnimator.SetBool("talk", true);
        isTalking = true;
        isStandingUp = true;
        EmilyStartedTalking?.Invoke();
    }

    void StopTalking()
    {
        EmilyAnimator.SetBool("talk", false);
        isTalking = false;
    }

    void SitDown()
    {
        EmilyAnimator.SetBool("sit down", true);
        isStandingUp = false;
    }

    void Listen()
    {
        EmilyAnimator.SetBool("listen", true);
        isListening = true;
    }

    void StopListening()
    {
        EmilyAnimator.SetBool("listen", false);
        isListening = false;
    }

    void ClapHands()
    {
        EmilyAnimator.SetBool("claphands", true);
        isClapping = true;
        EmilyStartedClapping?.Invoke();
    }

    private void OnDestroy()
    {
        EmilyStartedTalking = null;
        EmilyStartedClapping = null;
    }
}
