using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text timer, coinCounter,result;
    public UnityEngine.UI.Button retry,mainMenu;
    public bool oyunActive=true;
    public int coinCount=0;
    public float gameTime=60;
    private Rigidbody rg;
    
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunActive)
        {
            gameTime -= Time.deltaTime;
            timer.text = "" + (int)gameTime;
        }
        if(gameTime<=0)
        {
            oyunActive = false;
        }

        if(oyunActive==false && coinCount!=6)
        {
            result.text = "GAME OVER";
            retry.gameObject.SetActive(true);
            mainMenu.gameObject.SetActive(true);
            rg.velocity = Vector3.zero;
            rg.freezeRotation = true;
            Time.timeScale = 0f;


        }
        else if(oyunActive==true && coinCount==6) 
        {
            oyunActive = false;
            result.text = "CONGRULATIONS";
            retry.gameObject.SetActive(true);
            mainMenu.gameObject.SetActive(true);
            rg.velocity = Vector3.zero;
            
           
        }
        else if(!oyunActive)
        {
            Time.timeScale= 0f;
        }
    }
    public void CoinCounterr()
    {
        coinCount++;
        coinCounter.text = "" + coinCount + "/6";
    }
    
}
