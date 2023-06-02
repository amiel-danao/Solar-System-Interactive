using UnityEngine;

public class GyroscopeController : MonoBehaviour
{
    private Gyroscope gyroscope;

    void Start()
    {
        // Check if the gyroscope is available
        if (SystemInfo.supportsGyroscope)
        {
            gyroscope = Input.gyro;
            gyroscope.enabled = true;
        }
        else
        {
            Debug.Log("Gyroscope not supported on this device");
        }
    }

    void Update()
    {
        // Check if the gyroscope is available
        if (gyroscope != null)
        {
            // Get the rotation rate from the gyroscope
            Vector3 rotationRate = gyroscope.rotationRate;
            float x = rotationRate.x;
            float y = rotationRate.y;
            float z = rotationRate.z;

            // Use the rotation rate values as desired
            // For example, print them to the console
            Debug.Log("Gyroscope Rotation Rate: " + x + ", " + y + ", " + z);
        }
    }
}
