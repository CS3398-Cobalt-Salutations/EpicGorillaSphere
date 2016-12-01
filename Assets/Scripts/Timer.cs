using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public Text timerText;
	private float startTime;

	bool keepTiming;
	float timer;

	void Start () {
		StartTimer();
	}

	void Update () {
        //if(PlayerMoveSphere.count >= 5){
        //    Debug.Log("Timer stopped at " + TimeToString(StopTimer()));
        //}

		if(keepTiming){
			UpdateTime();
		}
	}

	void UpdateTime(){
		timer = Time.time - startTime;
		timerText.text = TimeToString(timer);
	}

	float StopTimer(){
		keepTiming = false;
		return timer;
	}

	void ResumeTimer(){
		keepTiming = true;
		startTime = Time.time-timer;
	}

	void StartTimer(){
		keepTiming = true;
		startTime = Time.time;
	}

	string TimeToString(float t){
		string minutes = ((int) t / 60).ToString();
		string seconds = (t % 60 ).ToString("f2");
		return minutes + ":" + seconds;
	}
}
