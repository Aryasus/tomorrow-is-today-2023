using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float dashSpeed;
    private Vector2 direction;
    private Animator animator;
    public Rigidbody2D rigibody;
    bool peutDash = true;
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }
    void Update()
    {

        Move();
        TakeInput();


    }


    private void Move()
        {
            int dash = 1;
            if(Input.GetButtonDown("Jump") && peutDash){
                rigibody.AddForce(direction * dashSpeed);
                StartCoroutine(attenteDash());
            }
            Vector2 pos = rigibody.position;
            pos += direction * speed * Time.deltaTime;
            rigibody.velocity = direction * speed * Time.deltaTime;
            Debug.Log(pos);
            //transform.Translate(direction * speed * Time.deltaTime * dash);

            if (direction.x != 0 || direction.y != 0)
            {
                SetAnimatorMovement(direction);
            }
            else
            {
                animator.SetLayerWeight(1, 0);
            }
        }



        private void TakeInput()
        {
            direction = Vector2.zero;

            if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
            {
                direction += Vector2.up;
            }

            else if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
            {
                direction += Vector2.left;

            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                direction += Vector2.down;

            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                direction += Vector2.right;


            }
            Debug.Log(direction);
            
        }
        private void SetAnimatorMovement(Vector2 direction)
        {
            animator.SetLayerWeight(1, 1);
            animator.SetFloat("xDir", direction.x);
            animator.SetFloat("yDir", direction.y);
            //print("x= " + animator.GetFloat("xDir"));
            //print("y= " + animator.GetFloat("yDir"));
        }    
        
        IEnumerator attenteDash(){
            peutDash = false;
            yield return new WaitForSeconds(2);
            peutDash = true;
        }
}
