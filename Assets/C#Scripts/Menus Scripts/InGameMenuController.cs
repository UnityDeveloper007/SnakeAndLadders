using UnityEngine;
public class InGameMenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject InGameMenuParent;
    [SerializeField]
    private GameObject InGameMenuOptionsParent;
    public void ExitGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
    public void OptionsAction()
    {
        InGameMenuParent.SetActive(false);
        InGameMenuOptionsParent.SetActive(true);
    }
    public void ResumeAction()
    {
        InGameMenuParent.SetActive(false);
    }
    public void CloseOptionsMenuAction()
    {
        InGameMenuOptionsParent.SetActive(false);
        InGameMenuParent.SetActive(true);
    }
    public void OpenGameMenu()
    {
        if(!InGameMenuOptionsParent.activeSelf)
            InGameMenuParent.SetActive(!InGameMenuParent.activeSelf);
        else
            InGameMenuOptionsParent.SetActive(!InGameMenuOptionsParent.activeSelf);
    }
}
