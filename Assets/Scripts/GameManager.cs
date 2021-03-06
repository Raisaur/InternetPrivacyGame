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
    int upgrade_level;

    public List<ProfileBase> profile_list;
    ProfileBase current_profile;
    int current_profile_index;

    int currency = 0;
    [SerializeField]
    int points_multiplier;

    bool once = false;
    bool promo_box_move = false;
    public bool has_seen_rumors = false;

    SoundManager sm;

    public PromoteScript promote_box;

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

        if (promo_box_move == true && promote_box.IsMoving() == false) {
            if (promote_box.IsShowing() == false)
            {
                has_seen_rumors = true;
                Debug.Log("Has seen rumors");
            }
        }
        promo_box_move = promote_box.IsMoving();
    }

    public void GiveAd(VarRef.Topic ad_topic)
    {
        int awarded_points = 0;
        if (current_profile.points_ref.TryGetValue(ad_topic, out awarded_points))
        {
            awarded_points = current_profile.points_ref[ad_topic];
        }
        float global_rand = Random.Range(0.95f, 1.05f);
        float upgrade_bonus = 1.0f;
        if (upgrade_level == 1)
            upgrade_bonus = 1.4f;
        else if (upgrade_level == 2)
            upgrade_bonus = 1.7f;

        int bonus = (int)((((awarded_points*awarded_points) * points_multiplier) * upgrade_bonus) * global_rand);
        if (bonus < 200) bonus = 0;

        if (bonus > 700)
            sm.PlayLotsOfMoneySound();

        else if (bonus <= 0)
            sm.PlayNoMoneySound();

        else
            sm.PlayLittleMoneySound();

        currency += bonus;

        if (!once && has_seen_rumors)
        {
            if (currency > upgrade_costs[upgrade_costs.Length - 1] && upgrade_level == 2)
            {
                once = true;
                promote_box.SetText2();
                promote_box.DisplayShow();
            }
        }

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
        if (current_profile_index < profile_list.Count)
        {
            current_profile = profile_list[current_profile_index];
        }

        else
            gameObject.GetComponent<ButtonManager>().exit_box.SetActive(true);
    }

    public int GetCurrency() { return currency; }

    public void SubtractCurrency (int sub) 
    {
        currency -= sub;
        currency_text.text = currency.ToString();
    }

    public int GetUpgradeCost(int upgradeNumber) { return upgrade_costs[upgradeNumber]; }

    public void SetUpgradeLevel(int upgradeLevel)
    {
        upgrade_level = upgradeLevel;
    }
}
