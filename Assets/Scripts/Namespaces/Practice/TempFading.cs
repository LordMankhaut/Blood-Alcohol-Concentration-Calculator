using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Practice
{
    //Copied to DarkFader and modified for its use.
    public class TempFading : MonoBehaviour
    {
        public Image image;
        public Color color1;
        public Color color2;

        private void Awake()
        {
            image = GetComponent<Image>();
        }

        private void Start()
        {
            color1 = new Color(1, 1, 1, 0);
            color2 = new Color(1, 1, 1, 1);

        }

        //Called from outside class.
        public void StartFade()
        {
            print("TempFading.StartFade()");
            StartCoroutine(FadeImageInAndOut());
        }

        public IEnumerator FadeImageInAndOut()
        {
            float elapsedTime = 0f;
            float totalTime = 1.0f;
            while (elapsedTime < totalTime)
            {
                elapsedTime += UnityEngine.Time.deltaTime;
                image.color = Color.Lerp(color1, color2, (elapsedTime / totalTime));
                print(elapsedTime);
                print(image.color);
                yield return null;
            }

            elapsedTime = 0f;

            yield return new WaitForSeconds(0.5f);

            while (elapsedTime < totalTime)
            {
                elapsedTime += UnityEngine.Time.deltaTime;
                image.color = Color.Lerp(color2, color1, (elapsedTime / totalTime));
                print(elapsedTime);
                print(image.color);
                yield return null;
            }
        }
    }
}
