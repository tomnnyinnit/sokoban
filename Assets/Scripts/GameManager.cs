using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string Restart = "lvl 1";
    [SerializeField] private string SceneTo = "lose";
    public float timeLimit = 60f;
    float timeLeft;
    bool start = false;
    float timer;

    [Header("UI")]
    public TMP_Text time;
    public GameObject insturctionPanel;

    [Header("Audio")]
    public AudioClip win;
    public AudioSource audioSource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource.PlayOneShot(win);
        timeLeft = timeLimit;
        insturctionPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer >= 60 && Input.anyKeyDown)
        {
            start = true;
            insturctionPanel.SetActive(false);

        }
        if (start)
        {
            timeLeft -= Time.deltaTime;
            UpdateUI();
        }

        if (timeLeft < 0)
        {
            start = false;
            SceneManager.LoadScene(SceneTo);
        }
    }

    void UpdateUI()
    {
        if (time)
        {
            time.text = $"{timeLeft.ToString("F1")}";
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene(Restart);
    }
}
