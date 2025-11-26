using JetBrains.Annotations;
using UnityEngine;

public class Pallina : MonoBehaviour
{
    public float velocitainiziale=5;
    public Rigidbody2D rigidbody;
    void Start()
    {
        
        gameObject.transform.position = Vector3.zero;
        int randomstart=Random.Range(1, 5);
        if (randomstart == 1)
        {
            rigidbody.linearVelocityX = -velocitainiziale;
            rigidbody.linearVelocityY = velocitainiziale;
        }
        else if (randomstart == 2)
        {
            rigidbody.linearVelocityX = velocitainiziale;
            rigidbody.linearVelocityY = velocitainiziale;
        }
        else if (randomstart == 3) 
        {
            rigidbody.linearVelocityX = velocitainiziale;
            rigidbody.linearVelocityY = -velocitainiziale;
        }
        else if (randomstart == 4)
        {
            rigidbody.linearVelocityX = -velocitainiziale;
            rigidbody.linearVelocityY = -velocitainiziale;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="GolSin")
        {
            GameManager score = FindFirstObjectByType<GameManager>();
            score.PunteggioSin();
           
            Start();

        }
        if (collision.tag == "GolDes")
        {
            GameManager score = FindFirstObjectByType<GameManager>();
            score.PunteggioDes();
           
            Start();
        }
    }


    void Update()
    {
        
    }
}
