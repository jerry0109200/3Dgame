using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5;
    public float turnspeed = 30;

    public float VInput;
    public float HInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VInput = Input.GetAxis("Vertical");
        HInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * VInput);
        transform.Rotate(Vector3.up * Time.deltaTime * speed * HInput);
    }
}
