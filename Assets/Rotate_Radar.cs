using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Radar : MonoBehaviour
{
    
   
    void Update()
    {
        transform.Rotate(0f, 10f * Time.deltaTime, 0f, Space.Self);
    }


}
