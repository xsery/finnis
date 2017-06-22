using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

	public int atualStage;
    public bool door;
    public AudioSource portaSounce;
    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        anim.SetBool("Aberto", false);
        door = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void doorOpen()
    {
        portaSounce.Play();
        anim.SetBool("Aberto", true);
        door = true;
    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
		if (atualStage == 1 && door)
        {
			SceneManager.LoadScene("Scenes/Stage2");
		}

		if (atualStage == 2 && door)
        {
			SceneManager.LoadScene("Scenes/Memories2");
		}
        if (atualStage == 3 && door)
        {
            SceneManager.LoadScene("Scenes/Stage4");
        }

        if (atualStage == 4 && door)
        {
            SceneManager.LoadScene("Scenes/Stage5");
        }
        if (atualStage == 5 && door)
        {
            SceneManager.LoadScene("Scenes/Stage6");
        }

        if (atualStage == 6 && door)
        {
            SceneManager.LoadScene("Scenes/Memories3");
        }
        if (atualStage == 7 && door)
        {
            SceneManager.LoadScene("Scenes/Memories4");
        }

        if (atualStage == 8 && door)
        {
            SceneManager.LoadScene("Scenes/Memories5");
        }
    }
}
