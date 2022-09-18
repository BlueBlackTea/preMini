using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public Animator anim;
    public GameObject keepedCircle;

    private void Awake()
    {
        I = this;
    }

    public Text timeTxt;

    public float timeT = 0.0f;

    public GameObject square;

    public GameObject endTxt;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("makeRain", 0.0f, 0.5f);

    }

    void makeRain()
    {
        Instantiate(square);
    }


    // Update is called once per frame
    void Update()
    {
        timeT += Time.deltaTime;

        timeTxt.text = timeT.ToString("N2");

    }

    public void gameOver()
    {
        anim.SetBool("isDie", true);
        endTxt.SetActive(true);
        Invoke("dead", 0.5f);
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(keepedCircle);
    }

}
