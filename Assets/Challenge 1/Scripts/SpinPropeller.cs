using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{

    public Vector3 axisRotate;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       // transform.Rotate(new Vector3(x: 0, y: 1, z: 0)); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axisRotate * speed * Time.deltaTime);
    }
}
