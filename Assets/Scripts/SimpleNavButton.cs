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
        Button btn = navButton.GetComponent<Button>();
        btn.onClick.AddListener(NavigateScene);
    }

    void NavigateScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
