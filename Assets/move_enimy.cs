using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_enimy : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 2;
    int MaxDist = 10;
    float MinDist = 0.3f;

      Animator animy;
    // Start is called before the first frame update
    void Start()
    {
        animy = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);

        animy.SetBool("kill", false);

        if ((Vector3.Distance(transform.position, Player.position) >= MinDist ) && animy.GetBool("kill") == false)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            animy.SetBool("atk",false);
            animy.SetBool("runn", true);


            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                animy.SetBool("atk", true);
            }

        }
    }
}
