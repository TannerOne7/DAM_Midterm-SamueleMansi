using JetBrains.Annotations;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Giocatori : MonoBehaviour
{
    public float margine = 4;
    public float vel=10;
    float direzione;
    public Rigidbody2D rigidbody;
    public void PlayerInput_Move(CallbackContext context)
    {
        direzione = context.ReadValue<Vector2>().y;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
        float posAttuale = gameObject.transform.position.y;
        if (posAttuale > margine)
        {
            Vector2 pos = gameObject.transform.position;
            pos.y = margine;
            gameObject.transform.position = pos;

        }
        else if (posAttuale < -margine) 
        {
            Vector2 pos = gameObject.transform.position;
            pos.y = -margine;
            gameObject.transform.position = pos;
        }

            rigidbody.linearVelocityY = direzione * vel;
    }
}
