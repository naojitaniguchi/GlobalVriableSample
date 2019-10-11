using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintFlagTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("flagA");
        Debug.Log(GameFlagManager.flagA);
        Debug.Log("flagB");
        Debug.Log(GameFlagManager.flagB);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
