using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class grab3 : MonoBehaviour
{

    private AudioSource audio;
    public AudioClip jumpSound;
    private AudioSource instaudio;
    public AudioClip instSound;
    private AudioSource monkeyaudio;
    public AudioClip monkeySound;

    public GameObject Chairword;
    public GameObject Duckword;
    public GameObject Monkeyword;
    public GameObject Milkword;
    public GameObject Penword;
    public GameObject Umbrellaword;
    
    public GameObject Chairobject;
    public GameObject Duckobject;
    public GameObject Monkeyobject;
    public GameObject Milkobject;
    public GameObject Penobject;
    public GameObject Umbrellaobject;
    
    public GameObject Board;
    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject Plane3;
    public GameObject Plane4;
    public GameObject Plane5;
    public GameObject Plane6;

    public GameObject myHand;

    Vector3 ChairwordPos;
    Vector3 DuckwordPos;
    Vector3 MonkeywordPos;
    Vector3 MilkwordPos;
    Vector3 PenwordPos;
    Vector3 UmbrellawordPos;
   
    Camera cam;
    public float handPower;
    public static bool inHand1;
    public static bool inHand2;
    public static bool inHand3;
    public static bool inHand4;
    public static bool inHand5;
    public static bool inHand6;
    
    bool inHands = false;

    Ray ray;
    RaycastHit hit;

    public static Text[] newText;
    public static int count;



    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
        newText = GetComponentsInChildren<Text>();
        
        count = 6;
        
        Chairobject.SetActive(false);
        Duckobject.SetActive(false);
        Monkeyobject.SetActive(false);
        Milkobject.SetActive(false);
        Penobject.SetActive(false);
        Umbrellaobject.SetActive(false);

        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.jumpSound;
        this.audio.loop = false;

        this.instaudio = this.gameObject.AddComponent<AudioSource>();
        this.instaudio.clip = this.instSound;
        this.instaudio.loop = false;

        this.monkeyaudio = this.gameObject.AddComponent<AudioSource>();
        this.monkeyaudio.clip = this.monkeySound;
        this.monkeyaudio.loop = false;

        this.instaudio.Play();
    }


    // Update is called once per frame
    void Update()
    {

        if (count == 0)
        {
            Invoke("DisableText", 1f);
            this.audio.Play();
            this.monkeyaudio.Play();
            newText[0].text = "비에 젖은 원숭이에게 필요한 물건을 가져다 주세요";
            Destroy(Board);
            Destroy(Plane1);
            Destroy(Plane2);
            Destroy(Plane3);
            Destroy(Plane4);
            Destroy(Plane5);
            Destroy(Plane6);
            Chairobject.SetActive(true);
			Duckobject.SetActive(true);
			Monkeyobject.SetActive(true);
			Milkobject.SetActive(true);
			Penobject.SetActive(true);
			Umbrellaobject.SetActive(true);
            count--;
            
            //Board.SetActive(false);
            //Plane1.SetActive(false);
            //Plane2.SetActive(false);
            //Plane3.SetActive(false);
            //Plane4.SetActive(false);
            //Plane5.SetActive(false);
            //Plane6.SetActive(false);
        }
        else if(count > 0)
        {
            newText[0].text = "물건을 집어서 맞는 단어를 누르세요";

        }


        if (Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.tag == "Chairword")
                {
                    Chairword.transform.SetParent(myHand.transform);
                    Chairword.transform.localPosition = new Vector3(1.5f, 0.8f, 1f);
                    inHand1 = true;
                 
                }

                if (hit.collider.tag == "Duckword")
                {
                    Duckword.transform.SetParent(myHand.transform);
                    Duckword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand2 = true;
                }

                if (hit.collider.tag == "Monkeyword")
                {
                    Monkeyword.transform.SetParent(myHand.transform);
                    Monkeyword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand3 = true;
                }

                if (hit.collider.tag == "Milkword")
                {
                    Milkword.transform.SetParent(myHand.transform);
                    Milkword.transform.localPosition = new Vector3(0.8f, 1.5f, 0);
                    inHand4 = true;
                }

                if (hit.collider.tag == "Penword")
                {
                    Penword.transform.SetParent(myHand.transform);
                    Penword.transform.localPosition = new Vector3(0.8f, 1.0f, 0);
                    inHand5 = true;
                }

                if (hit.collider.tag == "Umbrellaword")
                {
                    Umbrellaword.transform.SetParent(myHand.transform);
                    Umbrellaword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand6 = true;
                }
                
                if (hit.collider.tag == "chair")
                {
                    Chairobject.transform.SetParent(myHand.transform);
                    Chairobject.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHands = true;
                }
                
                if (hit.collider.tag == "duck")
                {
                    Duckobject.transform.SetParent(myHand.transform);
                    Duckobject.transform.localPosition = new Vector3(1f, 1.1f, 0);
                    inHands = true;
                }
                
                if (hit.collider.tag == "milk")
                {
                    Milkobject.transform.SetParent(myHand.transform);
                    Milkobject.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHands = true;
                }
                
                if (hit.collider.tag == "pen")
                {
                    Penobject.transform.SetParent(myHand.transform);
                    Penobject.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHands = true;
                }
                
                if (hit.collider.tag == "umbrella")
                {
                    Umbrellaobject.transform.SetParent(myHand.transform);
                    Umbrellaobject.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHands = true;
                }
            }

        }



    }
    void DisableText()
    {
        newText[1].enabled = false;
    }
}
