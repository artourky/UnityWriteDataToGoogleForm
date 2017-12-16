using UnityEngine;
using System.Collections;

public class WriteDataToGoogle : MonoBehaviour {

    string FORM_URL = "https://docs.google.com/forms/d/e/1FAIpQLScsDMSJZ02K-nM0XNp6QDgEESljeSMCDfuKE9sketLQ2lDnaw/formResponse";

    public string myName;
    public string qNo1;
    public string qNo2;
    public string multipleChoice;
    public string checkedChoice;
    public string checkedChoice2;
    public string checkedChoice3;

    public string dropDown;
    public string linear;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
        if (Input.GetKeyDown(KeyCode.X))
        {
            print("ddue");
            StartCoroutine(SendGoogle(myName, qNo1, qNo2));
        }
	}

    private IEnumerator SendGoogle(string myName, string qNo1, string qNo2)
    {
        WWWForm form = new WWWForm();

        form.AddField("entry.1183936695", myName);
        form.AddField("entry.1812730518", qNo1);
        form.AddField("entry.1226361512", qNo2);
        form.AddField("entry.1539467159", multipleChoice);
        form.AddField("entry.117655203", checkedChoice);
        form.AddField("entry.117655203", checkedChoice2);
        form.AddField("entry.117655203", checkedChoice3);

        // entry.117655203
        form.AddField("entry.654246970", dropDown);
        form.AddField("entry.1296786824", linear);

        byte[] rawData = form.data;

        WWW www = new WWW(FORM_URL, rawData);
        yield return www;
    }
}
