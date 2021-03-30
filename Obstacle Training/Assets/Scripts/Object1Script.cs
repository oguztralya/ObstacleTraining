using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1Script : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
