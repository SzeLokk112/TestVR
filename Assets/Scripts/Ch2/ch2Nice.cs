using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2Nice : MonoBehaviour
{
    private Animator ch2NiceAnimator;// Start is called before the first frame update
    void Start()
    {
        ch2NiceAnimator = GetComponent<Animator>();
        Emily.EmilyStartedTalking += StartListening;
        Emily.EmilyStartedClapping += StartClapping;
    }

    public void StartListening()
    {
        ch2NiceAnimator.SetBool("listen", true);
    }

    public void StartClapping()
    {
        ch2NiceAnimator.SetBool("listen", false);
        ch2NiceAnimator.SetBool("claphands", true);
    }

    private void OnDestroy()
    {
        Emily.EmilyStartedTalking -= StartListening;
        Emily.EmilyStartedClapping -= StartClapping;
    }
}
