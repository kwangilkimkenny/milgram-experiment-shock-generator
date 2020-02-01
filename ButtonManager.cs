using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void btn30()
    {
        Debug.Log("Selected 30 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 0;
    }

    public void btn60()
    {
        Debug.Log("Selected 60 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 1;
    }

    public void btn90()
    {
        Debug.Log("Selected 90 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 2;
    }

    public void btn120()
    {
        Debug.Log("Selected 120 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 3;
    }

    public void btn150()
    {
        Debug.Log("Selected 150 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 4;
    }

    public void btn180()
    {
        Debug.Log("Selected 180 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 5;
    }

    public void bt210()
    {
        Debug.Log("Selected 210 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 6;
    }

    public void btn240()
    {
        Debug.Log("Selected 240 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 7;
    }

    public void btn270()
    {
        Debug.Log("Selected 270 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 8;
    }

    public void btn360()
    {
        Debug.Log("Selected 360 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 9;

    }

    public void btn420()
    {
        Debug.Log("Selected 420 Volt");
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 10;
    }

    public bool ButtonDeactivated = false;
    public void btnxxx()
    {
        ButtonDeactivated = true;
        Debug.Log("Selected xxx Volt");
        //만약 ShockGenerator가 눌러지면 사운드를 실행하라
        //사운드를 실행하라. 오디오 10번을 실행한다.
        FX_Sound_No = 11;

    }

    public AudioSource soundSource;

    /*
    public AudioClip volt30;  // [0]
    public AudioClip volt60;  // [1]
    public AudioClip volt120; // [2]
    public AudioClip volt150; //...
    public AudioClip volt180;
    public AudioClip volt210;
    public AudioClip volt240; //...
    public AudioClip volt270;
    public AudioClip volt360; //...
    public AudioClip volt420;
    public AudioClip voltxxx; // [10]
    */
    bool ActivateShockGenerator = false; // 참이면 활성화됨

    public AudioClip[] Fx_Sound; // 오디오를 배열에 모두 담는다. 0시작하여 10로 총 11개

    public void ShockGenerator() // shockgenerator가 클릭되면
    {
        Debug.Log("Clicked Shock Generator");
        if (ButtonDeactivated == true)
        {
            
            Debug.Log("Shock Generator true");
            ActivateShock(FX_Sound_No);
        }
    }

    int FX_Sound_No;

    void ActivateShock(int FX_Sound_No)
    {
        //soundSource.PlayOneShot(volt30); // 해당클립 사운드 플레이할것
        soundSource.clip = Fx_Sound[FX_Sound_No];
        soundSource.PlayOneShot(Fx_Sound[FX_Sound_No]);
        ActivateShockGenerator = false;
    }


    


}
