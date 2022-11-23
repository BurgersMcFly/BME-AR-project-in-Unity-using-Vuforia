using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lock : MonoBehaviour
{
    private InputField inputTextField;
    public GameObject textDisplay;
    public GameObject inputFieldHolder;
    public GameObject DisableUnlockButton;

    void Start()
    {
        inputTextField = GetComponent<InputField>();
    }
    public void ShowInputField()
    {
        inputFieldHolder.SetActive(true);
        DisableUnlockButton.SetActive(false);
    }
    public void HideInputField()
    {
        inputFieldHolder.SetActive(false);
    }
    public void CheckPassword()
    {
        switch (inputTextField.text)
        {
            case "1324":
                inputTextField.text = "Correct Password!";
                break;

            default:
                inputTextField.text = "";
                inputTextField.text = "Wrong Password!";
                break;
        }
    }
}
