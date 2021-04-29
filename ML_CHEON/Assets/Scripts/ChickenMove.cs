using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour
{
    float Haxis, Vaxis;
    Vector3 moveVec;
    Animator Anim;
    float nextTime = 0f;

    // Start is called before the first frame update
    private void Awake()
    {
        Anim = GetComponent<Animator>();
    }
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTime)
        {
            Haxis = Random.Range(-1f, 1f);
            Vaxis = Random.Range(-1f, 1f);
            moveVec = new Vector3(Haxis, 0, Vaxis).normalized * Random.Range(0, 2);
            Anim.SetInteger("Walk", 1); 
            nextTime += 2f;
            
        }
        transform.LookAt(transform.localPosition + moveVec);
        transform.localPosition += moveVec * 5f * Time.deltaTime;
        if(Mathf.Abs(transform.localPosition.x)>5 | Mathf.Abs(transform.localPosition.z) > 5)
        {
            transform.localPosition = new Vector3(Random.Range(-4f, 4f), 0f, Random.Range(-4f, 4f));
        }

    }

}
