using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject PauseMenu;

    private bool _activeMenu;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            _activeMenu = !_activeMenu;
            PauseMenu.SetActive(_activeMenu);
        }
    }

    public void StartGame() {
        SceneManager.LoadScene(1);
    }

    public void ExitOptionMenu(GameObject go) {
        go.SetActive(false);
    }

    public void ActiveOptionMenu(GameObject go) {
        go.SetActive(true);
    }
}
