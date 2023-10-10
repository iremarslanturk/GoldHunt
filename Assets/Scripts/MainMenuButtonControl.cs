using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonControl : MonoBehaviour
{
    public OyunKontrol OyunK;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainMenuLoad() 
    {
        SceneManager.LoadScene("LoginScene");
        OyunK.oyunActive=true;  
    }
}
