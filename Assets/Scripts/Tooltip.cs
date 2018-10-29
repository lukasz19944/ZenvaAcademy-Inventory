using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {

    private Text tooltipText;

	// Use this for initialization
	void Start () {
        tooltipText = GetComponentInChildren<Text>();

        gameObject.SetActive(false);
	}

    public void GenerateTooltip(Item item) {
        string startText = "";

        if (item.stats.Count > 0) {
            foreach (var stat in item.stats) {
                startText += "\n" + stat.Key + ": " + stat.Value.ToString();
            }
        }

        string tooltip = string.Format("<b>{0}</b>\n{1}\n{2}", item.title, item.description, startText);
        tooltipText.text = tooltip;
        gameObject.SetActive(true);
    }
	
}
