using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckAnswer : MonoBehaviour
{
    public TMP_InputField TMP_InputField;  // Das Eingabefeld
    public TMP_Text feedbackText;      // Text zur Anzeige der Rückmeldung
    public string correctAnswer = "Unity"; // Die richtige Antwort

    public void CheckInput()
    {
        if (TMP_InputField.text.Trim().ToLower() == correctAnswer.ToLower()) // Vergleicht die Antwort (unabhängig von Groß-/Kleinschreibung)
        {
            feedbackText.text = "Richtig!";
            feedbackText.color = Color.green;
        }
        else
        {
            feedbackText.text = "Falsch! Versuche es erneut.";
            feedbackText.color = Color.red;
        }
    }
}
