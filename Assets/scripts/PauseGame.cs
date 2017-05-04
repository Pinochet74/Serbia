using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour
{
    public Transform pauseMenu;
    public characterControll cc;
    public bullet bullet;

    void Start()
    {
        cc = GetComponent<characterControll>();
        bullet = GetComponent<bullet>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.gameObject.activeInHierarchy == false)
            {
                pauseMenu.gameObject.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                cc.enabled = false;
                bullet.enabled = false;
            }
            else
            {
                pauseMenu.gameObject.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = true;
                cc.enabled = false;
                bullet.enabled = false;
            }
        }
    }
}
