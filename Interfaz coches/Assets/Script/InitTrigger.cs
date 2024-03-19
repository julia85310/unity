using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitTrigger : MonoBehaviour
{
    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public string triggerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciaAnimaciones ()
    {
        anim1.SetTrigger("click");
        anim2.SetTrigger("click");
        anim3.SetTrigger("click");
    }
}
