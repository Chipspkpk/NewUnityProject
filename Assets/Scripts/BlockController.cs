//using UnityEngine;
//using System.Collections;

//public class BlockController : MonoBehaviour {

//	//// Use this for initialization
//	void Start () {
////        StartCoroutine(Move());
//    }
	
//	//// Update is called once per frame
//	//void Update () {
	
//	//}


//    public float accel = 1000;

//    private void Update()
//    {
//        var force = transform.right * Input.GetAxisRaw("Horizontal") * accel;
//        GetComponent<Rigidbody2D>().AddForce(force);
//    }

//    //IEnumerator Move()
//    //{
//    //    while (true)
//    //    {
//    //        var force = transform.right * Input.GetAxisRaw("Horizontal") * accel;
//    //        GetComponent<Rigidbody2D>().AddForce(force);
//    //        yield return new WaitForSeconds(0.0f);
//    //    }
//    //}


//}


using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 WorldPointPos;

    void Update()
    {
        //マウス位置座標をVector3で取得
        pos = Input.mousePosition;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        WorldPointPos = Camera.main.ScreenToWorldPoint(pos);

        // 壁を突き抜けないようにx軸の移動範囲を限定
        if (WorldPointPos.x <= -3.5f)
        {
            WorldPointPos.x = -3.5f;
        }
        else if (WorldPointPos.x >= 3.5f)
        {
            WorldPointPos.x = 3.5f;
        }
        //y軸とz軸は固定
        WorldPointPos.y = 4.0f;
        WorldPointPos.z = 0.0f;

        // ワールド座標をPlayer位置へ変換
        gameObject.transform.position = WorldPointPos;
    }
}