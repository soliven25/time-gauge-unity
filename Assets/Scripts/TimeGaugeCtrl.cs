using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeGaugeCtrl : MonoBehaviour {

	private Image timeGauge;
	public float speed = 0.001f;

	private int problemNum = 0;

	// Use this for initialization
	void Start () {
		timeGauge = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

		// Check the gauge is expired 
		if(timeGauge.fillAmount == 0)
		{    
			GameObject expiredProblem = GameObject.Find("problem"+ problemNum);
			timeGauge.fillAmount = 1;
			problemNum++;
			Destroy(expiredProblem);
	    }else{
			timeGauge.fillAmount -= speed;

			if(timeGauge.fillAmount < 0.9) // to protect the case accidentally touch in the begining
				for(var i = 0; i < Input.touchCount; ++i)
				{
					Touch touch = Input.GetTouch(i);

					GameObject expiredProblem = GameObject.Find("problem"+ problemNum);
					timeGauge.fillAmount = 1;
					problemNum++;
					Destroy(expiredProblem);

					break;
				}
		}
	}
}
