using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dance : MonoBehaviour {

    public GameObject getItGurl;

    [SerializeField]
    private GameObject sickMoves;

    [SerializeField]
    private GameObject[] arrowArray;

    [SerializeField]
    private AudioClip getItGurlSound;

    [SerializeField]
    private AudioClip reallySound;

    [SerializeField]
    private GameObject startScreen;

    [SerializeField]
    private GameObject endScreen;

    [SerializeField]
    private int arrowCount;

    AudioSource audioSource;
    public GameObject lights;







    private void Awake()
    {
        HideArrows();
        audioSource = GetComponent<AudioSource>();
    }


    // Use this for initialization
    void Start () {
        

        StartCoroutine(DDRscreen());
        SetActiveArrow();
        arrowCount = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

        if(arrowCount==5){
            sickMovesEnding();
        }
		
	}


    void SetActiveArrow()
    {
        int randomNumber = Random.Range(0, arrowArray.Length);
        arrowArray[randomNumber].SetActive(true);

    }



    void HideArrows(){
        foreach (GameObject arrow in arrowArray){
            arrow.SetActive(false);
        }
    }

    public void Hit(){
        HideArrows();
        audioSource.PlayOneShot(getItGurlSound, 0.7F);
        arrowCount++;
        StartCoroutine(gitItGurlAnouncer());
    }

    IEnumerator gitItGurlAnouncer(){
        getItGurl.SetActive(true);
        yield return new WaitForSeconds(.6f);
        getItGurl.SetActive(false);
        SetActiveArrow();
    }

    void sickMovesEnding(){
        HideArrows();
        endScreen.SetActive(true);
        sickMoves.SetActive(true);
    }

    IEnumerator DDRscreen(){
        startScreen.SetActive(true);
        audioSource.PlayOneShot(reallySound, 0.7F);
        yield return new WaitForSeconds(1f);
        startScreen.SetActive(false);
        StartCoroutine(SwitchToNextFromDance());
    }

    IEnumerator SwitchToNextFromDance(){
        yield return new WaitForSeconds(2f);
    }


}
