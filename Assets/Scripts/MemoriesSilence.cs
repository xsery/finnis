using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MemoriesSilence : MonoBehaviour {

    public float time;
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
        yield return new WaitForSeconds(time);
        if (level == 3) {
            SceneManager.LoadScene("Scenes/Stage3");
        }
        else {
            if (level == 8)
            {
                SceneManager.LoadScene("Scenes/Stage8");
            }
            else
            {
                if (level == 9.1f)
                {
                    SceneManager.LoadScene("Scenes/Stage9.1");
                }
                else
                {
                    if (level == 9.2f)
                    {
                        SceneManager.LoadScene("Scenes/Stage9.2");
                    }
                }
            }
        }
    }
}
