using UnityEngine;

public class ReadCSV : MonoBehaviour {

	public TextAsset sheetCSV;

	bool doIhaveCSV;

	// Use this for initialization
	void Start () {
		if (sheetCSV) {
			doIhaveCSV = true;
			print("[ReadCSV] Press '`' to start reading the file.");
		} else
			print("[ReadCSV] no csv or txt file attached!");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.BackQuote))
		{
			print("[ReadCSV] Start reading...");
			ParseTxtAsset();
		}
	}

	void ParseTxtAsset() {
		string EVERYTHING = sheetCSV.text;
		string[] lines = EVERYTHING.Split('\n');

		for (int k = 0; k < lines.Length; k++)
		{
			string[] lineStrs = lines[k].Trim().Split(',');
			for (int i = 0; i < lineStrs.Length; i++)
			{
				print("Line " + (k + 1) + ", Word " + (i + 1) + ": " + lineStrs[i]);
			}
		}
	}
}
