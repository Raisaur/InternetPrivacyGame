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
    [SerializeField]
    Text currency_add_text;
    float add_timer = 0.0f;

    [SerializeField]
    int[] upgrade_costs;
    

    public List<ProfileBase> profile_list;
    ProfileBase current_profile;
    int current_profile_index;

    int currency = 0;
    [SerializeField]
    int points_multiplier;

    SoundManager sm;

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();

        Vector2Int pointer_offset = new Vector2Int(12, 3);
        Cursor.SetCursor(cursor_image, pointer_offset, CursorMode.ForceSoftware);

        profile_list = gameObject.GetComponent<ProfileManager>().GetProfiles();

        current_profile = profile_list[0];
        current_profile_index = 0;
        gameObject.GetComponent<ProfileManager>().DisplayProfile(current_profile);
        currency_add_text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            sm.PlayClickSound();

        if (add_timer > 0)
            add_timer -= Time.deltaTime;
        if (add_timer < 0)
            currency_add_text.gameObject.SetActive(false);
    }

    public void GiveAd(VarRef.Topic ad_topic)
    {
        int awarded_points = 0;
        if (current_profile.points_ref.TryGetValue(ad_topic, out awarded_points))
        {
            awarded_points = current_profile.points_ref[ad_topic];
        }
        float global_rand = Random.Range(0.95f, 1.05f);

        int bonus = (int)(((awarded_points*awarded_points) * points_multiplier) * global_rand);
        currency += bonus;
        currency_text.text = currency.ToString();

        currency_add_text.text = "+" + bonus;
        currency_add_text.gameObject.SetActive(true);
        add_timer = 1.3f;

        LoadNextProfile();
        gameObject.GetComponent<ProfileManager>().DisplayProfile(current_profile);
    }

    void LoadNextProfile()
    {
        current_profile_index++;
        current_profile = profile_list[current_profile_index];
    }

    public int GetCurrency() { return currency; }

    public void SubtractCurrency (int sub) 
    {
        currency -= sub;
        currency_text.text = currency.ToString();
    }

    public int GetUpgradeCost(int upgradeNumber) { return upgrade_costs[upgradeNumber]; }

}
