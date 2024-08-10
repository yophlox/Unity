using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.N3DS;
using UnityEngine.UI;

public class DetectModel : MonoBehaviour {

	void Start ()
    {
        if (UnityEngine.N3DS.Application.isRunningAsExtApplication == true)
        {
            NewModel();
        }

        if (UnityEngine.N3DS.Application.isRunningAsExtApplication == false)
        {
            OldModel();
        }
    }

    void NewModel()
    {
        Debug.Log("New 3DS [performance is overall increased]");
    }

    void OldModel()
    {
        Debug.Log("Old 3DS [WARNING: performance can drop]");
    }
}