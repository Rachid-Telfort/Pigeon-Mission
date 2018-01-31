using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class DeathCounter : MonoBehaviour {

    public static int deaths = 0;

    private Text text;

    private void Awake() {
        text = GetComponent<Text>();
    }

    private void Update() {
        text.text = "Pigeons Killed: " + deaths;
    }

}