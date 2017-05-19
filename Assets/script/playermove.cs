using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    //private GameObject cameraObject;//カメラのオブジェクト
    public GameObject bullet;//弾のオブジェクト
    public static float Ecnt;//弾の所持数
    
    // Use this for initialization
    void Start()
    {
        Ecnt = 0;//バレット数の初期化
        //cameraObject = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
      //  float dx = Input.GetAxis("Horizontal");//左右の移動
      //  float dz = Input.GetAxis("Vertical");//前後の移動
      //  transform.Translate(dx, 0.0F, dz);//transformのxとzで移動
      //  float ry = Input.GetAxis("Fire1");//左右矢印でカメラの移動
      //  transform.Rotate(0.0F, ry, 0.0F);//物体を左右に動かして移動
        Vector3 trans;

        trans = new Vector3(Mathf.Sin(this.transform.localEulerAngles.y * 3.14f / 180) * 80.0f, 80, Mathf.Cos(this.transform.localEulerAngles.y * 3.14f / 180) * 40.0f);
        if (Ecnt>=1&&Input.GetKeyDown("space"))//spaceでバレットを発射
        {
            GameObject bal;
            Vector3 pow = new Vector3(transform.position.x + trans.x / 180, transform.position.y, transform.position.z + trans.z / 90);
            bal = (GameObject)Instantiate(bullet, pow, this.transform.rotation);
            trans.x *= 1.5f;
            trans.y *= 1.25f;
            trans.z *= 3;
            bal.GetComponent<Rigidbody>().AddForce(trans * 2, ForceMode.Force);
            Ecnt--;
            Debug.Log(Ecnt);
        }
    }
    /*void OnTriggerEnter(Collider collision)
    {
        //Destroy(collision.gameObject);
        if (collision.transform.tag == "Redboll" && Ecnt <= 5)
        {
            Ecnt++;
            Debug.Log(Ecnt);
        }
    }*/
}