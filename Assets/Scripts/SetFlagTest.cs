using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFlagTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameFlagManager.flagA = true;
        GameFlagManager.flagB = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
