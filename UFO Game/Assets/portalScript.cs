using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalScript : MonoBehaviour
{
    public bool portalUnlocked = false;
    public Animator anim;
    public GameObject portal;
    public GameObject UFO;
    public GameObject ufoportal;
    public string nextScene;



    List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();


    void Update()
    {
        if (portalUnlocked is true)
        {
            portal.GetComponent<AudioSource>().enabled = true;
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
            StartCoroutine(timer());



        }
    }

    IEnumerator timer()
    {
        Instantiate(ufoportal, UFO.transform.position, UFO.transform.rotation);
        Destroy(UFO);

        yield return new WaitForSeconds(10);

        scenesToLoad.Add(SceneManager.LoadSceneAsync(nextScene));


    }
}
