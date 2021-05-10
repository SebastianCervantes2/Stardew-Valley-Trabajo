using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public PlatformController Activacion;
    private PlatformController Controller_;

    private void Start()
    {
        Controller_ = GameObject.Find("PlatformController").GetComponent<PlatformController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
        }
    }

    private void OnMouseDrag()
    {
        Activacion.MovePlatform();
    }




}
