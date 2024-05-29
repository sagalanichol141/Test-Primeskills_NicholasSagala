using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public Animator animator;
    public Button danceButton;

    private void Start()
    {
        danceButton.onClick.AddListener(OnDanceButton);
    }

    void OnDanceButton()
    {
        animator.SetTrigger("Dancing");
    }
}
