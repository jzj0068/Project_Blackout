using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class explosion : MonoBehaviour
{
    public GameObject explode;
    public float time = 2;
    public Animator boom;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());




    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
