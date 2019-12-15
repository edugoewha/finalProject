using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrong2 : MonoBehaviour
{
	private AudioSource Waudio;
    public AudioClip WSound;
    private AudioSource seekaudio;
    public AudioClip seekSound;

    public GameObject fish;
    public GameObject car;
    public GameObject spoon;
    public GameObject tiger;
    
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
        if (other.gameObject.CompareTag("fish"))
        {
			grab2.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab2.newText[2].text="다른 물건을 찾아보세요";
            fish.transform.localPosition=new Vector3(11.77f,-1.19f,52.03f);
            heart.heartcount--;
        }
        
        if (other.gameObject.CompareTag("car"))
        {
			grab2.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab2.newText[2].text="다른 물건을 찾아보세요";
            car.transform.localPosition=new Vector3(5.02f,0,2.7f);
            heart.heartcount--;
        }
        
        if (other.gameObject.CompareTag("spoon"))
        {
			grab2.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab2.newText[2].text="다른 물건을 찾아보세요";
            spoon.transform.localPosition=new Vector3(5.02f,0,2.7f);
            heart.heartcount--;
        }
        
        if (other.gameObject.CompareTag("tiger"))
        {
			grab2.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab2.newText[2].text="다른 물건을 찾아보세요";
            tiger.transform.localPosition=new Vector3(5.02f,0,2.7f);
            heart.heartcount--;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
