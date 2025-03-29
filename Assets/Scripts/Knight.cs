using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Knight : MonoBehaviour
{
    AudioSource step;
    SpriteRenderer sr;
    Animator animator;
    public float speed = 2;
    public bool canRun = true;
    public bool bigStep = true;
    public AudioClip step1;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        step = GetComponent<AudioSource>();

        step.PlayOneShot(step1);

    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");

        sr.flipX = (direction < 0);
        animator.SetFloat("movement", Mathf.Abs(direction));

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
            canRun = false;
        }

        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }
        
        if  (bigStep == true)
        {
            step.PlayOneShot(step1);
            bigStep = false;
        }
    }

    public void AttackHasFinshed()
    {
        Debug.Log("The attack has finished");
        canRun = true;
    }

    public void Step1()
    {
        
        bigStep = true;
    }

    public void Step2()
    {

    }
}
