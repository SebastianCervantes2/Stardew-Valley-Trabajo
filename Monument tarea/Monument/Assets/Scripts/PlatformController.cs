using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{

    public Rigidbody platformRB;
    public Transform[] platformPosition;
    public float platformSpeed;




    void Start()
    {
     

    }


    private void Update()
    {

        
    }

    public void MovePlatform()
    {
        platformRB.MovePosition(Vector3.MoveTowards(platformRB.position, platformPosition[1].position, platformSpeed * Time.deltaTime));

 

    }


}
