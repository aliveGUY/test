using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public LocalizationAsset leng;

    public Button continues;
    public Button load;
    public Button exit;

    public GameObject Cans;

    public GameObject underMenu;

    public GameObject setting;

    public GameObject Exit;

    public bool menuEnter = false;
    //public static bool GameOnPause = false;
    // Start is called before the first frame update
    void Start()
    {
        leng = GetComponent<LocalizationAsset>();

        Cans = GameObject.Find("MenuCanv"); Cans.SetActive(false);

        underMenu = GameObject.Find("Under"); underMenu.SetActive(false);

        setting = GameObject.Find("Setting"); setting.SetActive(false);

        Exit = GameObject.Find("ExitChoise"); Exit.SetActive(false);

        //sceneLoad = GameObject.Find("LoadMenu");
        //sceneLoad.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ShowMenu();
    }


    public void ShowMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuEnter != true)
            {

                Cans.SetActive(true);
                menuEnter = true;
                Time.timeScale = 0f;
            }
            else
            {
                //cans.SetActive(false);
                //menuEnter = false;
                //Time.timeScale = 1f;
                Contin();
            }
        }
    }

    public void Contin()
    {
        Cans.SetActive(false);
        underMenu.SetActive(false);
        setting.SetActive(false);
        Exit.SetActive(false);
        menuEnter = false;
        Time.timeScale = 1f;
    }
    public void LoadConv()
    {
        if (underMenu.activeInHierarchy == true)
            underMenu.SetActive(false);
        else
            underMenu.SetActive(true);

    }

    public void SetSetting()
    {
        if (setting.activeInHierarchy == true)
            setting.SetActive(false);
        else
            setting.SetActive(true);
    }

    public void ExitGame()
    {
        Exit.SetActive(true);
    }

    public void MenExit()
    { SceneManager.LoadScene(0); }

    public void GamExit()
    {
        Application.Quit();
    } 
}


