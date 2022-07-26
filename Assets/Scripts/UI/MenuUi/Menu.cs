using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public LocalizationAsset leng;

    public Button continues;
    public Button load;
    public Button exit;

    public GameObject cans;

    public GameObject underMenu;

    public GameObject setting;

    public bool menuEnter = false;
    //public static bool GameOnPause = false;
    // Start is called before the first frame update
    void Start()
    {
        leng = GetComponent<LocalizationAsset>();

        cans = GameObject.Find("MenuCanv");  cans.SetActive(false);

        underMenu = GameObject.Find("Under"); underMenu.SetActive(false);
       
        setting = GameObject.Find("Setting"); setting.SetActive(false);
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

                cans.SetActive(true);
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
        cans.SetActive(false);
        underMenu.SetActive(false);
        setting.SetActive(false);
        menuEnter = false;
        Time.timeScale = 1f;
    }
    public void LoadConv()
    {
        //Debug.Log("Работает");
        //sceneLoad.SetActive(true);
        //SceneManager.LoadScene(2);

        underMenu.SetActive(true);
    }

    public void SetSetting()
    {
        setting.SetActive(true);   
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}


