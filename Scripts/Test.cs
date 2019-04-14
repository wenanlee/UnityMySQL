using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        SqlHelper.Insatance.SetConnStr("120.27.188.117", "root", "YJsqlpwd132", "vr");
        foreach (var item in SqlHelper.Insatance.GetTables())
        {
            print(item);
        }
    }
}
