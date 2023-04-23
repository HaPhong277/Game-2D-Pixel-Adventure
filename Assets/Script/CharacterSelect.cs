using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    [SerializeField] GameObject[] characters;
    [SerializeField] Button btnPrev;
    [SerializeField] Button btnNext;
    [SerializeField] Button btnPlay;

    [SerializeField] Text characterName;
    [SerializeField] GameObject[] characterPrefabs;

    private int index;
    public static GameObject selectedCharacter;

    private void Start()
    {
        index = 0;
        btnPrev.onClick.AddListener(OnPrevBtnClick);
        btnNext.onClick.AddListener(OnNextBtnClick);
        btnPlay.onClick.AddListener(OnPlayBtnClick);
        SelectCharacter();
    }
    public void OnPrevBtnClick()
    {
        ///Debug.LogError("da click");
        if(index > 0)
        {
            index--;
        }
        SelectCharacter();
    }
    public void OnNextBtnClick()
    {
        if (index < characters.Length -1)
        {
            index++;
        }
        SelectCharacter();
    }
    public void OnPlayBtnClick()
    {
        //SceneManager.LoadScene(4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    private void SelectCharacter()
    {
        for(int i =0; i < characters.Length; i++)
        {
            if(i == index)
            {
                characters[i].GetComponent<SpriteRenderer>().color = Color.white;
                characters[i].GetComponent<Animator>().enabled = true;
                selectedCharacter = characterPrefabs[i];
                characterName.text = characterPrefabs[i].name;
            }
            else
            {
                characters[i].GetComponent<SpriteRenderer>().color = Color.black;
                characters[i].GetComponent<Animator>().enabled = false;
            }
        }
    }
}
