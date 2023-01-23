using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class ScaleA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    [SerializeField] private MeshFilter Change;
    [SerializeField] private Mesh Use; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Change.mesh = Use;
        }
    }
}
