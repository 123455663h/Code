using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForObjects : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    //判斷滑鼠的座標  回傳滑鼠碰到的物件名稱

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit , 100))
        {
            print("hit" + hit.collider.gameObject);
        }
    }
}
