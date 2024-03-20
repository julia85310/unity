using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCanvas : MonoBehaviour
{
    public GameObject canvaActivar;
    public GameObject canvaDesactivar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambioCanvas()
    {
        canvaActivar.SetActive(true);
        canvaDesactivar.SetActive(false);
    }
}
