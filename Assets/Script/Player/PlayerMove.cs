using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    private float Speed = 2.0f;

    void Start()
    {
        // Rigidbodyのコンポーネントを取得
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Operation();
    }

    /// <summary>
    /// <param name="Speed">2.0f</param>
    /// </summary>
    void Operation()
    {
        // Wキーで前進
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0.0f, 0.0f, Speed);
        }
        // Sキーで後退
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0.0f, 0.0f, -Speed);
        }
        // Dキーで右に進む 
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(Speed, 0.0f, 0.0f);
        }
        // Aキーで左に進む 
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-Speed, 0.0f, 0.0f);
        }
    }
}