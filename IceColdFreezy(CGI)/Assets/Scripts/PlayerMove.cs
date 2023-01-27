using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float SpeedNow = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? 2 * MoveSpeed : MoveSpeed;

        float MoveHorizontal = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        float MoveVertical = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;

        transform.Translate(MoveHorizontal, 0, MoveVertical);
    }
}
