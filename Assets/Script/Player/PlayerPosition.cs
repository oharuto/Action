using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    private Vector3 Init_Position; // �����ʒu

    // Start is called before the first frame update
    void Start()
    {
        // �����ʒu�擾
        Init_Position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // �������֐�
    public void Reset()
    {
        gameObject.transform.position = Init_Position; // �ʒu�̏�����
    }

}
