using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    // Movement
    private float movementSpeed;
    public Rigidbody2D rb;
    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundlayers;
    float mx;
    public bool moveright;
    public bool moveleft;
    public bool playerjump;

    //
    public Animator anim;
    private bool isGrounded;
    private bool isJumping;
    private bool KilvenAjastinIsOn;
    public int KilpiNull = 0;
    public int SulkaNull = 0;


    //Sulka buffiin tarvittavia muuttujia
    int hypyt = 0;
    public bool AjastinOn;
    public float AikaRaja = 10.0f;
    public float Ajastin = 0f;

    //Kilpi buffin muuttujat.
    public float KilpiAjastin = 0f;
    public float KilvenAikaRaja = 10.0f;
    public bool KilvenKelloOn;

    // Knockback
    public static PlayerMovement instance;
    float timer;
    //IgnoreTarget

    public string TagToIgnore = "Enemy";



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        AjastinOn = false;
        KilvenKelloOn = false;
        movementSpeed = 8f;

        

    }
    private void Awake()
    {

        instance = this;

    }

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");

        if (moveright == true)
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);

            transform.localScale = new Vector3(2f, 2f, 1f);
        }
        if (moveleft == true)
        {
            transform.Translate(-Vector2.right * movementSpeed * Time.deltaTime);

            transform.localScale = new Vector3(-2f, 2f, 1f);

        }
        if (playerjump && hypyt != 1 && AjastinOn == true)
        {
            {
                anim.SetTrigger("jump");
                Jump();
                playerjump = false;
                hypyt++;

            }
        }
        else if (playerjump && IsGrounded() && AjastinOn == false)
        {
            anim.SetTrigger("jump");
            Jump();
            playerjump = false;

        }
        if (moveright || moveleft || mx != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }


        if (KilvenKelloOn == true)
        {

            KilpiAjastin += Time.deltaTime;
            if (KilvenAikaRaja <= KilpiAjastin)
            {
                KilvenKelloOn = false;
                KilpiAjastin = 0f;
                anim.SetBool("KilvenAjastinIsOn", false);
            }
        }


        if (AjastinOn == true)
        {
            Ajastin += Time.deltaTime;
            if (AikaRaja <= Ajastin)
            {
                AjastinOn = false;
                Ajastin = 0f;

            }

        }

        if (Input.GetButtonDown("Jump") && hypyt != 1 && AjastinOn == true)
        {
            {

                Jump();
                hypyt++;

            }
        }
        else if (Input.GetButtonDown("Jump") && IsGrounded() && AjastinOn == false)
        {
            Jump();
        }




        anim.SetBool("IsGrounded", IsGrounded());
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
        }





        //Hahmon suunnan kääntäminen X akselin perusteella.

        if (mx > 0)
        {
            transform.localScale = new Vector3(2f, 2f, 1f);
        }
        else if (mx < 0)
        {
            transform.localScale = new Vector3(-2f, 2f, 1f);
        }


    }
    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
    }

    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;

    }
    bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.4f, groundlayers);

        if (groundCheck)
        {
            hypyt = 0;
        }

        if (groundCheck != null)
        {
            return true;
        }
        return false;
    }
    //Knockback

    public IEnumerator Knockback(float knockbackDuration, float knockbackPower, Transform obj)
    {

        while (knockbackDuration > timer)
        {
            timer += Time.deltaTime;
            Vector2 direction = (obj.transform.position - this.transform.position).normalized;
            rb.AddForce(-direction * knockbackPower);
        }

        yield return 0; // jos ei palauta arvoa. Niin arvoksi tulee 0.
        timer = 0;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Sulka"))
        {
            AjastinOn = true;
            Ajastin = 0;

            SulkaNull =+ 1;


        }
        if (collision.gameObject.CompareTag("Kilpi"))
        {
            KilvenKelloOn = true;
            KilpiAjastin = 0;

            KilpiNull =+ 1;

        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.tag == TagToIgnore && KilvenKelloOn == true)
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}