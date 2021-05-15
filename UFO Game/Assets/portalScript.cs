using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalScript : MonoBehaviour
{
    public bool portalUnlocked = false;
    public Animator anim;



    List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();


    void Update()
    {
        if (portalUnlocked is true)
        {
            anim.SetBool("portalactive", true);
        }
    }

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
