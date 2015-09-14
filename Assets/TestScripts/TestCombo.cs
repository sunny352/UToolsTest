using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestCombo : MonoBehaviour
{
	public Text text;
	private ComboCounter m_counter;
	void Start()
	{
		text.text = "无";

		m_counter = new ComboCounter();
		m_counter.Duration = 1.0f;
		m_counter.onBegin = OnBegin;
		m_counter.onIncrease = OnIncrease;
		m_counter.onEnd = OnEnd;
	}
	public void Record()
	{
		m_counter.Record();
	}
	void FixedUpdate()
	{
		m_counter.FixedUpdate();
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
