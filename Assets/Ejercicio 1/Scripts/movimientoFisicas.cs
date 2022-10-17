using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoFisicas : MonoBehaviour
{
    public float velocidadDesplazamiento = 10;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(rb.position + transform.forward * velocidadDesplazamiento * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(rb.position + transform.right * -1f * velocidadDesplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(rb.position + transform.forward * -1f * velocidadDesplazamiento * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(rb.position + transform.right * velocidadDesplazamiento * Time.deltaTime);
        }
    }
}
