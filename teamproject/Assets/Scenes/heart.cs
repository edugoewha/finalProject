using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heart : MonoBehaviour
{
	public static RawImage[] newImage;
    public static int heartcount;
    // Start is called before the first frame update
    void Start()
    {
        newImage = GetComponentsInChildren<RawImage>();
        heartcount = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(heartcount == 2) DisableImage();
        else if(heartcount == 1) DisableImage1();
        else if(heartcount == 0) DisableImage2();
    }
   
    void DisableImage(){
		newImage[2].enabled = false;
	}
    void DisableImage1(){
		newImage[1].enabled = false;
	}
	void DisableImage2(){
		newImage[0].enabled = false;
		SceneManager.LoadScene("gameover");
	}
    
}
