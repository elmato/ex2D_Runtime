// ======================================================================================
// File         : exSoftClipAnimHelper.cs
// Author       : Wu Jie 
// Last Change  : 08/27/2011 | 20:54:58 PM | Saturday,August
// Description  : 
// ======================================================================================

///////////////////////////////////////////////////////////////////////////////
// usings
///////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

///////////////////////////////////////////////////////////////////////////////
// defines
///////////////////////////////////////////////////////////////////////////////

[ExecuteInEditMode]
public class exSoftClipAnimHelper : exSpriteBaseAnimHelper {

    exSoftClip softClip;
    // Vector2 lastCenter = Vector2.zero;
    float lastWidth;
    float lastHeight;

    ///////////////////////////////////////////////////////////////////////////////
    // functions
    ///////////////////////////////////////////////////////////////////////////////

    // ------------------------------------------------------------------ 
    // Desc: 
    // ------------------------------------------------------------------ 

    override protected void Awake () {
        base.Awake();

        softClip = GetComponent<exSoftClip>();
        // lastCenter = softClip.center;
        lastWidth = softClip.width;
        lastHeight = softClip.height;
    }

    // ------------------------------------------------------------------ 
    // Desc: 
    // ------------------------------------------------------------------ 

    override protected void Update () {
        base.Update();

        // if ( lastCenter != softClip.center ) {
        //     lastCenter = softClip.center;
        // }
        if ( lastWidth != softClip.width ) {
            lastWidth = softClip.width;
            softClip.updateFlags |= exPlane.UpdateFlags.Vertex;
        }
        if ( lastHeight != softClip.height ) {
            lastHeight = softClip.height;
            softClip.updateFlags |= exPlane.UpdateFlags.Vertex;
        }
    }
}

