using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public float rotationSpeed;

    public GameObject pivotObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(pivotObject.transform.position , new Vector3(1f,0f,0f) , rotationSpeed * Time.deltaTime);
        }
        
    }
}
