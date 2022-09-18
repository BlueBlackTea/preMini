using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{

    int type;
    float size;
    int score;
    public TextAsset endTxt;

    // Start is called before the first frame update
    void Start()
    {

        float x = Random.Range(-2.7f, 2.7f);
        float y = 6;

        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 4);

        if (type==1)
        {

            size = 1.2f;

        }
        if (type == 2)
        {

            size = 1.0f;

        }
        if (type == 3)
        {

            size = 0.8f;

        }

        transform.localScale = new Vector3(size, size, 0);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag=="keepedCircle")
        {
            gameManager.I.gameOver();
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
