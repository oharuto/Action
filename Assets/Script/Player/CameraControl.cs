using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] 
    float viewAngle; // エディター上で60を入力
    private float inputX;
    private float inputY;

    public float mouseX_Speed;
    public float mouseY_Speed;

    void Update()
    {
        inputX = Input.GetAxis("Mouse X") * mouseX_Speed;
        inputY = Input.GetAxis("Mouse Y") * mouseY_Speed;

        Rotate(inputX, -inputY, viewAngle);
    }

    void Rotate(float inputX, float inputY, float limit)
    {
        float maxLimit = limit, minLimit = 360 - maxLimit;

        //X軸回転
        var localAngle = transform.localEulerAngles;
        localAngle.x += inputY;
        if (localAngle.x > maxLimit && localAngle.x < 180)
        {
            localAngle.x = maxLimit;
        }
        if (localAngle.x < minLimit && localAngle.x > 180)
        {
            localAngle.x = minLimit;
        }
        transform.localEulerAngles = localAngle;

        //Y軸回転
        var angle = transform.eulerAngles;
        angle.y += inputX;
        transform.eulerAngles = angle;
    }
}