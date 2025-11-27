using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public bool locked;

    private Animator anim;

    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
       locked = true; 
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);
        if(!locked && distance < 0.5f)
        {
            //Input allocated scene name here
            SceneManager.LoadScene("Level Two");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            anim.SetTrigger("Open");
            locked = false;
        }
    }

     private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            locked = true;
        }
    }
}
