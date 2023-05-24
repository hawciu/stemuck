using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = Vector3.zero;
        
        if (Input.GetKey(KeyCode.W))
        {
            moveDir = moveDir + new Vector3(0, 0, +1f);
        }

        transform.position = transform.position + moveDir * Time.deltaTime * speed;
    }
}
