using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Quit : MonoBehaviour
{

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void QuitGame()
    {
         Application.Quit();

    }

    public void ActivateAnimation()
    {
        animator.enabled = true;
    }
}

