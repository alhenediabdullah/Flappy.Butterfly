using UnityEngine;

public class ButterflyScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float butterStrength;
    public LogicScript logi;
    public bool butterIsAlive = true;
    public float deadZone = -43;
    public float deadZone2 = 40;
    public AudioSource deathSound;


    
    void Start()
    {
        logi = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (!butterIsAlive) return;

        if(transform.position.y < deadZone || transform.position.y > deadZone2)
        {
            Dead();
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && butterIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * butterStrength;
        }
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(butterIsAlive)
        {
            Dead();
        }

    }

    public void Dead()
    {
        butterIsAlive = false;
        GameManager.gameSpeed = 0f;

        if (deathSound != null)
        {
            deathSound.Play();
        }
        logi.gameOver();
        Time.timeScale = 0f;
    }
}
