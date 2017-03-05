using UnityEngine;
using System.Collections;
//スクリプトでUIを操作する場合は、「using UnityEngine.UI;」を記述する。
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	//ターゲットの種類によって取得できる点数を変えてください(point数設定)
	private int smallstar = 5;
	private int largestar = 10;
	private int smallcloud = 15;
	private int largecloud = 20;

	//defaultpoint設定
	int defaultPoint = 0;

	//現在のpoit保管関数
	int pointSave = 0;

	//pointを表示するテキスト
	private GameObject pointgetText;

	// Use this for initialization
	void Start () {
		
		//シーン中のpointgetTextオブジェクトを取得
		this.pointgetText = GameObject.Find ("ScoreText");

		//Textクラスの「text」は、Textコンポーネントに表示する文字列を指定(string型)
		this.pointgetText.GetComponent<Text> ().text = defaultPoint.ToString();

	}
	
	// Update is called once per frame
	void Update () {

		this.pointgetText.GetComponent<Text> ().text = pointSave.ToString();
	}
	//衝突時に呼ばれる関数。「OnCollisionEnter」は、自分のColliderが他のオブジェクトのColliderと接触した時に呼ばれる関数です。引数には接触した相手のCollisionが渡されます。「Collision」は、衝突したオブジェクトの情報が取得できるクラスです。
	void OnCollisionEnter(Collision other) { Debug.Log(other.gameObject.tag);if(other.gameObject.tag == "SmallStarTag"){pointSave += smallstar;} if(other.gameObject.tag == "LargeStarTag"){pointSave += largestar;}if(other.gameObject.tag == "SmallCloudTag"){pointSave += smallcloud;}if(other.gameObject.tag == "LargeCloudTag"){pointSave += largecloud;}
		}	
}
