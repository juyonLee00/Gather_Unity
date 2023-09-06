using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePlayerData : MonoBehaviour
{
    private SavePlayerData instance = null;
    //public InputField inputName;
    //sprite종류도 저장

    private void Awake()
    {
        if(instance == null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }
}
