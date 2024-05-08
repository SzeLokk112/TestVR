using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch3Boring : MonoBehaviour
{
    private Animator ch3BoringAnimator;// Start is called before the first frame update
    void Start()
    {
        ch3BoringAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartBored();
        }
    }

    public void StartBored()
    {
        ch3BoringAnimator.SetBool("bored", true);
    }
}
