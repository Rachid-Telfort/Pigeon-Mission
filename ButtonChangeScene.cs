﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChangeScene : MonoBehaviour {

    public void OnButtonClick(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

}