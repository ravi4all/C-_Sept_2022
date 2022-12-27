using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonBurst : MonoBehaviour
{

    [SerializeField]
    GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        Destroy(gameObject);
        Instantiate(effect, transform.position, Quaternion.identity);
    }
}
