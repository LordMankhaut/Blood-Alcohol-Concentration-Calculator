using UnityEngine;

namespace MaterialDesignTemplates
{
    public class Fader 
    {
        const float 
            alphaIn = 1f,        
            alphaOut = 0f;

        private float time = 0.25f;

        Color newColor;
        
        public void FadeIn ( ref Color oldColor )
        {
            newColor = new Color( oldColor.r, oldColor.g, oldColor.b, alphaIn );
            oldColor = Fade( newColor );
        }

        public void FadeOut ( ref Color oldColor )
        {
            newColor = new Color ( oldColor.r, oldColor.g, oldColor.b, alphaOut );
            oldColor = Fade ( oldColor );
            newColor = oldColor;
            FadeIn ( ref oldColor );
        }

        private Color Fade ( Color oldColor )
        {
            if ( oldColor == newColor )
            {
                throw new System.Exception ( "The colors are the same. Fading in or out unnecessarily. Check the method being called." );
            }
            return Color.Lerp ( oldColor, newColor, time );            
        }
    }
}