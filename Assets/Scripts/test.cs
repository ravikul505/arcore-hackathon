using System;
using System.Collections;
using Unity.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Vector2 = System.Numerics.Vector2;

public class test : MonoBehaviour
{
    private Vector3 xVector;
    private Vector3 yVector;
    private Vector3 zVector;
    private Vector3 iVector;
    private Rigidbody m_RigidBody;
    private float m_Speed = (2.0f);
    void Start()
    {
        xVector = new Vector3(1.0f, 0.0f, 0.0f);
        yVector = new Vector3(0.0f, 1.0f, 0.0f);
        zVector = new Vector3(0.0f, 0.0f, 1.0f);
        iVector = new Vector3(0f, 0f, 0f);
        m_RigidBody = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_RigidBody.velocity = (iVector + (yVector * m_Speed));
        }if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_RigidBody.velocity = (iVector - (yVector * m_Speed));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_RigidBody.velocity = (iVector - (xVector * m_Speed));
        }  if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_RigidBody.velocity = (iVector + (xVector * m_Speed));
        }
        /*
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_RigidBody.velocity = (new Vector3(0,0,0f) + (yVector * m_Speed));
        }
        */

        
    }
}
