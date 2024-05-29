using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public Button nextButton;
    public Button backButton;
    public Button closeButton;
    public TMP_Text descriptionText;
    public GameObject tutorialPanel;
    public List<string> descriptionMessages = new List<string>();

    int descriptionMessageIndex = 0;

    private void Start()
    {
        CameraMove.singleton.enabled = false;
        OnNavigationButton(0);
        nextButton.onClick.AddListener(delegate { OnNavigationButton(1); });
        backButton.onClick.AddListener(delegate { OnNavigationButton(-1); });
        closeButton.onClick.AddListener(OnCloseButton);
    }

    void OnNavigationButton(int increment)
    {
        descriptionMessageIndex += increment;
        descriptionText.text = descriptionMessages[descriptionMessageIndex];
        if (descriptionMessageIndex >= descriptionMessages.Count - 1)
        {
            closeButton.gameObject.SetActive(true);
            nextButton.gameObject.SetActive(false);
        }
        else
        {
            closeButton.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(true);
        }
        if (descriptionMessageIndex <= 0) backButton.gameObject.SetActive(false);
        else backButton.gameObject.SetActive(true);
    }

    void OnCloseButton()
    {  
        tutorialPanel.SetActive(false);
        CameraMove.singleton.enabled = true;
    }
}
