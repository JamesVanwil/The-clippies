using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PlayerBehavior : MonoBehaviour
    {
        public float speed = 100f;
        public float timer = 0f;
        public float timerLength = 0.5f;

        public bool movementEnabled = true;

        public GameObject wrong;
        public GameObject right;

        public TextBehaviour textScript;


        // Start is called before the first frame update
    void Start()
        {
        textScript = GameObject.Find("text stuff").GetComponent<TextBehaviour> ();
        }

        // Update is called once per frame
        void Update()
        {

            if (movementEnabled)
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetMouseButton(0))
                {
                    transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
                }

                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetMouseButton(1))
                {
                    transform.position += new Vector3(1 * speed * Time.deltaTime, 0, 0);
                }
            }
            else
            {
                //timer to give time for the player to let go of the button
                if (timer < timerLength)
                {
                    timer += 1 * Time.deltaTime;
                }
                else
                {
                    timer = 0;
                    movementEnabled = true;
                }

                //for (int _i = 0, _i < timerLength, _i++)
                //{

                //}
                //else
                //{
                //    movementEnabled = true;
                //}
            }




            //if (Input.GetKeyDown(KeyCode.A))
            //{
            //    aPressed = true;
            //}
            //else if (Input.GetKeyUp(KeyCode.A))
            //{
            //    aPressed = false;
            //}
            //if (aPressed)
            //{
            //    transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
            //}
            //if (Input.GetKeyDown(KeyCode.D))
            //{
            //    transform.position.x += 1 * Time.deltaTime;
            //}
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.transform == wrong.transform)
            {
                movementEnabled = false;
                transform.position = new Vector3(0, 0, -0.8f);
                textScript.ChangeText(0);
            }
            if (collision.transform == right.transform)
            {
                movementEnabled = false;
                transform.position = new Vector3(0, 0, -0.8f);
                textScript.ChangeText(1);
            }
        }
    }

