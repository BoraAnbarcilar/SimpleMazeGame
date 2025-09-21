using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");

        Vector3 movemnet = new Vector3( movex, movey,0f);
        transform.position +=  movemnet * speed * Time.deltaTime;

        
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.CompareTag("exit")) {
        
          Debug.Log("You Win");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        
        
        }
    }
}
