using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    Transform meteorHolder;
    Animator meteorAnimator;
    void Start(){
        meteorHolder = transform.parent;
        meteorAnimator = GetComponent<Animator>();
    }

    public void RandomizeMeteor(){
        float angle = Random.Range(0f,360f);
        meteorHolder.RotateAround(meteorHolder.position,Vector3.forward,angle);
    float scale = Random.Range(0.8f,1.4f);
    meteorHolder.localScale = new Vector3(scale, scale, scale);

    float speed = Random.Range(1f,2f);
    meteorAnimator.speed = speed;
    }

}
