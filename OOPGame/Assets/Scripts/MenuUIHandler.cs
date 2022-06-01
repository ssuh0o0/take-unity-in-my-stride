using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif 

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;

    public void NewColorSelected(Color color)
    {
        // add code here to handle when a color is selected
    }
    
    private void Start()
    {
        ColorPicker.Init();
        //this will call the NewColorSelected function when the color picker have a color button clicked.
        ColorPicker.onColorChanged += NewColorSelected;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
    // 코드가 editor 내에서 컴파일되면 UNITY_EDITOR가 true면 코드 유지
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    // 플레이어를 빌드할 때 UNITY_EDITOR는 false이므로 아래 코드 유지
    #else 
        Application.Quit();
    #endif
    }
}
