using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    private float Speed = 2.0f;

    void Start()
    {
        // Rigidbody�̃R���|�[�l���g���擾
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
        // W�L�[�őO�i
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0.0f, 0.0f, Speed);
        }
        // S�L�[�Ō��
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0.0f, 0.0f, -Speed);
        }
        // D�L�[�ŉE�ɐi�� 
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(Speed, 0.0f, 0.0f);
        }
        // A�L�[�ō��ɐi�� 
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-Speed, 0.0f, 0.0f);
        }
    }
}