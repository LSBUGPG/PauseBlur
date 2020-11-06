using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PauseBlur : MonoBehaviour
{
    public PostProcessVolume volume;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            var dof = volume.profile.GetSetting<DepthOfField>();
            dof.enabled.Override(!dof.enabled);
        }
    }
}
