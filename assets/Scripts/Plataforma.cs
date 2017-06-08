using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {
    
    public bool pisouPlataform;
    public Transform verificaPisou;
    public float raioValidaPisou;
    private Transform tr;
    public bool isLeft;
    public float time;

    public LayerMask solido;

    // Use this for initialization
    void Start()
    {
        tr = GetComponent<Transform>();
        isLeft = true;
    }
	
	// Update is called once per frame
	void Update () {
        pisouPlataform = Physics2D.OverlapCircle(verificaPisou.position, raioValidaPisou, solido);
    }

    public void movePlataformDireita()
    {
        if (isLeft)
        {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y);
            ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x + 1, transform.position.y);
            ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x + 1, transform.position.y);
            isLeft = false;

        }
    }

    public void movePlataformEsquerda()
    {
        if (!isLeft) { 
            transform.position = new Vector3(transform.position.x - 1, transform.position.y);
            ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x - 1, transform.position.y);
            ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x - 1, transform.position.y);
            isLeft = true;
        }
    }
    public void moveButtonDireita()
    {
        if (isLeft) { 
            transform.position = new Vector3(transform.position.x + 33, transform.position.y);
            ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x + 33, transform.position.y);
            ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x + 33, transform.position.y);
            isLeft = false;
        }
    }

    public void moveButtonEsquerda()
    {
        if (!isLeft) { 
            transform.position = new Vector3(transform.position.x - 33, transform.position.y);
            ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x - 33, transform.position.y);
            ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x - 33, transform.position.y);
            isLeft = true;
        }
    }

    public void movePersonagemPlataformDireita()
    {
        if (pisouPlataform && isLeft)
        {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y);
            //ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x + 1, transform.position.y);
            //ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x + 1, transform.position.y);
        }
        isLeft = false;
    }

    public void movePersonagemPlataformEsquerda()
    {
        if (pisouPlataform && !isLeft)
        {
            transform.position = new Vector3(transform.position.x - 1, transform.position.y);
            //ExecuteAfterTime();
            transform.position = new Vector3(transform.position.x - 1, transform.position.y);
            //ExecuteAfterTime
            transform.position = new Vector3(transform.position.x - 1, transform.position.y);
        }
        isLeft = true;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(verificaPisou.position, raioValidaPisou);
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(time);

    }

}
