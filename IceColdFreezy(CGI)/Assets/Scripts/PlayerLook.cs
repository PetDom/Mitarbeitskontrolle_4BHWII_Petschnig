using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float MouseSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MouseHorizontal = MouseSpeed * Input.GetAxis("Mouse X");
        float MouseVertical = MouseSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(MouseVertical, -MouseVertical, 0);
    }
}
