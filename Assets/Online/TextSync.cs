using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using TMPro;
using UnityEngine.UI;

public class TextSync : RealtimeComponent<TextSyncModel>
{
    private TextMeshProUGUI _kommentarText;

    private void Awake()
    {
        //Get a reference to the mesh renderer
        _kommentarText = GetComponent<TextMeshProUGUI>();
    }

    protected override void OnRealtimeModelReplaced(TextSyncModel previousModel, TextSyncModel currentModel)
    {
        if (previousModel != null)
        {
            // Unregister from events
            previousModel.kommentarDidChange -= KommentarDidChange;
        }

        if (currentModel != null)
        {
            // If this is a model that has no data set on it, populate it with the current mesh renderer color.
            if (currentModel.isFreshModel)
                currentModel.kommentar = _kommentarText.text;

            // Update the mesh render to match the new model
            UpdateTextMeshProText();

            // Register for events so we'll know if the color changes later
            currentModel.kommentarDidChange += KommentarDidChange;
        }
    }

    private void KommentarDidChange(TextSyncModel model, string value)
    {
        UpdateTextMeshProText();
    }

    public void UpdateTextMeshProText()
    {
        _kommentarText.text = model.kommentar;
    }

    public void SetText(string text)
    {
        model.kommentar = text;

    }


}
