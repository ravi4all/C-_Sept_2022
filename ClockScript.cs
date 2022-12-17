using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockScript : MonoBehaviour
{

    [SerializeField]
    // Transform NiddlePivot, SecondsPivot;
    Transform NiddlePivot;

    void Awake () {
        // Debug.Log(DateTime.Now.Hour);
        DateTime time = DateTime.Now;
        NiddlePivot.localRotation = Quaternion.Euler(0,0,-30 * time.Hour);
        // MinutePivot.localRotation = Quaternion.Euler(0,0,-30 * DateTime.Now.Minute);
        // SecondPivot.localRotation = Quaternion.Euler(0,0,-30 * DateTime.Now.Second);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
