using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidudestroyed : MonoBehaviour
{
     void OnDestroy()
    {
        Debug.Log("On Destroyed da duoc goi !");
        Debug.Log("On Destroyed la mot ham duoc goi khi" +
            " mot object hoac thanh phan bi pha huy hoac" +
            " khi thoat playmode.");
        Debug.Log("On Destroyed la function cuoi cung cua" +
            " script, co chuc nang don dep tai nguyen" +
            " va chong tran bo nho.");
        Debug.Log("Trong vi du nay, On destroyed se duoc " +
            "goi ngay sau vi du On Disable, ngay sau " +
            "khi thoat Playmode.");
        
    }
}
