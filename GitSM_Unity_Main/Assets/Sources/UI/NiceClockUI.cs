using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NiceClockUI : MonoBehaviour {

    private TextMeshProUGUI _text;

    private void Awake () {
        _text = GetComponent<TextMeshProUGUI>();
    }
	
	private void Update () {
        _text.text = string.Format("{0}:{1}", Clock.GetHours(), Clock.GetMinutes());
	}
}
