using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light directionalLight;
    public float secondsInFullDay = 120f;

    [Range(0, 1)]
    public float currentTimeOfDay = 0;
    
    public float timeMultiplier = 1f;

    float timeSinceStart = 0f;

    void Update()
    {
        timeSinceStart += Time.deltaTime * timeMultiplier;
        currentTimeOfDay = timeSinceStart % secondsInFullDay / secondsInFullDay;

        UpdateSun();
    }

    void UpdateSun()
    {
        // convert the range 0-1 to 0-360 degrees
        float angle = currentTimeOfDay * 360f;
        directionalLight.transform.rotation = Quaternion.Euler(angle, 180, 0);
    }
}