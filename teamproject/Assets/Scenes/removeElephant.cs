using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class removeElephant : MonoBehaviour
{
	private AudioSource Daudio;
    public AudioClip DSound;
    //private AudioSource stage2audio;
    //public AudioClip stage2Sound;
    public GameObject hole;
    public GameObject elephantLater;
    
    // Start is called before the first frame update
    void Start()
    {
        this.Daudio = this.gameObject.AddComponent<AudioSource>();
        this.Daudio.clip = this.DSound;
        this.Daudio.loop = false;

        //this.stage2audio = this.gameObject.AddComponent<AudioSource>();
        //this.stage2audio.clip = this.stage2Sound;
        //this.stage2audio.loop = false;
    }
    
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("elephant"))
        {
            other.gameObject.SetActive (false);
            this.Daudio.Play();
            //this.stage2audio.Play();
            elephantLater.SetActive(true);
            grab2.newText[0].text="잘했습니다! 다음 스테이지로 넘어가세요";
            grab2.newText[2].text="";
            Invoke("removeMyself", 1f);
            hole.SetActive(true);
            
        }
    
    }

	 void removeMyself(){
		gameObject.SetActive(false);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
