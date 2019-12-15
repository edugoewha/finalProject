using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class removeMonkey : MonoBehaviour
{
	private AudioSource Daudio;
    public AudioClip DSound;
    //private AudioSource stage3audio;
    //public AudioClip stage3Sound;


    public GameObject UmbrellaLater;
    // Start is called before the first frame update
    void Start()
    {
        this.Daudio = this.gameObject.AddComponent<AudioSource>();
        this.Daudio.clip = this.DSound;
        this.Daudio.loop = false;

        //this.stage3audio = this.gameObject.AddComponent<AudioSource>();
        //this.stage3audio.clip = this.stage3Sound;
        //this.stage3audio.loop = false;
    }
    
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monkey"))
        {
            //other.gameObject.SetActive (false);
            this.Daudio.Play();
            //this.stage3audio.Play();
            UmbrellaLater.SetActive(true);
            grab3.newText[0].text="잘했습니다! ";
            grab3.newText[2].text="";
            Invoke("removeMyself", 1f);
            Invoke("sceneFinish", 3f);
        }
        
    }

	 void removeMyself(){
		gameObject.SetActive(false);
	}
	
	void sceneFinish(){
		SceneManager.LoadScene("gameend");
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
