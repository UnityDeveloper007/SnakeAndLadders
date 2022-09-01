using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using System.Collections.Generic;
public class MainMenu : MonoBehaviour
{
    private Resolution[] resolutions;
    [SerializeField]
    private GameObject MainMenuParent;
    [SerializeField]
    private GameObject MainMenuOptionsParent;
    [SerializeField]
    private Scenes StartSceneindex;
    [SerializeField]
    private AudioMixer MainAudioMixer;
    [SerializeField]
    private TMP_Dropdown ScreenResolutionsDropdown;
    private void Start()
    {
        int CurrentScreenIndex;
        resolutions = Screen.resolutions;
        ScreenResolutionsDropdown.ClearOptions();
        List<string> screenResolutionsList = ConvertArrayToListResolutions(resolutions, out CurrentScreenIndex);
        ScreenResolutionsDropdown.AddOptions(screenResolutionsList);
        ScreenResolutionsDropdown.value = CurrentScreenIndex;
        ScreenResolutionsDropdown.RefreshShownValue();
    }
    /// <summary>
    /// this selects the Correct Resolution
    /// </summary>
    /// <param name="ScreenResIndex">
    /// the actual Chosen Resolution</param>
    public void SetResolution(int ScreenResIndex)
    {
        Resolution resolution = resolutions[ScreenResIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    /// <summary>
    /// this method changes 
    /// the screen mode
    /// </summary>
    /// <param name="isFullScreen">
    /// a boolean if the screen is 
    /// in fullscreen</param>
    public void SetScreenMode(bool isFullScreen) { Screen.fullScreen = isFullScreen; }
    /// <summary>
    /// this method sets 
    /// the grahpics quality 
    /// </summary>
    /// <param name="qualityIndex">
    /// the index of the quality</param>
    public void SetGraphicsQuality(int qualityIndex) { QualitySettings.SetQualityLevel(qualityIndex); }
    /// <summary>
    /// set the volume 
    /// across the game
    /// </summary>
    /// <param name="Volume">
    /// the volume level to set</param>
    public void SetVolume(float Volume)
    {
        MainAudioMixer.SetFloat("GameVolume", Volume);
        //Debug.Log($"this is the current Volume level: {Volume}");
    }
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
    /// <summary>
    /// changes the defualt Unity screen Resolutions array 
    /// to a list and grabs the current Screen Index
    /// </summary>
    /// <param name="ScreenResolutions">the screen resolution</param>
    /// <returns>a list of all available Screen Resolutions</returns>
    private List<string> ConvertArrayToListResolutions(Resolution[] ScreenResolutions, out int CurrentScreenResolution)
    {
        CurrentScreenResolution = 0;
        List<string> ResolutionsList = new List<string>();
        for (int i = 0; i < ScreenResolutions.Length; i++)
        {
            ResolutionsList.Add($"{ScreenResolutions[i].width} X {ScreenResolutions[i].height}");
            if(ScreenResolutions[i].width == Screen.currentResolution.width 
                && ScreenResolutions[i].height == Screen.currentResolution.height)
            {
                CurrentScreenResolution = i;
            }
        }
        return ResolutionsList;
    }
}
