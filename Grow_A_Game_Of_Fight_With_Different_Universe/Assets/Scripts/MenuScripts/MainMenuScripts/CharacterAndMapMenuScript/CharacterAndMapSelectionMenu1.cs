using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CharacterAndMapSelectionMenu : MonoBehaviour
{
    [SerializeField] private Button backButton;

    [SerializeField] private Animator mainMenuAnimator;
    [SerializeField] private Animator CharacterMenuAnimator;
    [SerializeField] private Animator MapMenuAnimator;
    [SerializeField] private Animator ReadyAnimator;

    [SerializeField] private Button char1, char2, char3, char4, char5;

    [SerializeField] private Button Map1, Map2, Map3;

    [SerializeField] private Button PlayerCharacterChoice;
    [SerializeField] private Button PlayerMapChoice;

    [SerializeField] private Image characterImage;
    [SerializeField] private Image MapImage;

    [SerializeField] private Animator readyAnim;

    void Start()
    {
        char1.onClick.AddListener(() => ChooseCharacter(char1));
        char2.onClick.AddListener(() => ChooseCharacter(char2));
        char3.onClick.AddListener(() => ChooseCharacter(char3));
        char4.onClick.AddListener(() => ChooseCharacter(char4));
        char5.onClick.AddListener(() => ChooseCharacter(char5));

        Map1.onClick.AddListener(() => MapSelection(Map1));
        Map2.onClick.AddListener(() => MapSelection(Map2));
        Map3.onClick.AddListener(() => MapSelection(Map3));
    }


    void Update()
    {
        
    }


    public void ChooseCharacter(Button SelectedCharacter)
    {
        PlayerCharacterChoice = SelectedCharacter;
        CharacterMenuAnimator.SetTrigger("IsTriggerMidleToLeft");
        MapMenuAnimator.SetTrigger("IsTriggerRightToMidle");
    }

    public void BackButtonClick()
    {
        CharacterMenuAnimator.SetTrigger("IsTriggerMidleToRight");
        mainMenuAnimator.SetTrigger("IsTriggerLeftToMidle");
    }

    public void MapSelection(Button selectedMap)
    {
        PlayerMapChoice = selectedMap;
        ReadyAnimator.SetTrigger("IsTriggerRightToMidle");
        MapMenuAnimator.SetTrigger("IsTriggerMidleToLeft");
        characterImage.sprite = PlayerCharacterChoice.GetComponentInParent<Image>().sprite;
        MapImage.sprite = PlayerMapChoice.GetComponentInParent<Image>().sprite;
    }


    public void MapMenuBackButtonClick()
    {
        MapMenuAnimator.SetTrigger("IsTriggerMidleToRight");
        CharacterMenuAnimator.SetTrigger("IsTriggerLeftToMidle");
    }

    public void BackReadyButtonClick()
    {
        ReadyAnimator.SetTrigger("IsTriggerMidleToRight");
        MapMenuAnimator.SetTrigger("IsTriggerLeftToMidle");
    }

    private void ReadyToChangeScene()
    {
        readyAnim.SetTrigger("ButtonPressed");
    }

}
