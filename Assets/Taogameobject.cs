using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taogameobject : MonoBehaviour
{
    [SerializeField] private GameObject myObject;
    void Start()
    {
        myObject = new GameObject("MyGameObject");
        myObject.AddComponent<Rigidbody>();
    }
}
