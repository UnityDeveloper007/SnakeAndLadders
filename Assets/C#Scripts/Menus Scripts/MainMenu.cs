using UnityEngine;
public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject MainMenuParent;
    [SerializeField]
    private GameObject MainMenuOptionsParent;
    [SerializeField]
    private Scenes StartSceneindex;
    public void Volume(float Volume)
    {
        Debug.Log($"this is the current Volume level: {Volume}");
    }
    public void ExitGameAction()
    {
        Application.Quit();
    }
    public void OptionsAction()
    {
        MainMenuParent.SetActive(false);
        MainMenuOptionsParent.SetActive(true);
    }
    public void NewGameAction()
    {
        string SceneName = AddSpace(StartSceneindex.ToString());
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
    }
    private string AddSpace(string text)
    {
        string Word = text;
        if (Word.Contains("_"))
        {
            return Word.Replace("_", " ");
        }
        return Word;
    }
    public void LoadGameAction()
    {
        //still need to confrim on saving method and all related Features and Functionalities
    }
    public void OptionsBackAction()
    {
        MainMenuOptionsParent.SetActive(false);
        MainMenuParent.SetActive(true);
    }
}
