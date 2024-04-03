using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class other : MonoBehaviour
{
    private Animator otherAnimator;// Start is called before the first frame update
    void Start()
    {
        otherAnimator = GetComponent<Animator>();
        Joe.JoeStartedTalking += StartListening;
        Joe.JoeStartedClapping += StartClapping;
    }

    public void StartListening()
    {
        otherAnimator.SetBool("listen", true);
    }

    public void StartClapping()
    {
        otherAnimator.SetBool("claphands", true);
    }

    private void OnDestroy()
    {
        Joe.JoeStartedClapping -= StartClapping;
    }
}
