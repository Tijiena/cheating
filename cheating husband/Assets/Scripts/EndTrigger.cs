using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{ 
    public GameObject cardInteractHint;
    public GameObject giftcard;
    public float speedScale = 0.05f;
    public Color fadeColor = Color.black;
    public AnimationCurve Curve = new AnimationCurve(new Keyframe(0, 0), 
                                                      new Keyframe(1, 1));
    private bool isInTrigger = false;
    private float alpha = 0f;
    private Texture2D texture;
    private float direction = 0f;
    private float time = 0.0f;
    private bool isFading = false;  // Flag to indicate if the fading process is active
     public GameObject blackScreen;
    void Start(){
        cardInteractHint.SetActive(false);
        giftcard.SetActive(false);
        blackScreen.SetActive(false);
        texture = new Texture2D(1, 1);
        texture.SetPixel(0, 0, fadeColor);
        texture.Apply();
    }

   private void Update(){
          if (isInTrigger && Input.GetKeyDown(KeyCode.E))
    {
        giftcard.SetActive(true);
        StartCoroutine(ExitScreen());
    }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInTrigger = true;
            cardInteractHint.SetActive(true);
            Debug.Log("Player has entered the trigger zone!");
           
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cardInteractHint.SetActive(false);
            Debug.Log("Player has left the trigger zone!");
        }
    }

    IEnumerator ExitScreen(){
        yield return new WaitForSeconds(4);
        direction = 1f;  // Initiate the fade
        isFading = true; // Start the fading process
        StartCoroutine(BlackScreen(1.0f));
    }

    void OnGUI()
    {
        if (isFading)
        {
            time += Time.deltaTime / 2 * speedScale * direction;
            alpha = Curve.Evaluate(time);
            texture.SetPixel(0, 0, new Color(fadeColor.r, fadeColor.g, fadeColor.b, alpha));
            texture.Apply();
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), texture);

            // Once fully opaque, ensure the screen stays black
            if (alpha >= 1f) {
                isFading = false;  // Stop updating time and alpha
                direction = 0f;    // Ensures no further evaluation changes
                texture.SetPixel(0, 0, new Color(fadeColor.r, fadeColor.g, fadeColor.b, 1f));
                texture.Apply();   // Set the texture to fully opaque black permanently
            }
        }
    }

    IEnumerator BlackScreen(float delay){
       // float delay = 0.5f;
        yield return new WaitForSeconds(delay);
        blackScreen.SetActive(true);
        //SceneManager.LoadScene("end_scene");
        
    }
}
