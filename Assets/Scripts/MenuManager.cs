using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string SceneTo = "lvl 1";

    [Header("Audio")]
    public AudioClip click;
    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchScene()
    {
        SceneManager.LoadScene(SceneTo);
    }

    public void clicked()
    {
        audioSource.PlayOneShot(click);
    }
}
