using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] InputField inputName;

    private void Start() {
        AudioManager.instance.Play("Music");
    }

    public void PlayGame()
    {
        PlayerData.playerName = inputName.text;

        //Debug.Log(PlayerData.playerName);   
        if(PlayerData.playerName != "")
        {
            AudioManager.instance.Play("Yes");
            SceneManager.LoadScene("Main");
        }
    }
}
