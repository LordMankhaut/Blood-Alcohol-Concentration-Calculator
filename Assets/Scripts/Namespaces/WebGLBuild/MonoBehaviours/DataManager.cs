using UnityEngine;
using System.Collections;

namespace WebGLBuild
{
    public class DataManager : MonoBehaviour
    {
        //public Calculation calculation;

        public void ResetDefaults()
        {
            Gender.Clear();
            Weight.Clear();
            Alcohol.Clear();
            Time.Clear();

            Calculation.GatherData();

        }

        public void UpdateData()
        {
            Calculation.GatherData();
        }

    }
}
