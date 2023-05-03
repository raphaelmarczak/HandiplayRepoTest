using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotateY : MonoBehaviour
{
    public float rotateSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
    }
}
