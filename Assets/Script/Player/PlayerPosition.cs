using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    private Vector3 Init_Position; // ‰ŠúˆÊ’u

    // Start is called before the first frame update
    void Start()
    {
        // ‰ŠúˆÊ’uæ“¾
        Init_Position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    // ‰Šú‰»ŠÖ”
    public void Reset()
    {
        gameObject.transform.position = Init_Position; // ˆÊ’u‚Ì‰Šú‰»
    }

}
