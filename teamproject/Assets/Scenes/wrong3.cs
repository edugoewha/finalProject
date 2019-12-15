using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrong3 : MonoBehaviour
{
	private AudioSource Waudio;
    public AudioClip WSound;
    private AudioSource seekaudio;
    public AudioClip seekSound;

    public GameObject chair;
    public GameObject duck;
    public GameObject pen;
    public GameObject milk;
    // Start is called before the first frame update
    void Start()
    {
        this.Waudio = this.gameObject.AddComponent<AudioSource>();
        this.Waudio.clip = this.WSound;
        this.Waudio.loop = false;

        this.seekaudio = this.gameObject.AddComponent<AudioSource>();
        this.seekaudio.clip = this.seekSound;
        this.seekaudio.loop = false;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("chair"))
        {
			grab3.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab3.newText[2].text="다른 물건을 찾아보세요";
            chair.transform.localPosition=new Vector3(5.02f,0,2.7f);
            heart.heartcount--;
        }
        
        if (other.gameObject.CompareTag("duck"))
        {
			grab3.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab3.newText[2].text="다른 물건을 찾아보세요";
            duck.transform.localPosition=new Vector3(-8.96f,4.94f,3.14f);
            heart.heartcount--;
        }
        
        if (other.gameObject.CompareTag("pen"))
        {
			grab3.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab3.newText[2].text="다른 물건을 찾아보세요";
            pen.transform.localPosition=new Vector3(5.02f,0,2.7f);
            heart.heartcount--;
        }
        
        if (other.gameObject.CompareTag("milk"))
        {
			grab3.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab3.newText[2].text="다른 물건을 찾아보세요";
            milk.transform.localPosition=new Vector3(5.02f,0,2.7f);
            heart.heartcount--;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
