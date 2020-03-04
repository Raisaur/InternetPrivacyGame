using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
    [SerializeField]
    Texture2D cursor_image;
    [SerializeField]
    Text currency_text;

    public List<ProfileBase> profile_list;
    ProfileBase current_profile;
    int current_profile_index;

    public int upgrade_level;
    int currency = 0;
    [SerializeField]
    int points_multiplier;

    // Start is called before the first frame update
    void Start()
    {
        Vector2Int pointer_offset = new Vector2Int(12, 3);
        Cursor.SetCursor(cursor_image, pointer_offset, CursorMode.ForceSoftware);

        profile_list = gameObject.GetComponent<ProfileManager>().GetProfiles();

        current_profile = profile_list[0];
        current_profile_index = 0;
        upgrade_level = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveAd(VarRef.Topic ad_topic)
    {
        int awarded_points = 0;
        if (current_profile.points_ref.TryGetValue(ad_topic, out awarded_points))
        {
            awarded_points = current_profile.points_ref[ad_topic];
        }

        currency += awarded_points * points_multiplier;
        currency_text.text = currency.ToString();

        LoadNextProfile();
    }

    void LoadNextProfile()
    {
        current_profile_index++;
        current_profile = profile_list[current_profile_index];
    }

    void Upgrade()
    {
        if (upgrade_level == 0)
            upgrade_level = 1;
        else if (upgrade_level == 1)
            upgrade_level = 2;
        else
            return;
    }
}
