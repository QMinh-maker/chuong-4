using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViduOE : MonoBehaviour
{   
    void OnEnable()
    {
        Debug.Log("On Enable vua duoc su dung !");
        Debug.Log("On Enable la mot function duoc goi khi vat the" +
            " gan lien voi no duoc goi trong che do Playmode.");
        Debug.Log("On Enable duoc goi sau Awake va ngay truoc" +
            " Start.");
        Debug.Log("Trong vi du nay, On Enable dang duoc goi khi an" +
            " nut Play va thuc hien in ra vi du nay.");
    }
}

