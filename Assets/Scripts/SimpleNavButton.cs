using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SimpleNavButton : MonoBehaviour
{
    public int sceneNumber;
    public Button navButton;

    private void Start()
    {
        if(navButton != null)
        {
            Button btn = navButton.GetComponent<Button>();
            btn.onClick.AddListener(NavigateScene);
        }
        else
        {
            Debug.LogWarning("Please add a navButton object referance to: " + this.name);
        }
        
    }

    void NavigateScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
