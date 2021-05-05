// All credit to lilotop on stackexchange. (https://gamedev.stackexchange.com/questions/138311/how-do-i-disable-fog-on-specific-camera-s)

using UnityEngine;

public class NoFog : MonoBehaviour {

    bool doWeHaveFogInScene;

    private void Start() {
        doWeHaveFogInScene = RenderSettings.fog;
    }

    private void OnPreRender() {
        RenderSettings.fog = false;
    }
    private void OnPostRender() {
        RenderSettings.fog = doWeHaveFogInScene;
    }
}