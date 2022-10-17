using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class colisiones : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txt_contador;

    private spawner spwn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int contador = 0;

    private void OnCollisionEnter(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;
             
        if (!tag.Equals("Escenario"))
        {
            contador++;
            Debug.Log("name: " + name + " | tag: " + tag);
            GameObject obj = GameObject.Find(name);
            Destroy(obj,0);
            txt_contador.text = contador.ToString();

            spwn.GenerarObjeto();
        }

        
    }
}
