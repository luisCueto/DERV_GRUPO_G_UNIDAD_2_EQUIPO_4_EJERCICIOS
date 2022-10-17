using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]
    GameObject objeto;

    public void GenerarObjeto()
    {
        float x = Random.Range(0, 8f);
        float y = 1.4f;
        float z = Random.Range(-4f, 4f);
        Instantiate(objeto, new Vector3(x, y, z), transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        GenerarObjeto();
    }

    // Update is called once per frame
    void Update()
    {
                
    }
}
