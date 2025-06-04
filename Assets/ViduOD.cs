using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViduOD : MonoBehaviour
{ 
    void OnDisable()
    {
        Debug.Log("On Disable vua duoc su dung !");
        Debug.Log("On Disable la mot function duoc goi tu dong " +
            "khi object khong con hoat dong va script ket thuc.");
        Debug.Log("On Disable nam o gan cuoi cua script, ngay " +
            "truoc OnDestroyed");
        Debug.Log("Trong vi du nay, On Disable dang duoc dung, " +
            "ngay sau on Enable o vi du truoc.");              
    }  
}
