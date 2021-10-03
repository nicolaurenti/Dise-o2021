using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velMov = 5.0f;
    public float velRot = 200.0f;
    private Animator anim;
    public float x, y;

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            anim.SetInteger("Key", 1);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.SetInteger("Key", 0);
        }
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * velRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velMov);
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
