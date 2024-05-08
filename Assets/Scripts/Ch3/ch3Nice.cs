using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch3Nice : MonoBehaviour
{
    private Animator ch3NiceAnimator;// Start is called before the first frame update
    void Start()
    {
        ch3NiceAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ch3NiceSequence());
        }
    }

    IEnumerator ch3NiceSequence()
    {
        yield return new WaitForSeconds(15f);
        Clap();
    }

    void Clap()
    {
        ch3NiceAnimator.SetBool("listen", false);
        ch3NiceAnimator.SetBool("claphands", true);
    }
}
