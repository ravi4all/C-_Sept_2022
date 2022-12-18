using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockScript : MonoBehaviour
{
    float hoursToDegree = -6f;
    [SerializeField]
    Transform niddlePivot;

    // void Awake() {
        // Debug.Log(DateTime.Now);
        // niddlePivot.localRotation = Quaternion.Euler(0,0,-30);
        // niddlePivot.localRotation = Quaternion.Euler(0,0, hoursToDegree * DateTime.Now.Hour);
    // }

    void Update() {
        var time  = DateTime.Now;
        // niddlePivot.localRotation = Quaternion.Euler(0,0, hoursToDegree * DateTime.Now.Hour);
        niddlePivot.localRotation = Quaternion.Euler(0,0, 
                                    hoursToDegree * time.Second);
    }
}
