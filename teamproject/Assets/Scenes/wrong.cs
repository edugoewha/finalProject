using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrong : MonoBehaviour
{
    //public Text status;
    public int count;
    private AudioSource Waudio;
    public AudioClip WSound;
    private AudioSource seekaudio;
    public AudioClip seekSound;

    public GameObject rock;
    public GameObject grass;
    public GameObject rope;
    public GameObject tangerine;
    
    //Vector3 rockpos;

    // Start is called before the first frame update
    void Start()
    {
		//rockpos=rock.transform.position;
		
		this.Waudio = this.gameObject.AddComponent<AudioSource>();
        this.Waudio.clip = this.WSound;
        this.Waudio.loop = false;
        //status = gameObject.GetComponentInChildren<Text>();

        this.seekaudio = this.gameObject.AddComponent<AudioSource>();
        this.seekaudio.clip = this.seekSound;
        this.seekaudio.loop = false;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rock"))
        {
			grab.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab.newText[2].text="다른 물건을 찾아보세요";
            rock.transform.localPosition=new Vector3(5.02f,0,2.7f);
            heart.heartcount--;
        }
        
        else if (other.gameObject.CompareTag("grass"))
        {
			grab.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab.newText[2].text="다른 물건을 찾아보세요";
            grass.transform.localPosition=new Vector3(5.02f,0,2.7f);
            heart.heartcount--;
        }
        
        else if (other.gameObject.CompareTag("rope"))
        {
			grab.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab.newText[2].text="다른 물건을 찾아보세요";
            rope.transform.localPosition=new Vector3(5.02f,0,2.7f);
            heart.heartcount--;
        }
        
        else if (other.gameObject.CompareTag("tangerine"))
        {
			grab.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            this.Waudio.Play();
            this.seekaudio.Play();
            grab.newText[2].text="다른 물건을 찾아보세요";
            tangerine.transform.localPosition=new Vector3(-20.6f,0.35f,1f);
            heart.heartcount--;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    
}
