using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public GameObject sphere;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scena()
    {
        SceneManager.LoadScene(0);
    }

    public void lvl1()
    {
        SceneManager.LoadScene(1);

    }

    public void lvl2()
    {
        SceneManager.LoadScene(2);

    }

    public void lvl3()
    {
        SceneManager.LoadScene(3);

    }

    public void recarga()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitIT()
    {
        Application.Quit();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            other.transform.position = spawn.position;
        }
    }
}
