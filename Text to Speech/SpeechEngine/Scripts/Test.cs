using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
///     Author : Mamadou Cisse
///     
///     Description :
///         Engine test class
/// </summary>
public class Test : MonoBehaviour {


    public Toggle toggle;
    public Slider pitchSlider;
    public Slider speechRateSlider;

    public InputField input;
    public Button button;

    // you can add others languages //Locale.SPANISH
    private Locale[] languages = { Locale.FRENCH, Locale.ENGLISH, Locale.GERMAN };

    void Start()
    {
        SpeechEngine.AddListeners(toggle, pitchSlider, speechRateSlider);
    }

    public void click()
    {
        SpeechEngine.Speak(input.text);
    }


	public void click2(){

		SpeechEngine.Speak ("Wir Leist Zeitung");
	}

	public void click3(){

		SpeechEngine.Speak ("Du Bist Eine Genie");
	}

    public void SetLanguage(int index)
    {
        SpeechEngine.SetLanguage(languages[index]);
    }
}
