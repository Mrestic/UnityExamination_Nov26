using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{
    [SerializeField] private string nextScene = "";


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") LoadNextScene();
    }

    
    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
