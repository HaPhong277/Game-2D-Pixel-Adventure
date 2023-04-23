using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class init : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private int cherries = 0;
    [SerializeField] private Text cherriesText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject selectedCharacter = CharacterSelect.selectedCharacter;
        GameObject playerObject = Instantiate(selectedCharacter, transform.position, Quaternion.identity);
        playerObject.name = "Player";


        mainCamera.transform.SetParent(playerObject.transform);
      
    }
}
