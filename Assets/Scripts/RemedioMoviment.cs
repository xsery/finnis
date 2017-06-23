using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemedioMoviment : MonoBehaviour
{
    public ButtonVertical button;
    public Plataform pisouPlataform;
    public GameObject remedio;

    // Use this for initialization
    void Start() { 

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        StartCoroutine("actionButton");
    }

    IEnumerator actionButton()
    {
        int cont;
        for (cont = 0; cont < button.quantidadeMovimento; cont++)
        {
            if (pisouPlataform.pisouPlataform == true)
            {
                remedio.transform.position = new Vector3(remedio.transform.position.x + button.movimento, remedio.transform.position.y);
                yield return new WaitForSeconds(button.tempoEspera);
            }
        }
    }
}
