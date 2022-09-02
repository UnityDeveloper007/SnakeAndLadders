using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using System.Collections.Generic;
public class OptionsMenu : MonoBehaviour
{
    private Resolution[] resolutions;
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
            if (ScreenResolutions[i].width == Screen.currentResolution.width
                && ScreenResolutions[i].height == Screen.currentResolution.height)
            {
                CurrentScreenResolution = i;
            }
        }
        return ResolutionsList;
    }
}
