using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // [SerializeField] AudioClip walkSE = null;

    // private Animator animator = null;
    private Rigidbody rb = null;
    // private AudioSource audioSource = null;

    private float NormalSpeed = 5.0f;  // �ʏ�̑��x
    private float Acceleration = 2.0f;  // ����
    private float Speed;

    bool KeyPush; // �V�t�g�L�[�������ꂽ��

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody�̃R���|�[�l���g���擾
        rb = transform.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// <param name="Speed">2.0f</param>
    /// </summary>
    void Move()
    {
        var velocity = Vector3.zero;
        // W�L�[�őO�i
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = NormalSpeed + Acceleration;
            }
            velocity.z = Speed * Time.deltaTime;
        }
        // S�L�[�Ō��
        if (Input.GetKey(KeyCode.S))
        {
            velocity.z = -Speed * Time.deltaTime;
        }
        // D�L�[�ŉE�ɐi�� 
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = NormalSpeed + Acceleration;
            }
            velocity.x = Speed * Time.deltaTime;
        }
        // A�L�[�ō��ɐi�� 
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = NormalSpeed + Acceleration;
            }
            velocity.x = -Speed * Time.deltaTime;
        }
        if (velocity.x != 0 || velocity.z != 0)
        {
            transform.position += transform.rotation * velocity;
        }
    }
}
