using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] Button btnPlay;

    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(OnStartBtnClick);
    }
    public void OnStartBtnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
