using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAfterEffect : MonoBehaviour
{
    public float destroyTime = .5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("destroyAfterSeconds");
    }

    IEnumerator destroyAfterSeconds()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }
}
