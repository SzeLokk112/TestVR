using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Joe : MonoBehaviour
{

    public static event Action JoeStartedTalking;
    public static event Action JoeStartedClapping;
    private Animator JoeAnimator;
    private bool isStandingUp = false;
    private bool isTalking = false;
    private bool isListening = false;
    private bool isClapping = false;

    // Start is called before the first frame update
    void Start()
    {
        JoeAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(JoeSequence());
        }
    }

    IEnumerator JoeSequence()
    {
        StandUp();
        yield return new WaitForSeconds(5.57f);

        Talk();
        yield return new WaitForSeconds(10f);
        StopTalking();

        SitDown();
        yield return new WaitForSeconds(2.12f);

        Listen();
        yield return new WaitForSeconds(10f);
        StopListening();

        ClapHands();
    }

    void StandUp()
    {
        JoeAnimator.SetBool("stand", true);
        isStandingUp = true;
    }

    void Talk()
    {
        JoeAnimator.SetBool("talk", true);
        isTalking = true;
        JoeStartedTalking?.Invoke();
    }

    void StopTalking()
    {
        JoeAnimator.SetBool("talk", false);
        isTalking = false;
    }

    void SitDown()
    {
        JoeAnimator.SetBool("sit down", true);
        isStandingUp = false;
    }

    void Listen()
    {
        JoeAnimator.SetBool("listen", true);
        isListening = true;
    }

    void StopListening()
    {
        JoeAnimator.SetBool("listen", false);
        isListening = false;
    }

    void ClapHands()
    {
        JoeAnimator.SetBool("claphands", true);
        isClapping = true;
        JoeStartedClapping?.Invoke();
    }

    private void OnDestroy()
    {
        JoeStartedTalking = null;
        JoeStartedClapping = null;
    }
}
