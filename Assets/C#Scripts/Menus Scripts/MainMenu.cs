using UnityEngine;
public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject MainMenuParent;
    [SerializeField]
    private GameObject MainMenuOptionsParent;
    [SerializeField]
    private Scenes StartSceneindex;
    /// <summary>
    /// quits the game
    /// </summary>
    public void ExitGameAction() { Application.Quit(); }
    /// <summary>
    /// opens options menu
    /// </summary>
    public void OptionsAction()
    {
        MainMenuParent.SetActive(false);
        MainMenuOptionsParent.SetActive(true);
    }
    /// <summary>
    /// goes to the first level
    /// </summary>
    public void NewGameAction()
    {
        string SceneName = AddSpace(StartSceneindex.ToString());
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
    }
    /// <summary>
    /// load the user progress
    /// </summary>
    public void LoadGameAction()
    {
        //still need to confrim on saving method and all related Features and Functionalities
    }
    /// <summary>
    ///  returns to main menu
    /// </summary>
    public void OptionsBackAction()
    {
        MainMenuOptionsParent.SetActive(false);
        MainMenuParent.SetActive(true);
    }
    /// <summary>
    /// it removes the _ in the enum and return it 
    /// as a string with space
    /// </summary>
    /// <param name="text"></param>
    /// <returns>the string with a space</returns>
    private string AddSpace(string text)
    {
        string Word = text;
        if (Word.Contains("_"))
        {
            return Word.Replace("_", " ");
        }
        return Word;
    }
}
