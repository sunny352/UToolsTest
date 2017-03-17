using System.Collections;
using System.IO;
using UnityEngine;

public class TestZipUtil : MonoBehaviour
{
	void Start()
	{
		Directory.CreateDirectory(Application.persistentDataPath + "/test");
		using (StreamWriter writer = File.CreateText(Application.persistentDataPath + "/test/testfile.txt"))
		{
			writer.WriteLine("Just a test");
		}
		StartCoroutine(Test());
	}
	
	IEnumerator Test()
	{
		yield return StartCoroutine(ZipUtil.Create("test"));
		Debug.Log("Zip Finished");
		yield return StartCoroutine(ZipUtil.Extract("test"));
		Debug.Log("Extract Finished");
	}
}
