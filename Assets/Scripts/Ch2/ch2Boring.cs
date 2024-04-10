using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2Boring : MonoBehaviour
{
    private Animator ch2BoringAnimator;// Start is called before the first frame update
    void Start()
    {
        ch2BoringAnimator = GetComponent<Animator>();
        Emily.EmilyStartedTalking += StartBored;
    }

    public void StartBored()
    {
        ch2BoringAnimator.SetBool("bored", true);
    }

    private void OnDestroy()
    {
        Emily.EmilyStartedTalking -= StartBored;
    }
}
