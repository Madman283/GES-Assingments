using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController3 : MonoBehaviour
{

    private Light[] lights;
    public int StepOfN;

    // Start is called before the first frame update
    void Start()
    {
        lights = this.GetComponentsInChildren<Light>();
        if (lights == null)
        {
            Debug.LogErrorFormat("There are no lights under {0}", this.name);
            return;
        }
        ClearLights();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ClearLights();
            lights[StepOfN].gameObject.SetActive(true);
            StepOfN++;
            if (StepOfN == lights.Length)
                StepOfN = 0;
        }
        
    }

    private void ClearLights()
    {
        foreach (Light light in lights)
            light.gameObject.SetActive(false);
    }
}
