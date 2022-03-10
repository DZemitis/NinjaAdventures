using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CharacterSkinController : MonoBehaviour
{
    Animator Animator;
    Renderer[] CharacterMaterials;

    [FormerlySerializedAs("albedoList")] public Texture2D[] AlbedoList;
    [FormerlySerializedAs("eyeColors")] [ColorUsage(true,true)]
    public Color[] EyeColors;
    public enum EyePosition { normal, happy, angry, dead}
    [FormerlySerializedAs("eyeState")] public EyePosition EyeState;

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        CharacterMaterials = GetComponentsInChildren<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //ChangeMaterialSettings(0);
            ChangeEyeOffset(EyePosition.normal);
            ChangeAnimatorIdle("normal");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //ChangeMaterialSettings(1);
            ChangeEyeOffset(EyePosition.angry);
            ChangeAnimatorIdle("angry");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //ChangeMaterialSettings(2);
            ChangeEyeOffset(EyePosition.happy);
            ChangeAnimatorIdle("happy");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //ChangeMaterialSettings(3);
            ChangeEyeOffset(EyePosition.dead);
            ChangeAnimatorIdle("dead");
        }
    }

    void ChangeAnimatorIdle(string trigger)
    {
        Animator.SetTrigger(trigger);
    }

    void ChangeMaterialSettings(int index)
    {
        for (int i = 0; i < CharacterMaterials.Length; i++)
        {
            if (CharacterMaterials[i].transform.CompareTag("PlayerEyes"))
                CharacterMaterials[i].material.SetColor("_EmissionColor", EyeColors[index]);
            else
                CharacterMaterials[i].material.SetTexture("_MainTex",AlbedoList[index]);
        }
    }

    void ChangeEyeOffset(EyePosition pos)
    {
        Vector2 offset = Vector2.zero;

        switch (pos)
        {
            case EyePosition.normal:
                offset = new Vector2(0, 0);
                break;
            case EyePosition.happy:
                offset = new Vector2(.33f, 0);
                break;
            case EyePosition.angry:
                offset = new Vector2(.66f, 0);
                break;
            case EyePosition.dead:
                offset = new Vector2(.33f, .66f);
                break;
            default:
                break;
        }

        for (int i = 0; i < CharacterMaterials.Length; i++)
        {
            if (CharacterMaterials[i].transform.CompareTag("PlayerEyes"))
                CharacterMaterials[i].material.SetTextureOffset("_MainTex", offset);
        }
    }
}
