using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveLoader : MonoBehaviour
{
    public Button fsDay;
    public Button seDay;
    public Button thDay;

    public GameObject underMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            underMenu.SetActive(false);
        }
    }

    public void day1()
    { SceneManager.LoadScene(0); }

    public void day2()
    { SceneManager.LoadScene(1); }

    public void day3()
    { SceneManager.LoadScene(2);  }
}
