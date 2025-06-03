using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
        void Start()
        {
            // Setting position 
            transform.position = new Vector3(0, 1, 0);
            // Setting rotation 
            transform.rotation = Quaternion.Euler(0, 45, 0);
            // Setting scale 
            transform.localScale = new Vector3(2, 2, 2);
        }  
}
