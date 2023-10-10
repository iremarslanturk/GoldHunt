using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public OyunKontrol OyunK;
    public AudioClip coin, fall;
    private float hiz=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OyunK.oyunActive)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }

    }
    
    void OnCollisionEnter(Collision cls)
    {
        if (cls.gameObject.tag.Equals("coin")) 
        {
            GetComponent<AudioSource>().PlayOneShot(coin, 1f);
            OyunK.CoinCounterr();
            Destroy(cls.gameObject);

        }
        else if (cls.gameObject.tag.Equals("obstacle"))
        {
            GetComponent<AudioSource>().PlayOneShot(fall, 1f);
            OyunK.oyunActive = false;
           
            
        }
        
    }
}
