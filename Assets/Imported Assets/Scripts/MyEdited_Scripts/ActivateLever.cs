using UnityEngine;

public class ActivateLever : MonoBehaviour
{
    [SerializeField] private GameObject[] objectToActivate = new GameObject[1];
    [SerializeField] private Animator animator;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
			for (int i = 0; i < objectToActivate.Length; i++)
			{
				objectToActivate[i].SetActive(true);
			}
        }
        animator.SetBool("isTriggered", true);
    }
}
