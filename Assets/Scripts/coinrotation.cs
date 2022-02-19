using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinrotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(14, 40, 30) * Time.deltaTime);  
    }
}
