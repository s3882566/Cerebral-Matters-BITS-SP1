using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalScript : MonoBehaviour
{
    public bool portalUnlocked = false;

    List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    public void UnlockPortal()
    {
        portalUnlocked = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (portalUnlocked)
        {
            scenesToLoad.Add(SceneManager.LoadSceneAsync("Credits"));
        }
    }
}
