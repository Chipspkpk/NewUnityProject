using UnityEngine;
using System.Collections;

public class BlockMovement : MonoBehaviour {
    public Texture2D tex;
    public float timeOut = 1.0f;
    private float timeElapsed;

    private Rigidbody2D rb2D;
    private Sprite mySprite;
    private SpriteRenderer sr;
    public float thrust = 100.0f;

    //void Awake()
    //{
    //    sr = gameObject.AddComponent<SpriteRenderer>();
    //    rb2D = gameObject.AddComponent<Rigidbody2D>();
    //}

    void Start()
    {
        rb2D =GetComponent<Rigidbody2D>();
        thrust = Random.Range(0f, 15.0f);
        //        mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, 128.0f, 128.0f), new Vector2(0.5f, 0.5f), 100.0f);
        //timeOut = 10.0f;
        //        sr.color = new Color(0.9f, 0.9f, 0.5f, 1.0f);
        //        sr.sprite = mySprite;
        //  rb = gameObject.AddComponent<Rigidbody>();
        //transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        StartCoroutine(RandomMove());
    }

//    void Update()
//    {
//        timeElapsed += Time.deltaTime;
    //    rb2D.AddForce(new Vector2(20, 1));
//        if(timeElapsed >= timeOut)
//        if(Input.GetMouseButtonDown(0))
//        {
            //Vector2 dir = new Vector2(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            //dir.Normalize();
            //rb2D.AddForce(dir * 3.0f);
            //timeElapsed = 0.0f;
//        }
//    }

    IEnumerator RandomMove()
    {
        while (true)
        {
            Vector2 dir = new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
            dir.Normalize();
            rb2D.AddForce(dir * 100.0f);
            timeElapsed = 0.0f;
            yield return new WaitForSeconds(0.1f);
        }
    }
    //private IEnumerator Movement()
    //{

    //}
}
