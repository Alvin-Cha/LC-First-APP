using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_button : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public string trigger_name;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetTriggerNow(){
        _animator.SetTrigger(trigger_name);
    }


}
