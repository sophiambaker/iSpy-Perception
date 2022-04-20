using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO.Ports;

public class Move : MonoBehaviour
{
    //SerialPort _serialPort = new SerialPort("COM11", 9600);
    Animator animator;
    public Transform player;
    protected bool PlayerInRange;

    // Start is called before the first frame update
    void Start()
    {
       // _serialPort.Open();
        //_serialPort.ReadTimeout = 100;
        animator = transform.GetComponent<Animator>();
       
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            PlayerInRange = true;
            animator.SetBool("isopen", true);

        }
    }

    void OnTriggerExit(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            PlayerInRange = false;
            animator.SetBool("isopen", false);

        }
    }

    // Update is called once per frame
    void Update()
    {

        //if (_serialPort.IsOpen)
        {
            //try
            {
                //if (_serialPort.ReadByte() == 1)
                {
                    //print(_serialPort.ReadByte());
                    //transform.Translate(5 * Time.deltaTime * Vector3.forward);
                }
                //if (_serialPort.ReadByte() == 2)
                {
                    //print(_serialPort.ReadByte());
                    //transform.Translate(5 * Time.deltaTime * Vector3.left);
                }
               // if (_serialPort.ReadByte() == 3)
                {
                    //print(_serialPort.ReadByte());
                    //transform.Translate(5 * Time.deltaTime * Vector3.back);
                }
                //if (_serialPort.ReadByte() == 4)
                {
                    //print(_serialPort.ReadByte());
                    //transform.Translate(5 * Time.deltaTime * Vector3.right);
                }
                //if (_serialPort.ReadByte() == 5)
                {
                    //print(_serialPort.ReadByte());
                    //animator.SetBool("Expand", true);
                    //animator.SetBool("isopen", true);
                }
                
               


            }
            //catch (System.Exception)
            {

            }

        }
    }
}