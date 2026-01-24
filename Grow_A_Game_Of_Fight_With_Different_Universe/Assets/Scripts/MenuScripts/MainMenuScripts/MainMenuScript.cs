using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private Button PlayButton;
    [SerializeField] private Button SettingsButton;
    [SerializeField] private Button LeaveButton;
    [SerializeField] private Button CreditsButton;

    [SerializeField] private Animator mainMenuAnimator;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject CharacterSelectionMenu;
    [SerializeField] private GameObject mapSelectionMenu;

    [SerializeField] private Animator characterMenuAnimator;

    [SerializeField] private Animator playAnim;
    [SerializeField] private Animator leaveAnim;

    void Start()
    {
        mainMenu.SetActive(true);
        CharacterSelectionMenu.SetActive(true);
        mapSelectionMenu.SetActive(true);
    }

 
    void Update()
    {
        
    }

    public void PlayButtonClick()
    {
        playAnim.SetTrigger("ButtonPressed");
        mainMenuAnimator.SetTrigger("IsTriggerMidleToLeft");
        characterMenuAnimator.SetTrigger("IsTriggerRightToMidle");
    }


    public void LeaveButtonClick()
    {
        leaveAnim.SetTrigger("ButtonPressed");
        Application.Quit();
    }
}
