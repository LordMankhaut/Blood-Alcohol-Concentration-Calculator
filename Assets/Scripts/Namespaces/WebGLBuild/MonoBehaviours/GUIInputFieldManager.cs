using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace WebGLBuild
{
    public class GUIInputFieldManager : MonoBehaviour
    {
        private GUIManager guiManager;

        public InputField
            weight,
            volume,
            drinks,
            percent,
            hours;

        private const string defaultEmptyText = "";

        public List<InputField> fields;

        private void Awake()
        {
            guiManager = FindObjectOfType<GUIManager>();
        }


        private void Start()
        {
            fields.Add(weight);
            fields.Add(volume);
            fields.Add(drinks);
            fields.Add(percent);
            fields.Add(hours);
        }

        public void ClearFields()
        {
            foreach (var field in fields)
            {
                field.text = "";
            }
        }

        public void ClearFields(InputField field)
        {
            field.text = "";
        }

        public void ResetAllFields()
        {
            foreach (var field in fields)
            {
                field.text = defaultEmptyText;
            }
        }

        public void WeightInput(string input)
        {
            guiManager.WeightChanged(ParseString(input));
        }

        public void VolumeInput(string input)
        {
            //guiManager.VolumeChanged(ParseString(input));
        }

        private float ParseString(string input)
        {
            float f = float.Parse(input);
            return f;
        }

    }

}
