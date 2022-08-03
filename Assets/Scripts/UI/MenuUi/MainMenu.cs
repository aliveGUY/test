using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public LocalizationAsset leng;

    public Button continues;
    public Button load;
    public Button exit;

    public GameObject Cans;

    public GameObject underMenu;

    public GameObject setting;



    //public static bool GameOnPause = false;
    // Start is called before the first frame update
    void Start()
    {
        leng = GetComponent<LocalizationAsset>();

        Cans = GameObject.Find("MenuCanv"); Cans.SetActive(true);

        underMenu = GameObject.Find("Under"); underMenu.SetActive(false);

        setting = GameObject.Find("Setting"); setting.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


 

    public void Contin()
    {
        SceneManager.LoadScene(1);
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


    public void GamExit()
    {
        Application.Quit();
    }

}
