using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Для этого класса лучше сделать инстанс,
// но не уверен что это нужно на данном этапе обучения

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    GameObject startText;
    [SerializeField]
    GameObject spawner;

    bool isPlay;

    void Start()
    {
        isPlay = false;
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (!isPlay && Input.GetKeyDown(KeyCode.Space))
            StartGame();
    }

    public void StartGame()
    {
        isPlay = true;
        startText.SetActive(false);
        spawner.SetActive(true);

        Time.timeScale = 1f;
    }

    public void Reload() => SceneManager.LoadScene(GetScene());

    public int GetScene() => SceneManager.GetActiveScene().buildIndex;
}
