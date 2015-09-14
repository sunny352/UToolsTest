using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(ComboCounterMono))]
public class TestComboMono : MonoBehaviour
{
	public Text text;
	void Start()
	{
		text.text = "无";

		ComboCounterMono mono = GetComponent<ComboCounterMono>();
		mono.onBegin = OnBegin;
		mono.onIncrease = OnIncrease;
		mono.onEnd = OnEnd;
	}
	public void Record()
	{
		ComboCounterMono mono = GetComponent<ComboCounterMono>();
		mono.Record();
	}
	private void OnBegin()
	{
		Debug.LogFormat("OnBegin");
	}
	private void OnIncrease(int current)
	{
		text.text = string.Format("{0}", current);
	}
	private void OnEnd(int current)
	{
		text.text = "无";
		Debug.LogFormat("OnEnd");
	}
}
