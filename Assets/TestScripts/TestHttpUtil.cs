using UnityEngine;

public class TestHttpUtil : MonoBehaviour
{
	void Start()
	{
		StartCoroutine(HttpUtil.Download("http://172.23.3.181/downloads/test.zip", "test.zip", HttpUtil.ENFileExist.enReplace, OnDownloading, OnFinished));
	}

	private void OnDownloading(int current, int total, float progress)
	{
		Debug.LogFormat("Downloaded : {0} Total : {1} Progress : {2}", current, total, progress);
	}
	private void OnFinished(int downloaded)
	{
		Debug.LogFormat("Downloaded : {0} Finished", downloaded);
	}
}
