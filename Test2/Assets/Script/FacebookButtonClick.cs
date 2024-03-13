using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacebookButtonClick : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onclick()
    {
        animator.SetTrigger("click");
    }
}
