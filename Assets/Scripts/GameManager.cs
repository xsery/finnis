using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private int collectedLetters = 0;
    public int totalLetters = 6;
    public string endingScene = "Stage9.2";
    public string alternativeEndingScene = "Stage9.1";


    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();

                if (instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "GameManager";
                    instance = go.AddComponent<GameManager>();
                    DontDestroyOnLoad(go);             
                }
            }
            return instance;
        }
    }



    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    } 

    /// <summary>
    /// Coleta uma carta da historia do finnis
    /// </summary>
    public void CollectLetter()
    {
        collectedLetters++;
        Debug.Log("Cartas coletadas: " + collectedLetters);
    }

    /// <summary>
    /// Exibe o final do jogo de acordo com o número de cartas coletadas
    /// </summary>
    public void LoadFinalStage()
    {
        string finalScene = endingScene;

        if (collectedLetters != totalLetters)
        {
            finalScene = alternativeEndingScene;
        }
        Debug.Log("Carregando cena final: " + finalScene);
        SceneManager.LoadScene(finalScene);
    }

    void Start () {
		
	}
	

	void Update () {
		
	}
}
