using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
   
    void FixedUpdate()
    {
        this.transform.position += PlayerController.player.transform.forward * -0.2f;
    }
}
