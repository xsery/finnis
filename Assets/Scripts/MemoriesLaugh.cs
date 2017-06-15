using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemoriesLaugh : MonoBehaviour {

    public AudioSource risada;
    public float timeBefore;
    public float timeDuring;
    public float timeAfter;
    public float level;

    // Use this for initialization
    void Start () {
        StartCoroutine("memories");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator memories()
    {
        yield return new WaitForSeconds(timeBefore);
        risada.Play();
        yield return new WaitForSeconds(timeDuring);
        risada.Play();
        yield return new WaitForSeconds(timeAfter);

        if(level == 1)
        {
            SceneManager.LoadScene("Scenes/Stage1");
        } else
        {
            if(level == 7)
            {
                SceneManager.LoadScene("Scenes/Stage7");
            }
        }
        
    }
    }
