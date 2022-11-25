using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI InputName;
    public TextMeshProUGUI BestScore;
    public TextMeshProUGUI PlaceHolder;
    // Start is called before the first frame update
    void Start()
    {
        PlaceHolder.text = MemoryManager.Instance.BestPlayerName;


        BestScore.text = $"Ћучший счЄт:{MemoryManager.Instance.BestPlayerName}:{MemoryManager.Instance.BestScore}";
    }



    public void StartNew()
    {
        //Debug.Log(GameObject.Find("InputName").GetComponentInChildren(Text).
        MemoryManager.Instance.playerName = InputName.text;

        SceneManager.LoadScene(1);
    }

    public void Exit()
    {

        MemoryManager.Instance.Save();
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
            Application.Quit(); // original code to quit Unity player
    #endif
    }
}
