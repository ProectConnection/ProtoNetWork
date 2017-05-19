using UnityEngine;
using System.Collections;

public class NetWork_02 : MonoBehaviour {

	void Update() {

		// 生成位置をランダムな座標にする
		float x = Random.Range(-10f, 10f);
		float y = Random.Range(-10f, 10f);
		float z = Random.Range(-10f, 10f);
		Vector3 pos = new Vector3(x, y, z);

		// 左クリックをしたらマッチング環境にCubeのインスタンスを生成する
		if (Input.GetMouseButtonDown(0)) {

			// 第1引数にResourcesフォルダの中にあるプレハブの名前(文字列)
			// 第2引数にposition
			// 第3引数にrotation
			// 第4引数にView ID(指定しない場合は0)
			GameObject obj = PhotonNetwork.Instantiate("cube", pos, Quaternion.identity, 0);

			// 生成したオブジェクトに力を加える
			/*Rigidbody objRB = obj.GetComponent&lt;Rigidbody&gt;();
			objRB.AddForce(Vector3.forward * 20f, ForceMode.Impulse);*/
		}
			
	}

	/*void destroy()
	{



	}*/

}