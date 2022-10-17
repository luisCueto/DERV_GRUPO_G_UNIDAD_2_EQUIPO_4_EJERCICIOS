using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class movimientoFisicas2 : MonoBehaviour
{
    public float velocidadDesplazamiento = 10;
    Rigidbody rb;

    [SerializeField]
    GameObject jugador;

    [SerializeField]
    GameObject objetoSpawneado;

    public void generarObjeto()
    {
        float x = Random.Range(0, 8f);
        float y = 1.4f;
        float z = Random.Range(-4f, 4f);
        Instantiate(objetoSpawneado, new Vector3(x, y, z), transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        generarObjeto();
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

    private void OnCollisionEnter(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;

        if (!tag.Equals("Escenario"))
        {
            Debug.Log("name: " + name + " | tag: " + tag);
            GameObject obj = GameObject.Find("Manzana(Clone)");
            Destroy(obj, 0);


            float scaleX = jugador.transform.localScale.x;
            float scaleY = jugador.transform.localScale.y;
            float scaleZ = jugador.transform.localScale.z;

            if(scaleX == scaleY == scaleZ < 5)
            {
                jugador.transform.localScale = new Vector3(scaleX + .1f, scaleY + .1f, scaleZ + .1f);
            }
            else
            {
                jugador.transform.localScale = new Vector3(1f, 1f, 1f);
            }
            

            generarObjeto();
        }
    }
}
