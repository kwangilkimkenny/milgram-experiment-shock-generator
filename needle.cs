using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class needle : MonoBehaviour
{
    public const float MAX_SPEED_ANGLE = -200;
    public const float ZERO_SPEED_ANGLE = -60;
    private Transform needleTransform;
    private Transform speedLabelTemplateTransform;


    private float speedMax;
    private float speed;

    private void Awake()
    {
        needleTransform = transform.Find("needle");
        speedLabelTemplateTransform = transform.Find("speedLabelTemplate");
        speedLabelTemplateTransform.gameObject.SetActive(false);

        speed = 0f;
        speedMax = 200f;

        CreateSpeedLabels();
    }

    private void CreateSpeedLabels()
    {
        int labelAmount = 10;
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;
        for (int i = 0; i <= labelAmount; i++ )
        {
           Transform speedLabelTransform = Instantiate(speedLabelTemplateTransform);
            float labelSpeedNormalized = (float)i / labelAmount;
            float speedLabelAngle = ZERO_SPEED_ANGLE - labelSpeedNormalized * totalAngleSize;
            speedLabelTransform.eulerAngles = new Vector3(0, 0, speedLabelAngle);
            speedLabelTemplateTransform.Find("speedText").GetComponent<Text>().text = Mathf.RoundToInt(labelSpeedNormalized * speedMax).ToString();
            speedLabelTransform.Find("speedText").eulerAngles = Vector3.zero;
            speedLabelTransform.gameObject.SetActive(true);
        }
        needleTransform.SetAsLastSibling();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerInput();


        //speed += 30f * Time.deltaTime;
        //if (speed > speedMax) speed = speedMax;
        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
    }

    private void HandlePlayerInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float acceleration = 50f;
            speed += acceleration * Time.deltaTime;
        } else
        {
            float deceleration = 20f;
            speed -= deceleration * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            float brakeSpeed = 100f;
            speed -= brakeSpeed * Time.deltaTime;
        }

        speed = Mathf.Clamp(speed, 0f, speedMax);
    }

    private float GetSpeedRotation()
    {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = speed / speedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }
}
