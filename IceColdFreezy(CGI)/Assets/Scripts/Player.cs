using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player : MonoBehaviour
{
    public float Speed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * Speed * Time.deltaTime;

        transform.Translate(Horizontal, 0, Vertical);
    }
}
