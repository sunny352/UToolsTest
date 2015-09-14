using UnityEngine;
using System.Collections;

public class TestCDManager : MonoBehaviour
{
	public bool[] CDList;
	private CDManager m_cdManager;
	// Use this for initialization
	void Start()
	{
		m_cdManager = new CDManager();
		m_cdManager.RegisterCD(1, 5, OnFinished, OnRefresh);
		m_cdManager.RegisterCD(2, 10, OnFinished, OnRefresh);

		CDList = new bool[m_cdManager.CDList.Count];
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		m_cdManager.OnFixedUpdate();
		for (int index = 0; index < CDList.Length; ++index)
		{
			if (CDList[index])
			{
				if (m_cdManager.CDList[index].IsCDRunning)
				{
					continue;
				}
				else
				{
					m_cdManager.CDList[index].Start();
				}
			}
			else
			{
				if (m_cdManager.CDList[index].IsCDRunning)
				{
					m_cdManager.CDList[index].Clear();
				}
				else
				{
					continue;
				}
			}
		}
	}
	private void OnFinished(int id)
	{
		Debug.LogFormat("{0} is finished", id);
		var cdList = m_cdManager.CDList;
		for (int index = 0; index < CDList.Length; ++index)
		{
			if (cdList[index].ID == id)
			{
				CDList[index] = false;
			}
		}
	}
	private void OnRefresh(int id, float remain)
	{

	}
}
