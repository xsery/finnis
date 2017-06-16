using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{

    public bool pisouPlataform;
    public Transform verificaPisou;
    public float raioValidaPisou;
    public LayerMask solido;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pisouPlataform = Physics2D.OverlapCircle(verificaPisou.position, raioValidaPisou, solido);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(verificaPisou.position, raioValidaPisou);
    }
}
