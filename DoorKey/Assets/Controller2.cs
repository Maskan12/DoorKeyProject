using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour
{

    CodeLock2 codeLock2;

    int reachRange = 100;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckHitObj();
        }
    }

    void CheckHitObj()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, reachRange))
        {
            codeLock2 = hit.transform.gameObject.GetComponentInParent<CodeLock2>();

            if (codeLock2 != null)
            {
                string value = hit.transform.name;
                codeLock2.SetValue(value);
            }
        }
    }
}
