using System.Collections.Generic;

public enum AnimationGroups
{
    Airport,
    Attractors,
    Bar,
    Baseball,
    Bd_Fire,
    Beach,
    Benchpress,
    Bf_Injection,
    Biked,
    Bikeh,
    Bikeleap,
    Bikes,
    Bikev,
    Bike_Dbz,
    Bmx,
    Bomber,
    Box,
    Bsktball,
    Buddy,
    Bus,
    Camera,
    Car,
    Carry,
    Car_Chat,
    Casino,
    Chainsaw,
    Choppa,
    Clothes,
    Coach,
    Colt45,
    Cop_Ambient,
    Cop_Dvbyz,
    Crack,
    Crib,
    Dam_Jump,
    Dancing,
    Dealer,
    Dildo,
    Dodge,
    Dozer,
    Drivebys,
    Fat,
    Fight_B,
    Fight_C,
    Fight_D,
    Fight_E,
    Finale,
    Finale2,
    Flame,
    Flowers,
    Food,
    Freeweights,
    Gangs,
    Ghands,
    Ghetto_Db,
    Goggles,
    Graffiti,
    Graveyard,
    Grenade,
    Gymnasium,
    Haircuts,
    Heist9,
    Int_House,
    Int_Office,
    Int_Shop,
    Jst_Buisness,
    Kart,
    Kissing,
    Knife,
    Lapdan1,
    Lapdan2,
    Lapdan3,
    Lowrider,
    Md_Chase,
    Md_End,
    Medic,
    Misc,
    Mtb,
    Muscular,
    Nevada,
    On_Lookers,
    Otb,
    Parachute,
    Park,
    Paulnmac,
    Ped,
    Player_Dvbys,
    Playidles,
    Police,
    Pool,
    Poor,
    Python,
    Quad,
    Quad_Dbz,
    Rapping,
    Rifle,
    Riot,
    Rob_Bank,
    Rocket,
    Rustler,
    Ryder,
    Scratching,
    Shamal,
    Shop,
    Shotgun,
    Silenced,
    Skate,
    Smoking,
    Sniper,
    Spraycan,
    Strip,
    Sunbathe,
    Swat,
    Sweet,
    Swim,
    Sword,
    Tank,
    Tattoos,
    Tec,
    Train,
    Truck,
    Uzi,
    Van,
    Vending,
    Vortex,
    Wayfarer,
    Weapons,
    Wuzi
}

public class AnimationList
{
    private static string[] animGroups = new string[]
    {
        "airport",
        "attractors",
        "bar",
        "baseball",
        "bd_fire",
        "beach",
        "benchpress",
        "bf_injection",
        "biked",
        "bikeh",
        "bikeleap",
        "bikes",
        "bikev",
        "bike_dbz",
        "bmx",
        "bomber",
        "box",
        "bsktball",
        "buddy",
        "bus",
        "camera",
        "car",
        "carry",
        "car_chat",
        "casino",
        "chainsaw",
        "choppa",
        "clothes",
        "coach",
        "colt45",
        "cop_ambient",
        "cop_dvbyz",
        "crack",
        "crib",
        "dam_jump",
        "dancing",
        "dealer",
        "dildo",
        "dodge",
        "dozer",
        "drivebys",
        "fat",
        "fight_b",
        "fight_c",
        "fight_d",
        "fight_e",
        "finale",
        "finale2",
        "flame",
        "flowers",
        "food",
        "freeweights",
        "gangs",
        "ghands",
        "ghetto_db",
        "goggles",
        "graffiti",
        "graveyard",
        "grenade",
        "gymnasium",
        "haircuts",
        "heist9",
        "int_house",
        "int_office",
        "int_shop",
        "jst_buisness",
        "kart",
        "kissing",
        "knife",
        "lapdan1",
        "lapdan2",
        "lapdan3",
        "lowrider",
        "md_chase",
        "md_end",
        "medic",
        "misc",
        "mtb",
        "muscular",
        "nevada",
        "on_lookers",
        "otb",
        "parachute",
        "park",
        "paulnmac",
        "ped",
        "player_dvbys",
        "playidles",
        "police",
        "pool",
        "poor",
        "python",
        "quad",
        "quad_dbz",
        "rapping",
        "rifle",
        "riot",
        "rob_bank",
        "rocket",
        "rustler",
        "ryder",
        "scratching",
        "shamal",
        "shop",
        "shotgun",
        "silenced",
        "skate",
        "smoking",
        "sniper",
        "spraycan",
        "strip",
        "sunbathe",
        "swat",
        "sweet",
        "swim",
        "sword",
        "tank",
        "tattoos",
        "tec",
        "train",
        "truck",
        "uzi",
        "van",
        "vending",
        "vortex",
        "wayfarer",
        "weapons",
        "wuzi"
    };

    public string this[AnimationGroups group]
    {
        get { return animGroups[(int)group]; }
    }

    public static Dictionary<AnimationGroups, List<string>> CurAnims { get { return animList; } }

    private static Dictionary<AnimationGroups, List<string>> animList = new Dictionary<AnimationGroups, List<string>>()
    {
        {
            AnimationGroups.Airport,
            new List<string>()
            {
                "thrw_barl_thrw"
            }
        },
        {
            AnimationGroups.Attractors,
            new List<string>()
            {
                "stepsit_in",
                "stepsit_loop",
                "stepsit_out"
            }
        },
        {
            AnimationGroups.Bar,
            new List<string>()
            {
                "barcustom_get",
                "barcustom_loop",
                "barcustom_order",
                "barman_idle",
                "barserve_bottle",
                "barserve_give",
                "barserve_glass",
                "barserve_in",
                "barserve_loop",
                "barserve_order",
                "dnk_stndf_loop",
                "dnk_stndm_loop"
            }
        },
        {
            AnimationGroups.Baseball,
            new List<string>()
            {
                "bat_1",
                "bat_2",
                "bat_3",
                "bat_4",
                "bat_block",
                "bat_hit_1",
                "bat_hit_2",
                "bat_hit_3",
                "bat_idle",
                "bat_m",
                "bat_part"
            }
        },
        {
            AnimationGroups.Bd_Fire,
            new List<string>()
            {
                "bd_fire1",
                "bd_fire2",
                "bd_fire3",
                "bd_gf_wave",
                "bd_panic_01",
                "bd_panic_02",
                "bd_panic_03",
                "bd_panic_04",
                "bd_panic_loop",
                "grlfrd_kiss_03",
                "m_smklean_loop",
                "playa_kiss_03",
                "wash_up"
            }
        },
        {
            AnimationGroups.Beach,
            new List<string>()
            {
                "bather",
                "lay_bac_loop",
                "parksit_m_loop",
                "parksit_w_loop",
                "sitnwait_loop_w"
            }
        },
        {
            AnimationGroups.Benchpress,
            new List<string>()
            {
                "gym_bp_celebrate",
                "gym_bp_down",
                "gym_bp_getoff",
                "gym_bp_geton",
                "gym_bp_up_a",
                "gym_bp_up_b",
                "gym_bp_up_smooth"
            }
        },
        {
            AnimationGroups.Bf_Injection,
            new List<string>()
            {
                "bf_getin_lhs",
                "bf_getin_rhs",
                "bf_getout_lhs",
                "bf_getout_rhs"
            }
        },
        {
            AnimationGroups.Biked,
            new List<string>()
            {
                "biked_back",
                "biked_drivebyft",
                "biked_drivebylhs",
                "biked_drivebyrhs",
                "biked_fwd",
                "biked_getoffback",
                "biked_getofflhs",
                "biked_getoffrhs",
                "biked_hit",
                "biked_jumponl",
                "biked_jumponr",
                "biked_kick",
                "biked_left",
                "biked_passenger",
                "biked_pushes",
                "biked_ride",
                "biked_right",
                "biked_shuffle",
                "biked_still"
            }
        },
        {
            AnimationGroups.Bikeh,
            new List<string>()
            {
                "bikeh_back",
                "bikeh_drivebyft",
                "bikeh_drivebylhs",
                "bikeh_drivebyrhs",
                "bikeh_fwd",
                "bikeh_getoffback",
                "bikeh_getofflhs",
                "bikeh_getoffrhs",
                "bikeh_hit",
                "bikeh_jumponl",
                "bikeh_jumponr",
                "bikeh_kick",
                "bikeh_left",
                "bikeh_passenger",
                "bikeh_pushes",
                "bikeh_ride",
                "bikeh_right",
                "bikeh_still"
            }
        },
        {
            AnimationGroups.Bikeleap,
            new List<string>()
            {
                "bk_blnce_in",
                "bk_blnce_out",
                "bk_jmp",
                "bk_rdy_in",
                "bk_rdy_out",
                "struggle_cesar",
                "struggle_driver",
                "truck_driver",
                "truck_getin"
            }
        },
        {
            AnimationGroups.Bikes,
            new List<string>()
            {
                "bikes_back",
                "bikes_drivebyft",
                "bikes_drivebylhs",
                "bikes_drivebyrhs",
                "bikes_fwd",
                "bikes_getoffback",
                "bikes_getofflhs",
                "bikes_getoffrhs",
                "bikes_hit",
                "bikes_jumponl",
                "bikes_jumponr",
                "bikes_kick",
                "bikes_left",
                "bikes_passenger",
                "bikes_pushes",
                "bikes_ride",
                "bikes_right",
                "bikes_snatch_l",
                "bikes_snatch_r",
                "bikes_still"
            }
        },
        {
            AnimationGroups.Bikev,
            new List<string>()
            {
                "bikev_back",
                "bikev_drivebyft",
                "bikev_drivebylhs",
                "bikev_drivebyrhs",
                "bikev_fwd",
                "bikev_getoffback",
                "bikev_getofflhs",
                "bikev_getoffrhs",
                "bikev_hit",
                "bikev_jumponl",
                "bikev_jumponr",
                "bikev_kick",
                "bikev_left",
                "bikev_passenger",
                "bikev_pushes",
                "bikev_ride",
                "bikev_right",
                "bikev_still"
            }
        },
        {
            AnimationGroups.Bike_Dbz,
            new List<string>()
            {
                "pass_driveby_bwd",
                "pass_driveby_fwd",
                "pass_driveby_lhs",
                "pass_driveby_rhs"
            }
        },
        {
            AnimationGroups.Bmx,
            new List<string>()
            {
                "bmx_back",
                "bmx_bunnyhop",
                "bmx_drivebyft",
                "bmx_driveby_lhs",
                "bmx_driveby_rhs",
                "bmx_fwd",
                "bmx_getoffback",
                "bmx_getofflhs",
                "bmx_getoffrhs",
                "bmx_jumponl",
                "bmx_jumponr",
                "bmx_left",
                "bmx_pedal",
                "bmx_pushes",
                "bmx_ride",
                "bmx_right",
                "bmx_sprint",
                "bmx_still"
            }
        },
        {
            AnimationGroups.Bomber,
            new List<string>()
            {
                "bom_plant",
                "bom_plant_2idle",
                "bom_plant_crouch_in",
                "bom_plant_crouch_out",
                "bom_plant_in",
                "bom_plant_loop"
            }
        },
        {
            AnimationGroups.Box,
            new List<string>()
            {
                "boxhipin",
                "boxhipup",
                "boxshdwn",
                "boxshup",
                "bxhipwlk",
                "bxhwlki",
                "bxshwlk",
                "bxshwlki",
                "bxwlko",
                "catch_box"
            }
        },
        {
            AnimationGroups.Bsktball,
            new List<string>()
            {
                "bball_def_jump_shot",
                "bball_def_loop",
                "bball_def_stepl",
                "bball_def_stepr",
                "bball_dnk",
                "bball_dnk_gli",
                "bball_dnk_gli_o",
                "bball_dnk_lnch",
                "bball_dnk_lnch_o",
                "bball_dnk_lnd",
                "bball_dnk_o",
                "bball_idle",
                "bball_idle2",
                "bball_idle2_o",
                "bball_idleloop",
                "bball_idleloop_o",
                "bball_idle_o",
                "bball_jump_cancel",
                "bball_jump_cancel_o",
                "bball_jump_end",
                "bball_jump_shot",
                "bball_jump_shot_o",
                "bball_net_dnk_o",
                "bball_pickup",
                "bball_pickup_o",
                "bball_react_miss",
                "bball_react_score",
                "bball_run",
                "bball_run_o",
                "bball_skidstop_l",
                "bball_skidstop_l_o",
                "bball_skidstop_r",
                "bball_skidstop_r_o",
                "bball_walk",
                "bball_walkstop_l",
                "bball_walkstop_l_o",
                "bball_walkstop_r",
                "bball_walkstop_r_o",
                "bball_walk_o",
                "bball_walk_start",
                "bball_walk_start_o"
            }
        },
        {
            AnimationGroups.Buddy,
            new List<string>()
            {
                "buddy_crouchfire",
                "buddy_crouchreload",
                "buddy_fire",
                "buddy_fire_poor",
                "buddy_reload"
            }
        },
        {
            AnimationGroups.Bus,
            new List<string>()
            {
                "bus_close",
                "bus_getin_lhs",
                "bus_getin_rhs",
                "bus_getout_lhs",
                "bus_getout_rhs",
                "bus_jacked_lhs",
                "bus_open",
                "bus_open_rhs",
                "bus_pullout_lhs"
            }
        },
        {
            AnimationGroups.Camera,
            new List<string>()
            {
                "camcrch_cmon",
                "camcrch_idleloop",
                "camcrch_stay",
                "camcrch_to_camstnd",
                "camstnd_cmon",
                "camstnd_idleloop",
                "camstnd_lkabt",
                "camstnd_to_camcrch",
                "piccrch_in",
                "piccrch_out",
                "piccrch_take",
                "picstnd_in",
                "picstnd_out",
                "picstnd_take"
            }
        },
        {
            AnimationGroups.Car,
            new List<string>()
            {
                "fixn_car_loop",
                "fixn_car_out",
                "flag_drop",
                "sit_relaxed",
                "tap_hand",
                "tyd2car_bump",
                "tyd2car_high",
                "tyd2car_low",
                "tyd2car_med",
                "tyd2car_turnl",
                "tyd2car_turnr"
            }
        },
        {
            AnimationGroups.Carry,
            new List<string>()
            {
                "crry_prtial",
                "liftup",
                "liftup05",
                "liftup105",
                "putdwn",
                "putdwn05",
                "putdwn105"
            }
        },
        {
            AnimationGroups.Car_Chat,
            new List<string>()
            {
                "carfone_in",
                "carfone_loopa",
                "carfone_loopa_to_b",
                "carfone_loopb",
                "carfone_loopb_to_a",
                "carfone_out",
                "car_sc1_bl",
                "car_sc1_br",
                "car_sc1_fl",
                "car_sc1_fr",
                "car_sc2_fl",
                "car_sc3_br",
                "car_sc3_fl",
                "car_sc3_fr",
                "car_sc4_bl",
                "car_sc4_br",
                "car_sc4_fl",
                "car_sc4_fr",
                "car_talkm_in",
                "car_talkm_loop",
                "car_talkm_out"
            }
        },
        {
            AnimationGroups.Casino,
            new List<string>()
            {
                "cards_in",
                "cards_loop",
                "cards_lose",
                "cards_out",
                "cards_pick_01",
                "cards_pick_02",
                "cards_raise",
                "cards_win",
                "dealone",
                "manwinb",
                "manwind",
                "roulette_bet",
                "roulette_in",
                "roulette_loop",
                "roulette_lose",
                "roulette_out",
                "roulette_win",
                "slot_bet_01",
                "slot_bet_02",
                "slot_in",
                "slot_lose_out",
                "slot_plyr",
                "slot_wait",
                "slot_win_out",
                "wof"
            }
        },
        {
            AnimationGroups.Chainsaw,
            new List<string>()
            {
                "csaw_1",
                "csaw_2",
                "csaw_3",
                "csaw_g",
                "csaw_hit_1",
                "csaw_hit_2",
                "csaw_hit_3",
                "csaw_part",
                "idle_csaw",
                "weapon_csaw",
                "weapon_csawlo"
            }
        },
        {
            AnimationGroups.Choppa,
            new List<string>()
            {
                "choppa_back",
                "choppa_bunnyhop",
                "choppa_drivebyft",
                "choppa_driveby_lhs",
                "choppa_driveby_rhs",
                "choppa_fwd",
                "choppa_getoffback",
                "choppa_getofflhs",
                "choppa_getoffrhs",
                "choppa_jumponl",
                "choppa_jumponr",
                "choppa_left",
                "choppa_pedal",
                "choppa_pushes",
                "choppa_ride",
                "choppa_right",
                "choppa_sprint",
                "choppa_still"
            }
        },
        {
            AnimationGroups.Clothes,
            new List<string>()
            {
                "clo_buy",
                "clo_in",
                "clo_out",
                "clo_pose_hat",
                "clo_pose_in",
                "clo_pose_in_o",
                "clo_pose_legs",
                "clo_pose_loop",
                "clo_pose_out",
                "clo_pose_out_o",
                "clo_pose_shoes",
                "clo_pose_torso",
                "clo_pose_watch"
            }
        },
        {
            AnimationGroups.Coach,
            new List<string>()
            {
                "coach_inl",
                "coach_inr",
                "coach_opnl",
                "coach_opnr",
                "coach_outl",
                "coach_outr"
            }
        },
        {
            AnimationGroups.Colt45,
            new List<string>()
            {
                "2guns_crouchfire",
                "colt45_crouchfire",
                "colt45_crouchreload",
                "colt45_fire",
                "colt45_fire_2hands",
                "colt45_reload",
                "sawnoff_reload"
            }
        },
        {
            AnimationGroups.Cop_Ambient,
            new List<string>()
            {
                "copbrowse_in",
                "copbrowse_loop",
                "copbrowse_nod",
                "copbrowse_out",
                "copbrowse_shake",
                "coplook_in",
                "coplook_loop",
                "coplook_nod",
                "coplook_out",
                "coplook_shake",
                "coplook_think",
                "coplook_watch"
            }
        },
        {
            AnimationGroups.Cop_Dvbyz,
            new List<string>()
            {
                "cop_dvby_b",
                "cop_dvby_ft",
                "cop_dvby_l",
                "cop_dvby_r"
            }
        },
        {
            AnimationGroups.Crack,
            new List<string>()
            {
                "bbalbat_idle_01",
                "bbalbat_idle_02",
                "crckdeth1",
                "crckdeth2",
                "crckdeth3",
                "crckdeth4",
                "crckidle1",
                "crckidle2",
                "crckidle3",
                "crckidle4"
            }
        },
        {
            AnimationGroups.Crib,
            new List<string>()
            {
                "crib_console_loop",
                "crib_use_switch",
                "ped_console_loop",
                "ped_console_loose",
                "ped_console_win"
            }
        },
        {
            AnimationGroups.Dam_Jump,
            new List<string>()
            {
                "dam_dive_loop",
                "dam_land",
                "dam_launch",
                "jump_roll",
                "sf_jumpwall"
            }
        },
        {
            AnimationGroups.Dancing,
            new List<string>()
            {
                "bd_clap",
                "bd_clap1",
                "dance_loop",
                "dan_down_a",
                "dan_left_a",
                "dan_loop_a",
                "dan_right_a",
                "dan_up_a",
                "dnce_m_a",
                "dnce_m_b",
                "dnce_m_c",
                "dnce_m_d",
                "dnce_m_e"
            }
        },
        {
            AnimationGroups.Dealer,
            new List<string>()
            {
                "dealer_deal",
                "dealer_idle",
                "dealer_idle_01",
                "dealer_idle_02",
                "dealer_idle_03",
                "drugs_buy",
                "shop_pay"
            }
        },
        {
            AnimationGroups.Dildo,
            new List<string>()
            {
                "dildo_1",
                "dildo_2",
                "dildo_3",
                "dildo_block",
                "dildo_g",
                "dildo_hit_1",
                "dildo_hit_2",
                "dildo_hit_3",
                "dildo_idle"
            }
        },
        {
            AnimationGroups.Dodge,
            new List<string>()
            {
                "cover_dive_01",
                "cover_dive_02",
                "crushed",
                "crush_jump"
            }
        },
        {
            AnimationGroups.Dozer,
            new List<string>()
            {
                "dozer_align_lhs",
                "dozer_align_rhs",
                "dozer_getin_lhs",
                "dozer_getin_rhs",
                "dozer_getout_lhs",
                "dozer_getout_rhs",
                "dozer_jacked_lhs",
                "dozer_jacked_rhs",
                "dozer_pullout_lhs",
                "dozer_pullout_rhs"
            }
        },
        {
            AnimationGroups.Drivebys,
            new List<string>()
            {
                "gang_drivebylhs",
                "gang_drivebylhs_bwd",
                "gang_drivebylhs_fwd",
                "gang_drivebyrhs",
                "gang_drivebyrhs_bwd",
                "gang_drivebyrhs_fwd",
                "gang_drivebytop_lhs",
                "gang_drivebytop_rhs"
            }
        },
        {
            AnimationGroups.Fat,
            new List<string>()
            {
                "fatidle",
                "fatidle_armed",
                "fatidle_csaw",
                "fatidle_rocket",
                "fatrun",
                "fatrun_armed",
                "fatrun_csaw",
                "fatrun_rocket",
                "fatsprint",
                "fatwalk",
                "fatwalkstart",
                "fatwalkstart_csaw",
                "fatwalkst_armed",
                "fatwalkst_rocket",
                "fatwalk_armed",
                "fatwalk_csaw",
                "fatwalk_rocket",
                "idle_tired"
            }
        },
        {
            AnimationGroups.Fight_B,
            new List<string>()
            {
                "fightb_1",
                "fightb_2",
                "fightb_3",
                "fightb_block",
                "fightb_g",
                "fightb_idle",
                "fightb_m",
                "hitb_1",
                "hitb_2",
                "hitb_3"
            }
        },
        {
            AnimationGroups.Fight_C,
            new List<string>()
            {
                "fightc_1",
                "fightc_2",
                "fightc_3",
                "fightc_block",
                "fightc_blocking",
                "fightc_g",
                "fightc_idle",
                "fightc_m",
                "fightc_spar",
                "hitc_1",
                "hitc_2",
                "hitc_3"
            }
        },
        {
            AnimationGroups.Fight_D,
            new List<string>()
            {
                "fightd_1",
                "fightd_2",
                "fightd_3",
                "fightd_block",
                "fightd_g",
                "fightd_idle",
                "fightd_m",
                "hitd_1",
                "hitd_2",
                "hitd_3"
            }
        },
        {
            AnimationGroups.Fight_E,
            new List<string>()
            {
                "fightkick",
                "fightkick_b",
                "hit_fightkick",
                "hit_fightkick_b"
            }
        },
        {
            AnimationGroups.Finale,
            new List<string>()
            {
                "fin_climb_in",
                "fin_cop1_climbout2",
                "fin_cop1_loop",
                "fin_cop1_stomp",
                "fin_hang_l",
                "fin_hang_loop",
                "fin_hang_r",
                "fin_hang_slip",
                "fin_jump_on",
                "fin_land_car",
                "fin_land_die",
                "fin_legsup",
                "fin_legsup_l",
                "fin_legsup_loop",
                "fin_legsup_r",
                "fin_let_go"
            }
        },
        {
            AnimationGroups.Finale2,
            new List<string>()
            {
                "fin_cop1_climbout",
                "fin_cop1_fall",
                "fin_cop1_loop",
                "fin_cop1_shot",
                "fin_cop1_swing",
                "fin_cop2_climbout",
                "fin_switch_p",
                "fin_switch_s"
            }
        },
        {
            AnimationGroups.Flame,
            new List<string>()
            {
                "flame_fire"
            }
        },
        {
            AnimationGroups.Flowers,
            new List<string>()
            {
                "flower_attack",
                "flower_attack_m",
                "flower_hit"
            }
        },
        {
            AnimationGroups.Food,
            new List<string>()
            {
                "eat_burger",
                "eat_chicken",
                "eat_pizza",
                "eat_vomit_p",
                "eat_vomit_sk",
                "ff_dam_bkw",
                "ff_dam_fwd",
                "ff_dam_left",
                "ff_dam_right",
                "ff_die_bkw",
                "ff_die_fwd",
                "ff_die_left",
                "ff_die_right",
                "ff_sit_eat1",
                "ff_sit_eat2",
                "ff_sit_eat3",
                "ff_sit_in",
                "ff_sit_in_l",
                "ff_sit_in_r",
                "ff_sit_look",
                "ff_sit_loop",
                "ff_sit_out_180",
                "ff_sit_out_l_180",
                "ff_sit_out_r_180",
                "shp_thank",
                "shp_tray_in",
                "shp_tray_lift",
                "shp_tray_lift_in",
                "shp_tray_lift_loop",
                "shp_tray_lift_out",
                "shp_tray_out",
                "shp_tray_pose",
                "shp_tray_return"
            }
        },
        {
            AnimationGroups.Freeweights,
            new List<string>()
            {
                "gym_barbell",
                "gym_free_a",
                "gym_free_b",
                "gym_free_celebrate",
                "gym_free_down",
                "gym_free_loop",
                "gym_free_pickup",
                "gym_free_putdown",
                "gym_free_up_smooth"
            }
        },
        {
            AnimationGroups.Gangs,
            new List<string>()
            {
                "dealer_deal",
                "dealer_idle",
                "drnkbr_prtl",
                "drnkbr_prtl_f",
                "drugs_buy",
                "hndshkaa",
                "hndshkba",
                "hndshkca",
                "hndshkcb",
                "hndshkda",
                "hndshkea",
                "hndshkfa",
                "hndshkfa_swt",
                "invite_no",
                "invite_yes",
                "leanidle",
                "leanin",
                "leanout",
                "prtial_gngtlka",
                "prtial_gngtlkb",
                "prtial_gngtlkc",
                "prtial_gngtlkd",
                "prtial_gngtlke",
                "prtial_gngtlkf",
                "prtial_gngtlkg",
                "prtial_gngtlkh",
                "prtial_hndshk_01",
                "prtial_hndshk_biz_01",
                "shake_cara",
                "shake_cark",
                "shake_carsh",
                "smkcig_prtl",
                "smkcig_prtl_f"
            }
        },
        {
            AnimationGroups.Ghands,
            new List<string>()
            {
                "gsign1",
                "gsign1lh",
                "gsign2",
                "gsign2lh",
                "gsign3",
                "gsign3lh",
                "gsign4",
                "gsign4lh",
                "gsign5",
                "gsign5lh",
                "lhgsign1",
                "lhgsign2",
                "lhgsign3",
                "lhgsign4",
                "lhgsign5",
                "rhgsign1",
                "rhgsign2",
                "rhgsign3",
                "rhgsign4",
                "rhgsign5"
            }
        },
        {
            AnimationGroups.Ghetto_Db,
            new List<string>()
            {
                "gdb_car2_ply",
                "gdb_car2_smo",
                "gdb_car2_swe",
                "gdb_car_ply",
                "gdb_car_ryd",
                "gdb_car_smo",
                "gdb_car_swe"
            }
        },
        {
            AnimationGroups.Goggles,
            new List<string>()
            {
                "goggles_put_on"
            }
        },
        {
            AnimationGroups.Graffiti,
            new List<string>()
            {
                "graffiti_chkout",
                "spraycan_fire"
            }
        },
        {
            AnimationGroups.Graveyard,
            new List<string>()
            {
                "mrnf_loop",
                "mrnm_loop",
                "prst_loopa"
            }
        },
        {
            AnimationGroups.Grenade,
            new List<string>()
            {
                "weapon_start_throw",
                "weapon_throw",
                "weapon_throwu"
            }
        },
        {
            AnimationGroups.Gymnasium,
            new List<string>()
            {
                "gymshadowbox",
                "gym_bike_celebrate",
                "gym_bike_fast",
                "gym_bike_faster",
                "gym_bike_getoff",
                "gym_bike_geton",
                "gym_bike_pedal",
                "gym_bike_slow",
                "gym_bike_still",
                "gym_jog_falloff",
                "gym_shadowbox",
                "gym_tread_celebrate",
                "gym_tread_falloff",
                "gym_tread_getoff",
                "gym_tread_geton",
                "gym_tread_jog",
                "gym_tread_sprint",
                "gym_tread_tired",
                "gym_tread_walk",
                "gym_walk_falloff",
                "pedals_fast",
                "pedals_med",
                "pedals_slow",
                "pedals_still"
            }
        },
        {
            AnimationGroups.Haircuts,
            new List<string>()
            {
                "brb_beard_01",
                "brb_buy",
                "brb_cut",
                "brb_cut_in",
                "brb_cut_out",
                "brb_hair_01",
                "brb_hair_02",
                "brb_in",
                "brb_loop",
                "brb_out",
                "brb_sit_in",
                "brb_sit_loop",
                "brb_sit_out"
            }
        },
        {
            AnimationGroups.Heist9,
            new List<string>()
            {
                "cas_g2_gasko",
                "swt_wllpk_l",
                "swt_wllpk_l_back",
                "swt_wllpk_r",
                "swt_wllpk_r_back",
                "swt_wllshoot_in_l",
                "swt_wllshoot_in_r",
                "swt_wllshoot_out_l",
                "swt_wllshoot_out_r",
                "use_swipecard"
            }
        },
        {
            AnimationGroups.Int_House,
            new List<string>()
            {
                "bed_in_l",
                "bed_in_r",
                "bed_loop_l",
                "bed_loop_r",
                "bed_out_l",
                "bed_out_r",
                "lou_in",
                "lou_loop",
                "lou_out",
                "wash_up"
            }
        },
        {
            AnimationGroups.Int_Office,
            new List<string>()
            {
                "ff_dam_fwd",
                "off_sit_2idle_180",
                "off_sit_bored_loop",
                "off_sit_crash",
                "off_sit_drink",
                "off_sit_idle_loop",
                "off_sit_in",
                "off_sit_read",
                "off_sit_type_loop",
                "off_sit_watch"
            }
        },
        {
            AnimationGroups.Int_Shop,
            new List<string>()
            {
                "shop_cashier",
                "shop_in",
                "shop_looka",
                "shop_lookb",
                "shop_loop",
                "shop_out",
                "shop_pay",
                "shop_shelf"
            }
        },
        {
            AnimationGroups.Jst_Buisness,
            new List<string>()
            {
                "girl_01",
                "girl_02",
                "player_01",
                "smoke_01"
            }
        },
        {
            AnimationGroups.Kart,
            new List<string>()
            {
                "kart_getin_lhs",
                "kart_getin_rhs",
                "kart_getout_lhs",
                "kart_getout_rhs"
            }
        },
        {
            AnimationGroups.Kissing,
            new List<string>()
            {
                "bd_gf_wave",
                "gfwave2",
                "gf_carargue_01",
                "gf_carargue_02",
                "gf_carspot",
                "gf_streetargue_01",
                "gf_streetargue_02",
                "gift_get",
                "gift_give",
                "grlfrd_kiss_01",
                "grlfrd_kiss_02",
                "grlfrd_kiss_03",
                "playa_kiss_01",
                "playa_kiss_02",
                "playa_kiss_03"
            }
        },
        {
            AnimationGroups.Knife,
            new List<string>()
            {
                "kill_knife_ped_damage",
                "kill_knife_ped_die",
                "kill_knife_player",
                "kill_partial",
                "knife_1",
                "knife_2",
                "knife_3",
                "knife_4",
                "knife_block",
                "knife_g",
                "knife_hit_1",
                "knife_hit_2",
                "knife_hit_3",
                "knife_idle",
                "knife_part",
                "weapon_knifeidle"
            }
        },
        {
            AnimationGroups.Lapdan1,
            new List<string>()
            {
                "lapdan_d",
                "lapdan_p"
            }
        },
        {
            AnimationGroups.Lapdan2,
            new List<string>()
            {
                "lapdan_d",
                "lapdan_p"
            }
        },
        {
            AnimationGroups.Lapdan3,
            new List<string>()
            {
                "lapdan_d",
                "lapdan_p"
            }
        },
        {
            AnimationGroups.Lowrider,
            new List<string>()
            {
                "f_smklean_loop",
                "lrgirl_bdbnce",
                "lrgirl_hair",
                "lrgirl_hurry",
                "lrgirl_idleloop",
                "lrgirl_idle_to_l0",
                "lrgirl_l0_bnce",
                "lrgirl_l0_loop",
                "lrgirl_l0_to_l1",
                "lrgirl_l12_to_l0",
                "lrgirl_l1_bnce",
                "lrgirl_l1_loop",
                "lrgirl_l1_to_l2",
                "lrgirl_l2_bnce",
                "lrgirl_l2_loop",
                "lrgirl_l2_to_l3",
                "lrgirl_l345_to_l1",
                "lrgirl_l3_bnce",
                "lrgirl_l3_loop",
                "lrgirl_l3_to_l4",
                "lrgirl_l4_bnce",
                "lrgirl_l4_loop",
                "lrgirl_l4_to_l5",
                "lrgirl_l5_bnce",
                "lrgirl_l5_loop",
                "m_smklean_loop",
                "m_smkstnd_loop",
                "prtial_gngtlkb",
                "prtial_gngtlkc",
                "prtial_gngtlkd",
                "prtial_gngtlke",
                "prtial_gngtlkf",
                "prtial_gngtlkg",
                "prtial_gngtlkh",
                "rap_a_loop",
                "rap_b_loop",
                "rap_c_loop",
                "sit_relaxed",
                "tap_hand"
            }
        },
        {
            AnimationGroups.Md_Chase,
            new List<string>()
            {
                "carhit_hangon",
                "carhit_tumble",
                "donutdrop",
                "fen_choppa_l1",
                "fen_choppa_l2",
                "fen_choppa_l3",
                "fen_choppa_r1",
                "fen_choppa_r2",
                "fen_choppa_r3",
                "hangon_stun_loop",
                "hangon_stun_turn",
                "md_bike_2_hang",
                "md_bike_jmp_bl",
                "md_bike_jmp_f",
                "md_bike_lnd_bl",
                "md_bike_lnd_die_bl",
                "md_bike_lnd_die_f",
                "md_bike_lnd_f",
                "md_bike_lnd_roll",
                "md_bike_lnd_roll_f",
                "md_bike_punch",
                "md_bike_punch_f",
                "md_bike_shot_f",
                "md_hang_lnd_roll",
                "md_hang_loop"
            }
        },
        {
            AnimationGroups.Md_End,
            new List<string>()
            {
                "end_sc1_ply",
                "end_sc1_ryd",
                "end_sc1_smo",
                "end_sc1_swe",
                "end_sc2_ply",
                "end_sc2_ryd",
                "end_sc2_smo",
                "end_sc2_swe"
            }
        },
        {
            AnimationGroups.Medic,
            new List<string>()
            {
                "cpr"
            }
        },
        {
            AnimationGroups.Misc,
            new List<string>()
            {
                "bitchslap",
                "bmx_celebrate",
                "bmx_comeon",
                "bmx_idleloop_01",
                "bmx_idleloop_02",
                "bmx_talkleft_in",
                "bmx_talkleft_loop",
                "bmx_talkleft_out",
                "bmx_talkright_in",
                "bmx_talkright_loop",
                "bmx_talkright_out",
                "bng_wndw",
                "bng_wndw_02",
                "case_pickup",
                "door_jet",
                "grab_l",
                "grab_r",
                "hiker_pose",
                "hiker_pose_l",
                "idle_chat_02",
                "kat_throw_k",
                "kat_throw_o",
                "kat_throw_p",
                "pass_rifle_o",
                "pass_rifle_ped",
                "pass_rifle_ply",
                "pickup_box",
                "plane_door",
                "plane_exit",
                "plane_hijack",
                "plunger_01",
                "plyrlean_loop",
                "plyr_shkhead",
                "run_dive",
                "scratchballs_01",
                "seat_lr",
                "seat_talk_01",
                "seat_talk_02",
                "seat_watch",
                "smalplane_door",
                "smlplane_door"
            }
        },
        {
            AnimationGroups.Mtb,
            new List<string>()
            {
                "mtb_back",
                "mtb_bunnyhop",
                "mtb_drivebyft",
                "mtb_driveby_lhs",
                "mtb_driveby_rhs",
                "mtb_fwd",
                "mtb_getoffback",
                "mtb_getofflhs",
                "mtb_getoffrhs",
                "mtb_jumponl",
                "mtb_jumponr",
                "mtb_left",
                "mtb_pedal",
                "mtb_pushes",
                "mtb_ride",
                "mtb_right",
                "mtb_sprint",
                "mtb_still"
            }
        },
        {
            AnimationGroups.Muscular,
            new List<string>()
            {
                "msclewalkst_armed",
                "msclewalkst_csaw",
                "mscle_rckt_run",
                "mscle_rckt_walkst",
                "mscle_run_csaw",
                "muscleidle",
                "muscleidle_armed",
                "muscleidle_csaw",
                "muscleidle_rocket",
                "musclerun",
                "musclerun_armed",
                "musclesprint",
                "musclewalk",
                "musclewalkstart",
                "musclewalk_armed",
                "musclewalk_csaw",
                "musclewalk_rocket"
            }
        },
        {
            AnimationGroups.Nevada,
            new List<string>()
            {
                "nevada_getin",
                "nevada_getout"
            }
        },
        {
            AnimationGroups.On_Lookers,
            new List<string>()
            {
                "lkaround_in",
                "lkaround_loop",
                "lkaround_out",
                "lkup_in",
                "lkup_loop",
                "lkup_out",
                "lkup_point",
                "panic_cower",
                "panic_hide",
                "panic_in",
                "panic_loop",
                "panic_out",
                "panic_point",
                "panic_shout",
                "pointup_in",
                "pointup_loop",
                "pointup_out",
                "pointup_shout",
                "point_in",
                "point_loop",
                "point_out",
                "shout_01",
                "shout_02",
                "shout_in",
                "shout_loop",
                "shout_out",
                "wave_in",
                "wave_loop",
                "wave_out"
            }
        },
        {
            AnimationGroups.Otb,
            new List<string>()
            {
                "betslp_in",
                "betslp_lkabt",
                "betslp_loop",
                "betslp_out",
                "betslp_tnk",
                "wtchrace_cmon",
                "wtchrace_in",
                "wtchrace_loop",
                "wtchrace_lose",
                "wtchrace_out",
                "wtchrace_win"
            }
        },
        {
            AnimationGroups.Parachute,
            new List<string>()
            {
                "fall_skydive",
                "fall_skydive_accel",
                "fall_skydive_die",
                "fall_skydive_l",
                "fall_skydive_r",
                "para_decel",
                "para_decel_o",
                "para_float",
                "para_float_o",
                "para_land",
                "para_land_o",
                "para_land_water",
                "para_land_water_o",
                "para_open",
                "para_open_o",
                "para_rip_land_o",
                "para_rip_loop_o",
                "para_rip_o",
                "para_steerl",
                "para_steerl_o",
                "para_steerr",
                "para_steerr_o"
            }
        },
        {
            AnimationGroups.Park,
            new List<string>()
            {
                "tai_chi_in",
                "tai_chi_loop",
                "tai_chi_out"
            }
        },
        {
            AnimationGroups.Paulnmac,
            new List<string>()
            {
                "piss_in",
                "piss_loop",
                "piss_out",
                "pnm_argue1_a",
                "pnm_argue1_b",
                "pnm_argue2_a",
                "pnm_argue2_b",
                "pnm_loop_a",
                "pnm_loop_b",
                "wank_in",
                "wank_loop",
                "wank_out"
            }
        },
        {
            AnimationGroups.Ped,
            new List<string>()
            {
                "abseil",
                "arrestgun",
                "atm",
                "bike_elbowl",
                "bike_elbowr",
                "bike_fallr",
                "bike_fall_off",
                "bike_pickupl",
                "bike_pickupr",
                "bike_pullupl",
                "bike_pullupr",
                "bomber",
                "car_alignhi_lhs",
                "car_alignhi_rhs",
                "car_align_lhs",
                "car_align_rhs",
                "car_closedoorl_lhs",
                "car_closedoorl_rhs",
                "car_closedoor_lhs",
                "car_closedoor_rhs",
                "car_close_lhs",
                "car_close_rhs",
                "car_crawloutrhs",
                "car_dead_lhs",
                "car_dead_rhs",
                "car_doorlocked_lhs",
                "car_doorlocked_rhs",
                "car_fallout_lhs",
                "car_fallout_rhs",
                "car_getinl_lhs",
                "car_getinl_rhs",
                "car_getin_lhs",
                "car_getin_rhs",
                "car_getoutl_lhs",
                "car_getoutl_rhs",
                "car_getout_lhs",
                "car_getout_rhs",
                "car_hookertalk",
                "car_jackedlhs",
                "car_jackedrhs",
                "car_jumpin_lhs",
                "car_lb",
                "car_lb_pro",
                "car_lb_weak",
                "car_ljackedlhs",
                "car_ljackedrhs",
                "car_lshuffle_rhs",
                "car_lsit",
                "car_open_lhs",
                "car_open_rhs",
                "car_pulloutl_lhs",
                "car_pulloutl_rhs",
                "car_pullout_lhs",
                "car_pullout_rhs",
                "car_qjacked",
                "car_rolldoor",
                "car_rolldoorlo",
                "car_rollout_lhs",
                "car_rollout_rhs",
                "car_shuffle_rhs",
                "car_sit",
                "car_sitp",
                "car_sitplo",
                "car_sit_pro",
                "car_sit_weak",
                "car_tune_radio",
                "climb_idle",
                "climb_jump",
                "climb_jump2fall",
                "climb_jump_b",
                "climb_pull",
                "climb_stand",
                "climb_stand_finish",
                "cower",
                "crouch_roll_l",
                "crouch_roll_r",
                "dam_arml_frmbk",
                "dam_arml_frmft",
                "dam_arml_frmlt",
                "dam_armr_frmbk",
                "dam_armr_frmft",
                "dam_armr_frmrt",
                "dam_legl_frmbk",
                "dam_legl_frmft",
                "dam_legl_frmlt",
                "dam_legr_frmbk",
                "dam_legr_frmft",
                "dam_legr_frmrt",
                "dam_stomach_frmbk",
                "dam_stomach_frmft",
                "dam_stomach_frmlt",
                "dam_stomach_frmrt",
                "door_lhinge_o",
                "door_rhinge_o",
                "drivebyl_l",
                "drivebyl_r",
                "driveby_l",
                "driveby_r",
                "drive_boat",
                "drive_boat_back",
                "drive_boat_l",
                "drive_boat_r",
                "drive_l",
                "drive_lo_l",
                "drive_lo_r",
                "drive_l_pro",
                "drive_l_pro_slow",
                "drive_l_slow",
                "drive_l_weak",
                "drive_l_weak_slow",
                "drive_r",
                "drive_r_pro",
                "drive_r_pro_slow",
                "drive_r_slow",
                "drive_r_weak",
                "drive_r_weak_slow",
                "drive_truck",
                "drive_truck_back",
                "drive_truck_l",
                "drive_truck_r",
                "drown",
                "duck_cower",
                "endchat_01",
                "endchat_02",
                "endchat_03",
                "ev_dive",
                "ev_step",
                "facanger",
                "facgum",
                "facsurp",
                "facsurpm",
                "factalk",
                "facurios",
                "fall_back",
                "fall_collapse",
                "fall_fall",
                "fall_front",
                "fall_glide",
                "fall_land",
                "fall_skydive",
                "fight2idle",
                "fighta_1",
                "fighta_2",
                "fighta_3",
                "fighta_block",
                "fighta_g",
                "fighta_m",
                "fightidle",
                "fightshb",
                "fightshf",
                "fightsh_bwd",
                "fightsh_fwd",
                "fightsh_left",
                "fightsh_right",
                "flee_lkaround_01",
                "floor_hit",
                "floor_hit_f",
                "fucku",
                "gang_gunstand",
                "gas_cwr",
                "getup",
                "getup_front",
                "gum_eat",
                "guncrouchbwd",
                "guncrouchfwd",
                "gunmove_bwd",
                "gunmove_fwd",
                "gunmove_l",
                "gunmove_r",
                "gun_2_idle",
                "gun_butt",
                "gun_butt_crouch",
                "gun_stand",
                "handscower",
                "handsup",
                "hita_1",
                "hita_2",
                "hita_3",
                "hit_back",
                "hit_behind",
                "hit_front",
                "hit_gun_butt",
                "hit_l",
                "hit_r",
                "hit_walk",
                "hit_wall",
                "idlestance_fat",
                "idlestance_old",
                "idle_armed",
                "idle_chat",
                "idle_csaw",
                "idle_gang1",
                "idle_hbhb",
                "idle_rocket",
                "idle_stance",
                "idle_taxi",
                "idle_tired",
                "jetpack_idle",
                "jog_femalea",
                "jog_malea",
                "jump_glide",
                "jump_land",
                "jump_launch",
                "jump_launch_r",
                "kart_drive",
                "kart_l",
                "kart_lb",
                "kart_r",
                "kd_left",
                "kd_right",
                "ko_shot_face",
                "ko_shot_front",
                "ko_shot_stom",
                "ko_skid_back",
                "ko_skid_front",
                "ko_spin_l",
                "ko_spin_r",
                "pass_smoke_in_car",
                "phone_in",
                "phone_out",
                "phone_talk",
                "player_sneak",
                "player_sneak_walkstart",
                "roadcross",
                "roadcross_female",
                "roadcross_gang",
                "roadcross_old",
                "run_1armed",
                "run_armed",
                "run_civi",
                "run_csaw",
                "run_fat",
                "run_fatold",
                "run_gang1",
                "run_left",
                "run_old",
                "run_player",
                "run_right",
                "run_rocket",
                "run_stop",
                "run_stopr",
                "run_wuzi",
                "seat_down",
                "seat_idle",
                "seat_up",
                "shot_leftp",
                "shot_partial",
                "shot_partial_b",
                "shot_rightp",
                "shove_partial",
                "smoke_in_car",
                "sprint_civi",
                "sprint_panic",
                "sprint_wuzi",
                "swat_run",
                "swim_tread",
                "tap_hand",
                "tap_handp",
                "turn_180",
                "turn_l",
                "turn_r",
                "walk_armed",
                "walk_civi",
                "walk_csaw",
                "walk_doorpartial",
                "walk_drunk",
                "walk_fat",
                "walk_fatold",
                "walk_gang1",
                "walk_gang2",
                "walk_old",
                "walk_player",
                "walk_rocket",
                "walk_shuffle",
                "walk_start",
                "walk_start_armed",
                "walk_start_csaw",
                "walk_start_rocket",
                "walk_wuzi",
                "weapon_crouch",
                "woman_idlestance",
                "woman_run",
                "woman_runbusy",
                "woman_runfatold",
                "woman_runpanic",
                "woman_runsexy",
                "woman_walkbusy",
                "woman_walkfatold",
                "woman_walknorm",
                "woman_walkold",
                "woman_walkpro",
                "woman_walksexy",
                "woman_walkshop",
                "xpressscratch"
            }
        },
        {
            AnimationGroups.Player_Dvbys,
            new List<string>()
            {
                "plyr_drivebybwd",
                "plyr_drivebyfwd",
                "plyr_drivebylhs",
                "plyr_drivebyrhs"
            }
        },
        {
            AnimationGroups.Playidles,
            new List<string>()
            {
                "shift",
                "shldr",
                "stretch",
                "strleg",
                "time"
            }
        },
        {
            AnimationGroups.Police,
            new List<string>()
            {
                "coptraf_away",
                "coptraf_come",
                "coptraf_left",
                "coptraf_stop",
                "cop_getoutcar_lhs",
                "cop_move_fwd",
                "crm_drgbst_01",
                "door_kick",
                "plc_drgbst_01",
                "plc_drgbst_02"
            }
        },
        {
            AnimationGroups.Pool,
            new List<string>()
            {
                "pool_chalkcue",
                "pool_idle_stance",
                "pool_long_shot",
                "pool_long_shot_o",
                "pool_long_start",
                "pool_long_start_o",
                "pool_med_shot",
                "pool_med_shot_o",
                "pool_med_start",
                "pool_med_start_o",
                "pool_place_white",
                "pool_short_shot",
                "pool_short_shot_o",
                "pool_short_start",
                "pool_short_start_o",
                "pool_walk",
                "pool_walk_start",
                "pool_xlong_shot",
                "pool_xlong_shot_o",
                "pool_xlong_start",
                "pool_xlong_start_o"
            }
        },
        {
            AnimationGroups.Poor,
            new List<string>()
            {
                "winwash_start",
                "winwash_wash2beg"
            }
        },
        {
            AnimationGroups.Python,
            new List<string>()
            {
                "python_crouchfire",
                "python_crouchreload",
                "python_fire",
                "python_fire_poor",
                "python_reload"
            }
        },
        {
            AnimationGroups.Quad,
            new List<string>()
            {
                "quad_back",
                "quad_driveby_ft",
                "quad_driveby_lhs",
                "quad_driveby_rhs",
                "quad_fwd",
                "quad_getoff_b",
                "quad_getoff_lhs",
                "quad_getoff_rhs",
                "quad_geton_lhs",
                "quad_geton_rhs",
                "quad_hit",
                "quad_kick",
                "quad_left",
                "quad_passenger",
                "quad_reverse",
                "quad_ride",
                "quad_right"
            }
        },
        {
            AnimationGroups.Quad_Dbz,
            new List<string>()
            {
                "pass_driveby_bwd",
                "pass_driveby_fwd",
                "pass_driveby_lhs",
                "pass_driveby_rhs"
            }
        },
        {
            AnimationGroups.Rapping,
            new List<string>()
            {
                "laugh_01",
                "rap_a_in",
                "rap_a_loop",
                "rap_a_out",
                "rap_b_in",
                "rap_b_loop",
                "rap_b_out",
                "rap_c_loop"
            }
        },
        {
            AnimationGroups.Rifle,
            new List<string>()
            {
                "rifle_crouchfire",
                "rifle_crouchload",
                "rifle_fire",
                "rifle_fire_poor",
                "rifle_load"
            }
        },
        {
            AnimationGroups.Riot,
            new List<string>()
            {
                "riot_angry",
                "riot_angry_b",
                "riot_challenge",
                "riot_chant",
                "riot_fuku",
                "riot_punches",
                "riot_shout"
            }
        },
        {
            AnimationGroups.Rob_Bank,
            new List<string>()
            {
                "cat_safe_end",
                "cat_safe_open",
                "cat_safe_open_o",
                "cat_safe_rob",
                "shp_handsup_scr"
            }
        },
        {
            AnimationGroups.Rocket,
            new List<string>()
            {
                "idle_rocket",
                "rocketfire",
                "run_rocket",
                "walk_rocket",
                "walk_start_rocket"
            }
        },
        {
            AnimationGroups.Rustler,
            new List<string>()
            {
                "plane_align_lhs",
                "plane_close",
                "plane_getin",
                "plane_getout",
                "plane_open"
            }
        },
        {
            AnimationGroups.Ryder,
            new List<string>()
            {
                "ryd_beckon_01",
                "ryd_beckon_02",
                "ryd_beckon_03",
                "ryd_die_pt1",
                "ryd_die_pt2",
                "van_crate_l",
                "van_crate_r",
                "van_fall_l",
                "van_fall_r",
                "van_lean_l",
                "van_lean_r",
                "van_pickup_e",
                "van_pickup_s",
                "van_stand",
                "van_stand_crate",
                "van_throw"
            }
        },
        {
            AnimationGroups.Scratching,
            new List<string>()
            {
                "scdldlp",
                "scdlulp",
                "scdrdlp",
                "scdrulp",
                "sclng_l",
                "sclng_r",
                "scmid_l",
                "scmid_r",
                "scshrtl",
                "scshrtr",
                "sc_ltor",
                "sc_rtol"
            }
        },
        {
            AnimationGroups.Shamal,
            new List<string>()
            {
                "shamal_align",
                "shamal_getin_lhs",
                "shamal_getout_lhs",
                "shamal_open"
            }
        },
        {
            AnimationGroups.Shop,
            new List<string>()
            {
                "rob_2idle",
                "rob_loop",
                "rob_loop_threat",
                "rob_shifty",
                "rob_stickup_in",
                "shp_duck",
                "shp_duck_aim",
                "shp_duck_fire",
                "shp_gun_aim",
                "shp_gun_duck",
                "shp_gun_fire",
                "shp_gun_grab",
                "shp_gun_threat",
                "shp_handsup_scr",
                "shp_jump_glide",
                "shp_jump_land",
                "shp_jump_launch",
                "shp_rob_givecash",
                "shp_rob_handsup",
                "shp_rob_react",
                "shp_serve_end",
                "shp_serve_idle",
                "shp_serve_loop",
                "shp_serve_start",
                "smoke_ryd"
            }
        },
        {
            AnimationGroups.Shotgun,
            new List<string>()
            {
                "shotgun_crouchfire",
                "shotgun_fire",
                "shotgun_fire_poor"
            }
        },
        {
            AnimationGroups.Silenced,
            new List<string>()
            {
                "crouchreload",
                "silencecrouchfire",
                "silence_fire",
                "silence_reload"
            }
        },
        {
            AnimationGroups.Skate,
            new List<string>()
            {
                "skate_idle",
                "skate_run",
                "skate_sprint"
            }
        },
        {
            AnimationGroups.Smoking,
            new List<string>()
            {
                "f_smklean_loop",
                "m_smklean_loop",
                "m_smkstnd_loop",
                "m_smk_drag",
                "m_smk_in",
                "m_smk_loop",
                "m_smk_out",
                "m_smk_tap"
            }
        },
        {
            AnimationGroups.Sniper,
            new List<string>()
            {
                "weapon_sniper"
            }
        },
        {
            AnimationGroups.Spraycan,
            new List<string>()
            {
                "spraycan_fire",
                "spraycan_full"
            }
        },
        {
            AnimationGroups.Strip,
            new List<string>()
            {
                "ply_cash",
                "pun_cash",
                "pun_holler",
                "pun_loop",
                "strip_a",
                "strip_b",
                "strip_c",
                "strip_d",
                "strip_e",
                "strip_f",
                "strip_g",
                "str_a2b",
                "str_b2a",
                "str_b2c",
                "str_c1",
                "str_c2",
                "str_c2b",
                "str_loop_a",
                "str_loop_b",
                "str_loop_c"
            }
        },
        {
            AnimationGroups.Sunbathe,
            new List<string>()
            {
                "batherdown",
                "batherup",
                "lay_bac_in",
                "lay_bac_out",
                "parksit_m_idlea",
                "parksit_m_idleb",
                "parksit_m_idlec",
                "parksit_m_in",
                "parksit_m_out",
                "parksit_w_idlea",
                "parksit_w_idleb",
                "parksit_w_idlec",
                "parksit_w_in",
                "parksit_w_out",
                "sbathe_f_lieb2sit",
                "sbathe_f_out",
                "sitnwait_in_w",
                "sitnwait_out_w"
            }
        },
        {
            AnimationGroups.Swat,
            new List<string>()
            {
                "gnstwall_injurd",
                "jmp_wall1m_180",
                "rail_fall",
                "rail_fall_crawl",
                "swt_breach_01",
                "swt_breach_02",
                "swt_breach_03",
                "swt_go",
                "swt_lkt",
                "swt_sty",
                "swt_vent_01",
                "swt_vent_02",
                "swt_vnt_sht_die",
                "swt_vnt_sht_in",
                "swt_vnt_sht_loop",
                "swt_wllpk_l",
                "swt_wllpk_l_back",
                "swt_wllpk_r",
                "swt_wllpk_r_back",
                "swt_wllshoot_in_l",
                "swt_wllshoot_in_r",
                "swt_wllshoot_out_l",
                "swt_wllshoot_out_r"
            }
        },
        {
            AnimationGroups.Sweet,
            new List<string>()
            {
                "ho_ass_slapped",
                "lafin_player",
                "lafin_sweet",
                "plyr_hndshldr_01",
                "sweet_ass_slap",
                "sweet_hndshldr_01",
                "sweet_injuredloop"
            }
        },
        {
            AnimationGroups.Swim,
            new List<string>()
            {
                "swim_breast",
                "swim_crawl",
                "swim_dive_under",
                "swim_glide",
                "swim_jumpout",
                "swim_tread",
                "swim_under"
            }
        },
        {
            AnimationGroups.Sword,
            new List<string>()
            {
                "sword_1",
                "sword_2",
                "sword_3",
                "sword_4",
                "sword_block",
                "sword_hit_1",
                "sword_hit_2",
                "sword_hit_3",
                "sword_idle",
                "sword_part"
            }
        },
        {
            AnimationGroups.Tank,
            new List<string>()
            {
                "tank_align_lhs",
                "tank_close_lhs",
                "tank_doorlocked",
                "tank_getin_lhs",
                "tank_getout_lhs",
                "tank_open_lhs"
            }
        },
        {
            AnimationGroups.Tattoos,
            new List<string>()
            {
                "tat_arml_in_o",
                "tat_arml_in_p",
                "tat_arml_in_t",
                "tat_arml_out_o",
                "tat_arml_out_p",
                "tat_arml_out_t",
                "tat_arml_pose_o",
                "tat_arml_pose_p",
                "tat_arml_pose_t",
                "tat_armr_in_o",
                "tat_armr_in_p",
                "tat_armr_in_t",
                "tat_armr_out_o",
                "tat_armr_out_p",
                "tat_armr_out_t",
                "tat_armr_pose_o",
                "tat_armr_pose_p",
                "tat_armr_pose_t",
                "tat_back_in_o",
                "tat_back_in_p",
                "tat_back_in_t",
                "tat_back_out_o",
                "tat_back_out_p",
                "tat_back_out_t",
                "tat_back_pose_o",
                "tat_back_pose_p",
                "tat_back_pose_t",
                "tat_back_sit_in_p",
                "tat_back_sit_loop_p",
                "tat_back_sit_out_p",
                "tat_bel_in_o",
                "tat_bel_in_t",
                "tat_bel_out_o",
                "tat_bel_out_t",
                "tat_bel_pose_o",
                "tat_bel_pose_t",
                "tat_che_in_o",
                "tat_che_in_p",
                "tat_che_in_t",
                "tat_che_out_o",
                "tat_che_out_p",
                "tat_che_out_t",
                "tat_che_pose_o",
                "tat_che_pose_p",
                "tat_che_pose_t",
                "tat_drop_o",
                "tat_idle_loop_o",
                "tat_idle_loop_t",
                "tat_sit_in_o",
                "tat_sit_in_p",
                "tat_sit_in_t",
                "tat_sit_loop_o",
                "tat_sit_loop_p",
                "tat_sit_loop_t",
                "tat_sit_out_o",
                "tat_sit_out_p",
                "tat_sit_out_t"
            }
        },
        {
            AnimationGroups.Tec,
            new List<string>()
            {
                "tec_crouchfire",
                "tec_crouchreload",
                "tec_fire",
                "tec_reload"
            }
        },
        {
            AnimationGroups.Train,
            new List<string>()
            {
                "tran_gtup",
                "tran_hng",
                "tran_ouch",
                "tran_stmb"
            }
        },
        {
            AnimationGroups.Truck,
            new List<string>()
            {
                "truck_align_lhs",
                "truck_align_rhs",
                "truck_closedoor_lhs",
                "truck_closedoor_rhs",
                "truck_close_lhs",
                "truck_close_rhs",
                "truck_getin_lhs",
                "truck_getin_rhs",
                "truck_getout_lhs",
                "truck_getout_rhs",
                "truck_jackedlhs",
                "truck_jackedrhs",
                "truck_open_lhs",
                "truck_open_rhs",
                "truck_pullout_lhs",
                "truck_pullout_rhs",
                "truck_shuffle"
            }
        },
        {
            AnimationGroups.Uzi,
            new List<string>()
            {
                "uzi_crouchfire",
                "uzi_crouchreload",
                "uzi_fire",
                "uzi_fire_poor",
                "uzi_reload"
            }
        },
        {
            AnimationGroups.Van,
            new List<string>()
            {
                "van_close_back_lhs",
                "van_close_back_rhs",
                "van_getin_back_lhs",
                "van_getin_back_rhs",
                "van_getout_back_lhs",
                "van_getout_back_rhs",
                "van_open_back_lhs",
                "van_open_back_rhs"
            }
        },
        {
            AnimationGroups.Vending,
            new List<string>()
            {
                "vend_drink2_p",
                "vend_drink_p",
                "vend_eat1_p",
                "vend_eat_p",
                "vend_use",
                "vend_use_pt2"
            }
        },
        {
            AnimationGroups.Vortex,
            new List<string>()
            {
                "car_jumpin_lhs",
                "car_jumpin_rhs",
                "vortex_getout_lhs",
                "vortex_getout_rhs"
            }
        },
        {
            AnimationGroups.Wayfarer,
            new List<string>()
            {
                "wf_back",
                "wf_drivebyft",
                "wf_drivebylhs",
                "wf_drivebyrhs",
                "wf_fwd",
                "wf_getoffback",
                "wf_getofflhs",
                "wf_getoffrhs",
                "wf_hit",
                "wf_jumponl",
                "wf_jumponr",
                "wf_kick",
                "wf_left",
                "wf_passenger",
                "wf_pushes",
                "wf_ride",
                "wf_right",
                "wf_still"
            }
        },
        {
            AnimationGroups.Weapons,
            new List<string>()
            {
                "shp_1h_lift",
                "shp_1h_lift_end",
                "shp_1h_ret",
                "shp_1h_ret_s",
                "shp_2h_lift",
                "shp_2h_lift_end",
                "shp_2h_ret",
                "shp_2h_ret_s",
                "shp_ar_lift",
                "shp_ar_lift_end",
                "shp_ar_ret",
                "shp_ar_ret_s",
                "shp_g_lift_in",
                "shp_g_lift_out",
                "shp_tray_in",
                "shp_tray_out",
                "shp_tray_pose"
            }
        },
        {
            AnimationGroups.Wuzi,
            new List<string>()
            {
                "cs_dead_guy",
                "cs_plyr_pt1",
                "cs_plyr_pt2",
                "cs_wuzi_pt1",
                "cs_wuzi_pt2",
                "walkstart_idle_01",
                "wuzi_follow",
                "wuzi_greet_plyr",
                "wuzi_greet_wuzi",
                "wuzi_grnd_chk",
                "wuzi_stand_loop",
                "wuzi_walk",
            }
        }
    };
}

public class AnimGroup00
{
    public const string ThrwBarlThrw = "thrw_barl_thrw";
}

public class AnimGroup01
{
    public const string StepsitIn = "stepsit_in";
    public const string StepsitLoop = "stepsit_loop";
    public const string StepsitOut = "stepsit_out";
}

public class AnimGroup02
{
    public const string BarcustomGet = "barcustom_get";
    public const string BarcustomLoop = "barcustom_loop";
    public const string BarcustomOrder = "barcustom_order";
    public const string BarmanIdle = "barman_idle";
    public const string BarserveBottle = "barserve_bottle";
    public const string BarserveGive = "barserve_give";
    public const string BarserveGlass = "barserve_glass";
    public const string BarserveIn = "barserve_in";
    public const string BarserveLoop = "barserve_loop";
    public const string BarserveOrder = "barserve_order";
    public const string DnkStndfLoop = "dnk_stndf_loop";
    public const string DnkStndmLoop = "dnk_stndm_loop";
}

public class AnimGroup03
{
    public const string Bat1 = "bat_1";
    public const string Bat2 = "bat_2";
    public const string Bat3 = "bat_3";
    public const string Bat4 = "bat_4";
    public const string BatBlock = "bat_block";
    public const string BatHit1 = "bat_hit_1";
    public const string BatHit2 = "bat_hit_2";
    public const string BatHit3 = "bat_hit_3";
    public const string BatIdle = "bat_idle";
    public const string BatM = "bat_m";
    public const string BatPart = "bat_part";
}

public class AnimGroup04
{
    public const string BdFire1 = "bd_fire1";
    public const string BdFire2 = "bd_fire2";
    public const string BdFire3 = "bd_fire3";
    public const string BdGfWave = "bd_gf_wave";
    public const string BdPanic01 = "bd_panic_01";
    public const string BdPanic02 = "bd_panic_02";
    public const string BdPanic03 = "bd_panic_03";
    public const string BdPanic04 = "bd_panic_04";
    public const string BdPanicLoop = "bd_panic_loop";
    public const string GrlfrdKiss03 = "grlfrd_kiss_03";
    public const string MSmkleanLoop = "m_smklean_loop";
    public const string PlayaKiss03 = "playa_kiss_03";
    public const string WashUp = "wash_up";
}

public class AnimGroup05
{
    public const string Bather = "bather";
    public const string LayBacLoop = "lay_bac_loop";
    public const string ParksitMLoop = "parksit_m_loop";
    public const string ParksitWLoop = "parksit_w_loop";
    public const string SitnwaitLoopW = "sitnwait_loop_w";
}

public class AnimGroup06
{
    public const string GymBpCelebrate = "gym_bp_celebrate";
    public const string GymBpDown = "gym_bp_down";
    public const string GymBpGetoff = "gym_bp_getoff";
    public const string GymBpGeton = "gym_bp_geton";
    public const string GymBpUpA = "gym_bp_up_a";
    public const string GymBpUpB = "gym_bp_up_b";
    public const string GymBpUpSmooth = "gym_bp_up_smooth";
}

public class AnimGroup07
{
    public const string BfGetinLhs = "bf_getin_lhs";
    public const string BfGetinRhs = "bf_getin_rhs";
    public const string BfGetoutLhs = "bf_getout_lhs";
    public const string BfGetoutRhs = "bf_getout_rhs";
}

public class AnimGroup08
{
    public const string BikedBack = "biked_back";
    public const string BikedDrivebyft = "biked_drivebyft";
    public const string BikedDrivebylhs = "biked_drivebylhs";
    public const string BikedDrivebyrhs = "biked_drivebyrhs";
    public const string BikedFwd = "biked_fwd";
    public const string BikedGetoffback = "biked_getoffback";
    public const string BikedGetofflhs = "biked_getofflhs";
    public const string BikedGetoffrhs = "biked_getoffrhs";
    public const string BikedHit = "biked_hit";
    public const string BikedJumponl = "biked_jumponl";
    public const string BikedJumponr = "biked_jumponr";
    public const string BikedKick = "biked_kick";
    public const string BikedLeft = "biked_left";
    public const string BikedPassenger = "biked_passenger";
    public const string BikedPushes = "biked_pushes";
    public const string BikedRide = "biked_ride";
    public const string BikedRight = "biked_right";
    public const string BikedShuffle = "biked_shuffle";
    public const string BikedStill = "biked_still";
}

public class AnimGroup09
{
    public const string BikehBack = "bikeh_back";
    public const string BikehDrivebyft = "bikeh_drivebyft";
    public const string BikehDrivebylhs = "bikeh_drivebylhs";
    public const string BikehDrivebyrhs = "bikeh_drivebyrhs";
    public const string BikehFwd = "bikeh_fwd";
    public const string BikehGetoffback = "bikeh_getoffback";
    public const string BikehGetofflhs = "bikeh_getofflhs";
    public const string BikehGetoffrhs = "bikeh_getoffrhs";
    public const string BikehHit = "bikeh_hit";
    public const string BikehJumponl = "bikeh_jumponl";
    public const string BikehJumponr = "bikeh_jumponr";
    public const string BikehKick = "bikeh_kick";
    public const string BikehLeft = "bikeh_left";
    public const string BikehPassenger = "bikeh_passenger";
    public const string BikehPushes = "bikeh_pushes";
    public const string BikehRide = "bikeh_ride";
    public const string BikehRight = "bikeh_right";
    public const string BikehStill = "bikeh_still";
}

public class AnimGroup10
{
    public const string BkBlnceIn = "bk_blnce_in";
    public const string BkBlnceOut = "bk_blnce_out";
    public const string BkJmp = "bk_jmp";
    public const string BkRdyIn = "bk_rdy_in";
    public const string BkRdyOut = "bk_rdy_out";
    public const string StruggleCesar = "struggle_cesar";
    public const string StruggleDriver = "struggle_driver";
    public const string TruckDriver = "truck_driver";
    public const string TruckGetin = "truck_getin";
}

public class AnimGroup11
{
    public const string BikesBack = "bikes_back";
    public const string BikesDrivebyft = "bikes_drivebyft";
    public const string BikesDrivebylhs = "bikes_drivebylhs";
    public const string BikesDrivebyrhs = "bikes_drivebyrhs";
    public const string BikesFwd = "bikes_fwd";
    public const string BikesGetoffback = "bikes_getoffback";
    public const string BikesGetofflhs = "bikes_getofflhs";
    public const string BikesGetoffrhs = "bikes_getoffrhs";
    public const string BikesHit = "bikes_hit";
    public const string BikesJumponl = "bikes_jumponl";
    public const string BikesJumponr = "bikes_jumponr";
    public const string BikesKick = "bikes_kick";
    public const string BikesLeft = "bikes_left";
    public const string BikesPassenger = "bikes_passenger";
    public const string BikesPushes = "bikes_pushes";
    public const string BikesRide = "bikes_ride";
    public const string BikesRight = "bikes_right";
    public const string BikesSnatchL = "bikes_snatch_l";
    public const string BikesSnatchR = "bikes_snatch_r";
    public const string BikesStill = "bikes_still";
}

public class AnimGroup12
{
    public const string BikevBack = "bikev_back";
    public const string BikevDrivebyft = "bikev_drivebyft";
    public const string BikevDrivebylhs = "bikev_drivebylhs";
    public const string BikevDrivebyrhs = "bikev_drivebyrhs";
    public const string BikevFwd = "bikev_fwd";
    public const string BikevGetoffback = "bikev_getoffback";
    public const string BikevGetofflhs = "bikev_getofflhs";
    public const string BikevGetoffrhs = "bikev_getoffrhs";
    public const string BikevHit = "bikev_hit";
    public const string BikevJumponl = "bikev_jumponl";
    public const string BikevJumponr = "bikev_jumponr";
    public const string BikevKick = "bikev_kick";
    public const string BikevLeft = "bikev_left";
    public const string BikevPassenger = "bikev_passenger";
    public const string BikevPushes = "bikev_pushes";
    public const string BikevRide = "bikev_ride";
    public const string BikevRight = "bikev_right";
    public const string BikevStill = "bikev_still";
}

public class AnimGroup13
{
    public const string PassDrivebyBwd = "pass_driveby_bwd";
    public const string PassDrivebyFwd = "pass_driveby_fwd";
    public const string PassDrivebyLhs = "pass_driveby_lhs";
    public const string PassDrivebyRhs = "pass_driveby_rhs";
}

public class AnimGroup14
{
    public const string BmxBack = "bmx_back";
    public const string BmxBunnyhop = "bmx_bunnyhop";
    public const string BmxDrivebyft = "bmx_drivebyft";
    public const string BmxDrivebyLhs = "bmx_driveby_lhs";
    public const string BmxDrivebyRhs = "bmx_driveby_rhs";
    public const string BmxFwd = "bmx_fwd";
    public const string BmxGetoffback = "bmx_getoffback";
    public const string BmxGetofflhs = "bmx_getofflhs";
    public const string BmxGetoffrhs = "bmx_getoffrhs";
    public const string BmxJumponl = "bmx_jumponl";
    public const string BmxJumponr = "bmx_jumponr";
    public const string BmxLeft = "bmx_left";
    public const string BmxPedal = "bmx_pedal";
    public const string BmxPushes = "bmx_pushes";
    public const string BmxRide = "bmx_ride";
    public const string BmxRight = "bmx_right";
    public const string BmxSprint = "bmx_sprint";
    public const string BmxStill = "bmx_still";
}

public class AnimGroup15
{
    public const string BomPlant = "bom_plant";
    public const string BomPlant2Idle = "bom_plant_2idle";
    public const string BomPlantCrouchIn = "bom_plant_crouch_in";
    public const string BomPlantCrouchOut = "bom_plant_crouch_out";
    public const string BomPlantIn = "bom_plant_in";
    public const string BomPlantLoop = "bom_plant_loop";
}

public class AnimGroup16
{
    public const string Boxhipin = "boxhipin";
    public const string Boxhipup = "boxhipup";
    public const string Boxshdwn = "boxshdwn";
    public const string Boxshup = "boxshup";
    public const string Bxhipwlk = "bxhipwlk";
    public const string Bxhwlki = "bxhwlki";
    public const string Bxshwlk = "bxshwlk";
    public const string Bxshwlki = "bxshwlki";
    public const string Bxwlko = "bxwlko";
    public const string CatchBox = "catch_box";
}

public class AnimGroup17
{
    public const string BballDefJumpShot = "bball_def_jump_shot";
    public const string BballDefLoop = "bball_def_loop";
    public const string BballDefStepl = "bball_def_stepl";
    public const string BballDefStepr = "bball_def_stepr";
    public const string BballDnk = "bball_dnk";
    public const string BballDnkGli = "bball_dnk_gli";
    public const string BballDnkGliO = "bball_dnk_gli_o";
    public const string BballDnkLnch = "bball_dnk_lnch";
    public const string BballDnkLnchO = "bball_dnk_lnch_o";
    public const string BballDnkLnd = "bball_dnk_lnd";
    public const string BballDnkO = "bball_dnk_o";
    public const string BballIdle = "bball_idle";
    public const string BballIdle2 = "bball_idle2";
    public const string BballIdle2O = "bball_idle2_o";
    public const string BballIdleloop = "bball_idleloop";
    public const string BballIdleloopO = "bball_idleloop_o";
    public const string BballIdleO = "bball_idle_o";
    public const string BballJumpCancel = "bball_jump_cancel";
    public const string BballJumpCancelO = "bball_jump_cancel_o";
    public const string BballJumpEnd = "bball_jump_end";
    public const string BballJumpShot = "bball_jump_shot";
    public const string BballJumpShotO = "bball_jump_shot_o";
    public const string BballNetDnkO = "bball_net_dnk_o";
    public const string BballPickup = "bball_pickup";
    public const string BballPickupO = "bball_pickup_o";
    public const string BballReactMiss = "bball_react_miss";
    public const string BballReactScore = "bball_react_score";
    public const string BballRun = "bball_run";
    public const string BballRunO = "bball_run_o";
    public const string BballSkidstopL = "bball_skidstop_l";
    public const string BballSkidstopLO = "bball_skidstop_l_o";
    public const string BballSkidstopR = "bball_skidstop_r";
    public const string BballSkidstopRO = "bball_skidstop_r_o";
    public const string BballWalk = "bball_walk";
    public const string BballWalkstopL = "bball_walkstop_l";
    public const string BballWalkstopLO = "bball_walkstop_l_o";
    public const string BballWalkstopR = "bball_walkstop_r";
    public const string BballWalkstopRO = "bball_walkstop_r_o";
    public const string BballWalkO = "bball_walk_o";
    public const string BballWalkStart = "bball_walk_start";
    public const string BballWalkStartO = "bball_walk_start_o";
}

public class AnimGroup18
{
    public const string BuddyCrouchfire = "buddy_crouchfire";
    public const string BuddyCrouchreload = "buddy_crouchreload";
    public const string BuddyFire = "buddy_fire";
    public const string BuddyFirePoor = "buddy_fire_poor";
    public const string BuddyReload = "buddy_reload";
}

public class AnimGroup19
{
    public const string BusClose = "bus_close";
    public const string BusGetinLhs = "bus_getin_lhs";
    public const string BusGetinRhs = "bus_getin_rhs";
    public const string BusGetoutLhs = "bus_getout_lhs";
    public const string BusGetoutRhs = "bus_getout_rhs";
    public const string BusJackedLhs = "bus_jacked_lhs";
    public const string BusOpen = "bus_open";
    public const string BusOpenRhs = "bus_open_rhs";
    public const string BusPulloutLhs = "bus_pullout_lhs";
}

public class AnimGroup20
{
    public const string CamcrchCmon = "camcrch_cmon";
    public const string CamcrchIdleloop = "camcrch_idleloop";
    public const string CamcrchStay = "camcrch_stay";
    public const string CamcrchToCamstnd = "camcrch_to_camstnd";
    public const string CamstndCmon = "camstnd_cmon";
    public const string CamstndIdleloop = "camstnd_idleloop";
    public const string CamstndLkabt = "camstnd_lkabt";
    public const string CamstndToCamcrch = "camstnd_to_camcrch";
    public const string PiccrchIn = "piccrch_in";
    public const string PiccrchOut = "piccrch_out";
    public const string PiccrchTake = "piccrch_take";
    public const string PicstndIn = "picstnd_in";
    public const string PicstndOut = "picstnd_out";
    public const string PicstndTake = "picstnd_take";
}

public class AnimGroup21
{
    public const string FixnCarLoop = "fixn_car_loop";
    public const string FixnCarOut = "fixn_car_out";
    public const string FlagDrop = "flag_drop";
    public const string SitRelaxed = "sit_relaxed";
    public const string TapHand = "tap_hand";
    public const string Tyd2carBump = "tyd2car_bump";
    public const string Tyd2carHigh = "tyd2car_high";
    public const string Tyd2carLow = "tyd2car_low";
    public const string Tyd2carMed = "tyd2car_med";
    public const string Tyd2carTurnl = "tyd2car_turnl";
    public const string Tyd2carTurnr = "tyd2car_turnr";
}

public class AnimGroup22
{
    public const string CrryPrtial = "crry_prtial";
    public const string Liftup = "liftup";
    public const string Liftup05 = "liftup05";
    public const string Liftup105 = "liftup105";
    public const string Putdwn = "putdwn";
    public const string Putdwn05 = "putdwn05";
    public const string Putdwn105 = "putdwn105";
}

public class AnimGroup23
{
    public const string CarfoneIn = "carfone_in";
    public const string CarfoneLoopa = "carfone_loopa";
    public const string CarfoneLoopaToB = "carfone_loopa_to_b";
    public const string CarfoneLoopb = "carfone_loopb";
    public const string CarfoneLoopbToA = "carfone_loopb_to_a";
    public const string CarfoneOut = "carfone_out";
    public const string CarSc1Bl = "car_sc1_bl";
    public const string CarSc1Br = "car_sc1_br";
    public const string CarSc1Fl = "car_sc1_fl";
    public const string CarSc1Fr = "car_sc1_fr";
    public const string CarSc2Fl = "car_sc2_fl";
    public const string CarSc3Br = "car_sc3_br";
    public const string CarSc3Fl = "car_sc3_fl";
    public const string CarSc3Fr = "car_sc3_fr";
    public const string CarSc4Bl = "car_sc4_bl";
    public const string CarSc4Br = "car_sc4_br";
    public const string CarSc4Fl = "car_sc4_fl";
    public const string CarSc4Fr = "car_sc4_fr";
    public const string CarTalkmIn = "car_talkm_in";
    public const string CarTalkmLoop = "car_talkm_loop";
    public const string CarTalkmOut = "car_talkm_out";
}

public class AnimGroup24
{
    public const string CardsIn = "cards_in";
    public const string CardsLoop = "cards_loop";
    public const string CardsLose = "cards_lose";
    public const string CardsOut = "cards_out";
    public const string CardsPick01 = "cards_pick_01";
    public const string CardsPick02 = "cards_pick_02";
    public const string CardsRaise = "cards_raise";
    public const string CardsWin = "cards_win";
    public const string Dealone = "dealone";
    public const string Manwinb = "manwinb";
    public const string Manwind = "manwind";
    public const string RouletteBet = "roulette_bet";
    public const string RouletteIn = "roulette_in";
    public const string RouletteLoop = "roulette_loop";
    public const string RouletteLose = "roulette_lose";
    public const string RouletteOut = "roulette_out";
    public const string RouletteWin = "roulette_win";
    public const string SlotBet01 = "slot_bet_01";
    public const string SlotBet02 = "slot_bet_02";
    public const string SlotIn = "slot_in";
    public const string SlotLoseOut = "slot_lose_out";
    public const string SlotPlyr = "slot_plyr";
    public const string SlotWait = "slot_wait";
    public const string SlotWinOut = "slot_win_out";
    public const string Wof = "wof";
}

public class AnimGroup25
{
    public const string Csaw1 = "csaw_1";
    public const string Csaw2 = "csaw_2";
    public const string Csaw3 = "csaw_3";
    public const string CsawG = "csaw_g";
    public const string CsawHit1 = "csaw_hit_1";
    public const string CsawHit2 = "csaw_hit_2";
    public const string CsawHit3 = "csaw_hit_3";
    public const string CsawPart = "csaw_part";
    public const string IdleCsaw = "idle_csaw";
    public const string WeaponCsaw = "weapon_csaw";
    public const string WeaponCsawlo = "weapon_csawlo";
}

public class AnimGroup26
{
    public const string ChoppaBack = "choppa_back";
    public const string ChoppaBunnyhop = "choppa_bunnyhop";
    public const string ChoppaDrivebyft = "choppa_drivebyft";
    public const string ChoppaDrivebyLhs = "choppa_driveby_lhs";
    public const string ChoppaDrivebyRhs = "choppa_driveby_rhs";
    public const string ChoppaFwd = "choppa_fwd";
    public const string ChoppaGetoffback = "choppa_getoffback";
    public const string ChoppaGetofflhs = "choppa_getofflhs";
    public const string ChoppaGetoffrhs = "choppa_getoffrhs";
    public const string ChoppaJumponl = "choppa_jumponl";
    public const string ChoppaJumponr = "choppa_jumponr";
    public const string ChoppaLeft = "choppa_left";
    public const string ChoppaPedal = "choppa_pedal";
    public const string ChoppaPushes = "choppa_pushes";
    public const string ChoppaRide = "choppa_ride";
    public const string ChoppaRight = "choppa_right";
    public const string ChoppaSprint = "choppa_sprint";
    public const string ChoppaStill = "choppa_still";
}

public class AnimGroup27
{
    public const string CloBuy = "clo_buy";
    public const string CloIn = "clo_in";
    public const string CloOut = "clo_out";
    public const string CloPoseHat = "clo_pose_hat";
    public const string CloPoseIn = "clo_pose_in";
    public const string CloPoseInO = "clo_pose_in_o";
    public const string CloPoseLegs = "clo_pose_legs";
    public const string CloPoseLoop = "clo_pose_loop";
    public const string CloPoseOut = "clo_pose_out";
    public const string CloPoseOutO = "clo_pose_out_o";
    public const string CloPoseShoes = "clo_pose_shoes";
    public const string CloPoseTorso = "clo_pose_torso";
    public const string CloPoseWatch = "clo_pose_watch";
}

public class AnimGroup28
{
    public const string CoachInl = "coach_inl";
    public const string CoachInr = "coach_inr";
    public const string CoachOpnl = "coach_opnl";
    public const string CoachOpnr = "coach_opnr";
    public const string CoachOutl = "coach_outl";
    public const string CoachOutr = "coach_outr";
}

public class AnimGroup29
{
    public const string TwoGunsCrouchfire = "2guns_crouchfire";
    public const string Colt45Crouchfire = "colt45_crouchfire";
    public const string Colt45Crouchreload = "colt45_crouchreload";
    public const string Colt45Fire = "colt45_fire";
    public const string Colt45Fire2Hands = "colt45_fire_2hands";
    public const string Colt45Reload = "colt45_reload";
    public const string SawnoffReload = "sawnoff_reload";
}

public class AnimGroup30
{
    public const string CopbrowseIn = "copbrowse_in";
    public const string CopbrowseLoop = "copbrowse_loop";
    public const string CopbrowseNod = "copbrowse_nod";
    public const string CopbrowseOut = "copbrowse_out";
    public const string CopbrowseShake = "copbrowse_shake";
    public const string CoplookIn = "coplook_in";
    public const string CoplookLoop = "coplook_loop";
    public const string CoplookNod = "coplook_nod";
    public const string CoplookOut = "coplook_out";
    public const string CoplookShake = "coplook_shake";
    public const string CoplookThink = "coplook_think";
    public const string CoplookWatch = "coplook_watch";
}

public class AnimGroup31
{
    public const string CopDvbyB = "cop_dvby_b";
    public const string CopDvbyFt = "cop_dvby_ft";
    public const string CopDvbyL = "cop_dvby_l";
    public const string CopDvbyR = "cop_dvby_r";
}

public class AnimGroup32
{
    public const string BbalbatIdle01 = "bbalbat_idle_01";
    public const string BbalbatIdle02 = "bbalbat_idle_02";
    public const string Crckdeth1 = "crckdeth1";
    public const string Crckdeth2 = "crckdeth2";
    public const string Crckdeth3 = "crckdeth3";
    public const string Crckdeth4 = "crckdeth4";
    public const string Crckidle1 = "crckidle1";
    public const string Crckidle2 = "crckidle2";
    public const string Crckidle3 = "crckidle3";
    public const string Crckidle4 = "crckidle4";
}

public class AnimGroup33
{
    public const string CribConsoleLoop = "crib_console_loop";
    public const string CribUseSwitch = "crib_use_switch";
    public const string PedConsoleLoop = "ped_console_loop";
    public const string PedConsoleLoose = "ped_console_loose";
    public const string PedConsoleWin = "ped_console_win";
}

public class AnimGroup34
{
    public const string DamDiveLoop = "dam_dive_loop";
    public const string DamLand = "dam_land";
    public const string DamLaunch = "dam_launch";
    public const string JumpRoll = "jump_roll";
    public const string SfJumpwall = "sf_jumpwall";
}

public class AnimGroup35
{
    public const string BdClap = "bd_clap";
    public const string BdClap1 = "bd_clap1";
    public const string DanceLoop = "dance_loop";
    public const string DanDownA = "dan_down_a";
    public const string DanLeftA = "dan_left_a";
    public const string DanLoopA = "dan_loop_a";
    public const string DanRightA = "dan_right_a";
    public const string DanUpA = "dan_up_a";
    public const string DnceMA = "dnce_m_a";
    public const string DnceMB = "dnce_m_b";
    public const string DnceMC = "dnce_m_c";
    public const string DnceMD = "dnce_m_d";
    public const string DnceME = "dnce_m_e";
}

public class AnimGroup36
{
    public const string DealerDeal = "dealer_deal";
    public const string DealerIdle = "dealer_idle";
    public const string DealerIdle01 = "dealer_idle_01";
    public const string DealerIdle02 = "dealer_idle_02";
    public const string DealerIdle03 = "dealer_idle_03";
    public const string DrugsBuy = "drugs_buy";
    public const string ShopPay = "shop_pay";
}

public class AnimGroup37
{
    public const string Dildo1 = "dildo_1";
    public const string Dildo2 = "dildo_2";
    public const string Dildo3 = "dildo_3";
    public const string DildoBlock = "dildo_block";
    public const string DildoG = "dildo_g";
    public const string DildoHit1 = "dildo_hit_1";
    public const string DildoHit2 = "dildo_hit_2";
    public const string DildoHit3 = "dildo_hit_3";
    public const string DildoIdle = "dildo_idle";
}

public class AnimGroup38
{
    public const string CoverDive01 = "cover_dive_01";
    public const string CoverDive02 = "cover_dive_02";
    public const string Crushed = "crushed";
    public const string CrushJump = "crush_jump";
}

public class AnimGroup39
{
    public const string DozerAlignLhs = "dozer_align_lhs";
    public const string DozerAlignRhs = "dozer_align_rhs";
    public const string DozerGetinLhs = "dozer_getin_lhs";
    public const string DozerGetinRhs = "dozer_getin_rhs";
    public const string DozerGetoutLhs = "dozer_getout_lhs";
    public const string DozerGetoutRhs = "dozer_getout_rhs";
    public const string DozerJackedLhs = "dozer_jacked_lhs";
    public const string DozerJackedRhs = "dozer_jacked_rhs";
    public const string DozerPulloutLhs = "dozer_pullout_lhs";
    public const string DozerPulloutRhs = "dozer_pullout_rhs";
}

public class AnimGroup40
{
    public const string GangDrivebylhs = "gang_drivebylhs";
    public const string GangDrivebylhsBwd = "gang_drivebylhs_bwd";
    public const string GangDrivebylhsFwd = "gang_drivebylhs_fwd";
    public const string GangDrivebyrhs = "gang_drivebyrhs";
    public const string GangDrivebyrhsBwd = "gang_drivebyrhs_bwd";
    public const string GangDrivebyrhsFwd = "gang_drivebyrhs_fwd";
    public const string GangDrivebytopLhs = "gang_drivebytop_lhs";
    public const string GangDrivebytopRhs = "gang_drivebytop_rhs";
}

public class AnimGroup41
{
    public const string Fatidle = "fatidle";
    public const string FatidleArmed = "fatidle_armed";
    public const string FatidleCsaw = "fatidle_csaw";
    public const string FatidleRocket = "fatidle_rocket";
    public const string Fatrun = "fatrun";
    public const string FatrunArmed = "fatrun_armed";
    public const string FatrunCsaw = "fatrun_csaw";
    public const string FatrunRocket = "fatrun_rocket";
    public const string Fatsprint = "fatsprint";
    public const string Fatwalk = "fatwalk";
    public const string Fatwalkstart = "fatwalkstart";
    public const string FatwalkstartCsaw = "fatwalkstart_csaw";
    public const string FatwalkstArmed = "fatwalkst_armed";
    public const string FatwalkstRocket = "fatwalkst_rocket";
    public const string FatwalkArmed = "fatwalk_armed";
    public const string FatwalkCsaw = "fatwalk_csaw";
    public const string FatwalkRocket = "fatwalk_rocket";
    public const string IdleTired = "idle_tired";
}

public class AnimGroup42
{
    public const string Fightb1 = "fightb_1";
    public const string Fightb2 = "fightb_2";
    public const string Fightb3 = "fightb_3";
    public const string FightbBlock = "fightb_block";
    public const string FightbG = "fightb_g";
    public const string FightbIdle = "fightb_idle";
    public const string FightbM = "fightb_m";
    public const string Hitb1 = "hitb_1";
    public const string Hitb2 = "hitb_2";
    public const string Hitb3 = "hitb_3";
}

public class AnimGroup43
{
    public const string Fightc1 = "fightc_1";
    public const string Fightc2 = "fightc_2";
    public const string Fightc3 = "fightc_3";
    public const string FightcBlock = "fightc_block";
    public const string FightcBlocking = "fightc_blocking";
    public const string FightcG = "fightc_g";
    public const string FightcIdle = "fightc_idle";
    public const string FightcM = "fightc_m";
    public const string FightcSpar = "fightc_spar";
    public const string Hitc1 = "hitc_1";
    public const string Hitc2 = "hitc_2";
    public const string Hitc3 = "hitc_3";
}

public class AnimGroup44
{
    public const string Fightd1 = "fightd_1";
    public const string Fightd2 = "fightd_2";
    public const string Fightd3 = "fightd_3";
    public const string FightdBlock = "fightd_block";
    public const string FightdG = "fightd_g";
    public const string FightdIdle = "fightd_idle";
    public const string FightdM = "fightd_m";
    public const string Hitd1 = "hitd_1";
    public const string Hitd2 = "hitd_2";
    public const string Hitd3 = "hitd_3";
}

public class AnimGroup45
{
    public const string Fightkick = "fightkick";
    public const string FightkickB = "fightkick_b";
    public const string HitFightkick = "hit_fightkick";
    public const string HitFightkickB = "hit_fightkick_b";
}

public class AnimGroup46
{
    public const string FinClimbIn = "fin_climb_in";
    public const string FinCop1Climbout2 = "fin_cop1_climbout2";
    public const string FinCop1Loop = "fin_cop1_loop";
    public const string FinCop1Stomp = "fin_cop1_stomp";
    public const string FinHangL = "fin_hang_l";
    public const string FinHangLoop = "fin_hang_loop";
    public const string FinHangR = "fin_hang_r";
    public const string FinHangSlip = "fin_hang_slip";
    public const string FinJumpOn = "fin_jump_on";
    public const string FinLandCar = "fin_land_car";
    public const string FinLandDie = "fin_land_die";
    public const string FinLegsup = "fin_legsup";
    public const string FinLegsupL = "fin_legsup_l";
    public const string FinLegsupLoop = "fin_legsup_loop";
    public const string FinLegsupR = "fin_legsup_r";
    public const string FinLetGo = "fin_let_go";
}

public class AnimGroup47
{
    public const string FinCop1Climbout = "fin_cop1_climbout";
    public const string FinCop1Fall = "fin_cop1_fall";
    public const string FinCop1Loop = "fin_cop1_loop";
    public const string FinCop1Shot = "fin_cop1_shot";
    public const string FinCop1Swing = "fin_cop1_swing";
    public const string FinCop2Climbout = "fin_cop2_climbout";
    public const string FinSwitchP = "fin_switch_p";
    public const string FinSwitchS = "fin_switch_s";
}

public class AnimGroup48
{
    public const string FlameFire = "flame_fire";
}

public class AnimGroup49
{
    public const string FlowerAttack = "flower_attack";
    public const string FlowerAttackM = "flower_attack_m";
    public const string FlowerHit = "flower_hit";
}

public class AnimGroup50
{
    public const string EatBurger = "eat_burger";
    public const string EatChicken = "eat_chicken";
    public const string EatPizza = "eat_pizza";
    public const string EatVomitP = "eat_vomit_p";
    public const string EatVomitSk = "eat_vomit_sk";
    public const string FfDamBkw = "ff_dam_bkw";
    public const string FfDamFwd = "ff_dam_fwd";
    public const string FfDamLeft = "ff_dam_left";
    public const string FfDamRight = "ff_dam_right";
    public const string FfDieBkw = "ff_die_bkw";
    public const string FfDieFwd = "ff_die_fwd";
    public const string FfDieLeft = "ff_die_left";
    public const string FfDieRight = "ff_die_right";
    public const string FfSitEat1 = "ff_sit_eat1";
    public const string FfSitEat2 = "ff_sit_eat2";
    public const string FfSitEat3 = "ff_sit_eat3";
    public const string FfSitIn = "ff_sit_in";
    public const string FfSitInL = "ff_sit_in_l";
    public const string FfSitInR = "ff_sit_in_r";
    public const string FfSitLook = "ff_sit_look";
    public const string FfSitLoop = "ff_sit_loop";
    public const string FfSitOut180 = "ff_sit_out_180";
    public const string FfSitOutL180 = "ff_sit_out_l_180";
    public const string FfSitOutR180 = "ff_sit_out_r_180";
    public const string ShpThank = "shp_thank";
    public const string ShpTrayIn = "shp_tray_in";
    public const string ShpTrayLift = "shp_tray_lift";
    public const string ShpTrayLiftIn = "shp_tray_lift_in";
    public const string ShpTrayLiftLoop = "shp_tray_lift_loop";
    public const string ShpTrayLiftOut = "shp_tray_lift_out";
    public const string ShpTrayOut = "shp_tray_out";
    public const string ShpTrayPose = "shp_tray_pose";
    public const string ShpTrayReturn = "shp_tray_return";
}

public class AnimGroup51
{
    public const string GymBarbell = "gym_barbell";
    public const string GymFreeA = "gym_free_a";
    public const string GymFreeB = "gym_free_b";
    public const string GymFreeCelebrate = "gym_free_celebrate";
    public const string GymFreeDown = "gym_free_down";
    public const string GymFreeLoop = "gym_free_loop";
    public const string GymFreePickup = "gym_free_pickup";
    public const string GymFreePutdown = "gym_free_putdown";
    public const string GymFreeUpSmooth = "gym_free_up_smooth";
}

public class AnimGroup52
{
    public const string DealerDeal = "dealer_deal";
    public const string DealerIdle = "dealer_idle";
    public const string DrnkbrPrtl = "drnkbr_prtl";
    public const string DrnkbrPrtlF = "drnkbr_prtl_f";
    public const string DrugsBuy = "drugs_buy";
    public const string Hndshkaa = "hndshkaa";
    public const string Hndshkba = "hndshkba";
    public const string Hndshkca = "hndshkca";
    public const string Hndshkcb = "hndshkcb";
    public const string Hndshkda = "hndshkda";
    public const string Hndshkea = "hndshkea";
    public const string Hndshkfa = "hndshkfa";
    public const string HndshkfaSwt = "hndshkfa_swt";
    public const string InviteNo = "invite_no";
    public const string InviteYes = "invite_yes";
    public const string Leanidle = "leanidle";
    public const string Leanin = "leanin";
    public const string Leanout = "leanout";
    public const string PrtialGngtlka = "prtial_gngtlka";
    public const string PrtialGngtlkb = "prtial_gngtlkb";
    public const string PrtialGngtlkc = "prtial_gngtlkc";
    public const string PrtialGngtlkd = "prtial_gngtlkd";
    public const string PrtialGngtlke = "prtial_gngtlke";
    public const string PrtialGngtlkf = "prtial_gngtlkf";
    public const string PrtialGngtlkg = "prtial_gngtlkg";
    public const string PrtialGngtlkh = "prtial_gngtlkh";
    public const string PrtialHndshk01 = "prtial_hndshk_01";
    public const string PrtialHndshkBiz01 = "prtial_hndshk_biz_01";
    public const string ShakeCara = "shake_cara";
    public const string ShakeCark = "shake_cark";
    public const string ShakeCarsh = "shake_carsh";
    public const string SmkcigPrtl = "smkcig_prtl";
    public const string SmkcigPrtlF = "smkcig_prtl_f";
}

public class AnimGroup53
{
    public const string Gsign1 = "gsign1";
    public const string Gsign1lh = "gsign1lh";
    public const string Gsign2 = "gsign2";
    public const string Gsign2lh = "gsign2lh";
    public const string Gsign3 = "gsign3";
    public const string Gsign3lh = "gsign3lh";
    public const string Gsign4 = "gsign4";
    public const string Gsign4lh = "gsign4lh";
    public const string Gsign5 = "gsign5";
    public const string Gsign5lh = "gsign5lh";
    public const string Lhgsign1 = "lhgsign1";
    public const string Lhgsign2 = "lhgsign2";
    public const string Lhgsign3 = "lhgsign3";
    public const string Lhgsign4 = "lhgsign4";
    public const string Lhgsign5 = "lhgsign5";
    public const string Rhgsign1 = "rhgsign1";
    public const string Rhgsign2 = "rhgsign2";
    public const string Rhgsign3 = "rhgsign3";
    public const string Rhgsign4 = "rhgsign4";
    public const string Rhgsign5 = "rhgsign5";
}

public class AnimGroup54
{
    public const string GdbCar2Ply = "gdb_car2_ply";
    public const string GdbCar2Smo = "gdb_car2_smo";
    public const string GdbCar2Swe = "gdb_car2_swe";
    public const string GdbCarPly = "gdb_car_ply";
    public const string GdbCarRyd = "gdb_car_ryd";
    public const string GdbCarSmo = "gdb_car_smo";
    public const string GdbCarSwe = "gdb_car_swe";
}

public class AnimGroup55
{
    public const string GogglesPutOn = "goggles_put_on";
}

public class AnimGroup56
{
    public const string GraffitiChkout = "graffiti_chkout";
    public const string SpraycanFire = "spraycan_fire";
}

public class AnimGroup57
{
    public const string MrnfLoop = "mrnf_loop";
    public const string MrnmLoop = "mrnm_loop";
    public const string PrstLoopa = "prst_loopa";
}

public class AnimGroup58
{
    public const string WeaponStartThrow = "weapon_start_throw";
    public const string WeaponThrow = "weapon_throw";
    public const string WeaponThrowu = "weapon_throwu";
}

public class AnimGroup59
{
    public const string Gymshadowbox = "gymshadowbox";
    public const string GymBikeCelebrate = "gym_bike_celebrate";
    public const string GymBikeFast = "gym_bike_fast";
    public const string GymBikeFaster = "gym_bike_faster";
    public const string GymBikeGetoff = "gym_bike_getoff";
    public const string GymBikeGeton = "gym_bike_geton";
    public const string GymBikePedal = "gym_bike_pedal";
    public const string GymBikeSlow = "gym_bike_slow";
    public const string GymBikeStill = "gym_bike_still";
    public const string GymJogFalloff = "gym_jog_falloff";
    public const string GymShadowbox = "gym_shadowbox";
    public const string GymTreadCelebrate = "gym_tread_celebrate";
    public const string GymTreadFalloff = "gym_tread_falloff";
    public const string GymTreadGetoff = "gym_tread_getoff";
    public const string GymTreadGeton = "gym_tread_geton";
    public const string GymTreadJog = "gym_tread_jog";
    public const string GymTreadSprint = "gym_tread_sprint";
    public const string GymTreadTired = "gym_tread_tired";
    public const string GymTreadWalk = "gym_tread_walk";
    public const string GymWalkFalloff = "gym_walk_falloff";
    public const string PedalsFast = "pedals_fast";
    public const string PedalsMed = "pedals_med";
    public const string PedalsSlow = "pedals_slow";
    public const string PedalsStill = "pedals_still";
}

public class AnimGroup60
{
    public const string BrbBeard01 = "brb_beard_01";
    public const string BrbBuy = "brb_buy";
    public const string BrbCut = "brb_cut";
    public const string BrbCutIn = "brb_cut_in";
    public const string BrbCutOut = "brb_cut_out";
    public const string BrbHair01 = "brb_hair_01";
    public const string BrbHair02 = "brb_hair_02";
    public const string BrbIn = "brb_in";
    public const string BrbLoop = "brb_loop";
    public const string BrbOut = "brb_out";
    public const string BrbSitIn = "brb_sit_in";
    public const string BrbSitLoop = "brb_sit_loop";
    public const string BrbSitOut = "brb_sit_out";
}

public class AnimGroup61
{
    public const string CasG2Gasko = "cas_g2_gasko";
    public const string SwtWllpkL = "swt_wllpk_l";
    public const string SwtWllpkLBack = "swt_wllpk_l_back";
    public const string SwtWllpkR = "swt_wllpk_r";
    public const string SwtWllpkRBack = "swt_wllpk_r_back";
    public const string SwtWllshootInL = "swt_wllshoot_in_l";
    public const string SwtWllshootInR = "swt_wllshoot_in_r";
    public const string SwtWllshootOutL = "swt_wllshoot_out_l";
    public const string SwtWllshootOutR = "swt_wllshoot_out_r";
    public const string UseSwipecard = "use_swipecard";
}

public class AnimGroup62
{
    public const string BedInL = "bed_in_l";
    public const string BedInR = "bed_in_r";
    public const string BedLoopL = "bed_loop_l";
    public const string BedLoopR = "bed_loop_r";
    public const string BedOutL = "bed_out_l";
    public const string BedOutR = "bed_out_r";
    public const string LouIn = "lou_in";
    public const string LouLoop = "lou_loop";
    public const string LouOut = "lou_out";
    public const string WashUp = "wash_up";
}

public class AnimGroup63
{
    public const string FfDamFwd = "ff_dam_fwd";
    public const string OffSit2Idle180 = "off_sit_2idle_180";
    public const string OffSitBoredLoop = "off_sit_bored_loop";
    public const string OffSitCrash = "off_sit_crash";
    public const string OffSitDrink = "off_sit_drink";
    public const string OffSitIdleLoop = "off_sit_idle_loop";
    public const string OffSitIn = "off_sit_in";
    public const string OffSitRead = "off_sit_read";
    public const string OffSitTypeLoop = "off_sit_type_loop";
    public const string OffSitWatch = "off_sit_watch";
}

public class AnimGroup64
{
    public const string ShopCashier = "shop_cashier";
    public const string ShopIn = "shop_in";
    public const string ShopLooka = "shop_looka";
    public const string ShopLookb = "shop_lookb";
    public const string ShopLoop = "shop_loop";
    public const string ShopOut = "shop_out";
    public const string ShopPay = "shop_pay";
    public const string ShopShelf = "shop_shelf";
}

public class AnimGroup65
{
    public const string Girl01 = "girl_01";
    public const string Girl02 = "girl_02";
    public const string Player01 = "player_01";
    public const string Smoke01 = "smoke_01";
}

public class AnimGroup66
{
    public const string KartGetinLhs = "kart_getin_lhs";
    public const string KartGetinRhs = "kart_getin_rhs";
    public const string KartGetoutLhs = "kart_getout_lhs";
    public const string KartGetoutRhs = "kart_getout_rhs";
}

public class AnimGroup67
{
    public const string BdGfWave = "bd_gf_wave";
    public const string Gfwave2 = "gfwave2";
    public const string GfCarargue01 = "gf_carargue_01";
    public const string GfCarargue02 = "gf_carargue_02";
    public const string GfCarspot = "gf_carspot";
    public const string GfStreetargue01 = "gf_streetargue_01";
    public const string GfStreetargue02 = "gf_streetargue_02";
    public const string GiftGet = "gift_get";
    public const string GiftGive = "gift_give";
    public const string GrlfrdKiss01 = "grlfrd_kiss_01";
    public const string GrlfrdKiss02 = "grlfrd_kiss_02";
    public const string GrlfrdKiss03 = "grlfrd_kiss_03";
    public const string PlayaKiss01 = "playa_kiss_01";
    public const string PlayaKiss02 = "playa_kiss_02";
    public const string PlayaKiss03 = "playa_kiss_03";
}

public class AnimGroup68
{
    public const string KillKnifePedDamage = "kill_knife_ped_damage";
    public const string KillKnifePedDie = "kill_knife_ped_die";
    public const string KillKnifePlayer = "kill_knife_player";
    public const string KillPartial = "kill_partial";
    public const string Knife1 = "knife_1";
    public const string Knife2 = "knife_2";
    public const string Knife3 = "knife_3";
    public const string Knife4 = "knife_4";
    public const string KnifeBlock = "knife_block";
    public const string KnifeG = "knife_g";
    public const string KnifeHit1 = "knife_hit_1";
    public const string KnifeHit2 = "knife_hit_2";
    public const string KnifeHit3 = "knife_hit_3";
    public const string KnifeIdle = "knife_idle";
    public const string KnifePart = "knife_part";
    public const string WeaponKnifeidle = "weapon_knifeidle";
}

public class AnimGroup69
{
    public const string LapdanD = "lapdan_d";
    public const string LapdanP = "lapdan_p";
}

public class AnimGroup70
{
    public const string LapdanD = "lapdan_d";
    public const string LapdanP = "lapdan_p";
}

public class AnimGroup71
{
    public const string LapdanD = "lapdan_d";
    public const string LapdanP = "lapdan_p";
}

public class AnimGroup72
{
    public const string FSmkleanLoop = "f_smklean_loop";
    public const string LrgirlBdbnce = "lrgirl_bdbnce";
    public const string LrgirlHair = "lrgirl_hair";
    public const string LrgirlHurry = "lrgirl_hurry";
    public const string LrgirlIdleloop = "lrgirl_idleloop";
    public const string LrgirlIdleToL0 = "lrgirl_idle_to_l0";
    public const string LrgirlL0Bnce = "lrgirl_l0_bnce";
    public const string LrgirlL0Loop = "lrgirl_l0_loop";
    public const string LrgirlL0ToL1 = "lrgirl_l0_to_l1";
    public const string LrgirlL12ToL0 = "lrgirl_l12_to_l0";
    public const string LrgirlL1Bnce = "lrgirl_l1_bnce";
    public const string LrgirlL1Loop = "lrgirl_l1_loop";
    public const string LrgirlL1ToL2 = "lrgirl_l1_to_l2";
    public const string LrgirlL2Bnce = "lrgirl_l2_bnce";
    public const string LrgirlL2Loop = "lrgirl_l2_loop";
    public const string LrgirlL2ToL3 = "lrgirl_l2_to_l3";
    public const string LrgirlL345ToL1 = "lrgirl_l345_to_l1";
    public const string LrgirlL3Bnce = "lrgirl_l3_bnce";
    public const string LrgirlL3Loop = "lrgirl_l3_loop";
    public const string LrgirlL3ToL4 = "lrgirl_l3_to_l4";
    public const string LrgirlL4Bnce = "lrgirl_l4_bnce";
    public const string LrgirlL4Loop = "lrgirl_l4_loop";
    public const string LrgirlL4ToL5 = "lrgirl_l4_to_l5";
    public const string LrgirlL5Bnce = "lrgirl_l5_bnce";
    public const string LrgirlL5Loop = "lrgirl_l5_loop";
    public const string MSmkleanLoop = "m_smklean_loop";
    public const string MSmkstndLoop = "m_smkstnd_loop";
    public const string PrtialGngtlkb = "prtial_gngtlkb";
    public const string PrtialGngtlkc = "prtial_gngtlkc";
    public const string PrtialGngtlkd = "prtial_gngtlkd";
    public const string PrtialGngtlke = "prtial_gngtlke";
    public const string PrtialGngtlkf = "prtial_gngtlkf";
    public const string PrtialGngtlkg = "prtial_gngtlkg";
    public const string PrtialGngtlkh = "prtial_gngtlkh";
    public const string RapALoop = "rap_a_loop";
    public const string RapBLoop = "rap_b_loop";
    public const string RapCLoop = "rap_c_loop";
    public const string SitRelaxed = "sit_relaxed";
    public const string TapHand = "tap_hand";
}

public class AnimGroup73
{
    public const string CarhitHangon = "carhit_hangon";
    public const string CarhitTumble = "carhit_tumble";
    public const string Donutdrop = "donutdrop";
    public const string FenChoppaL1 = "fen_choppa_l1";
    public const string FenChoppaL2 = "fen_choppa_l2";
    public const string FenChoppaL3 = "fen_choppa_l3";
    public const string FenChoppaR1 = "fen_choppa_r1";
    public const string FenChoppaR2 = "fen_choppa_r2";
    public const string FenChoppaR3 = "fen_choppa_r3";
    public const string HangonStunLoop = "hangon_stun_loop";
    public const string HangonStunTurn = "hangon_stun_turn";
    public const string MdBike2Hang = "md_bike_2_hang";
    public const string MdBikeJmpBl = "md_bike_jmp_bl";
    public const string MdBikeJmpF = "md_bike_jmp_f";
    public const string MdBikeLndBl = "md_bike_lnd_bl";
    public const string MdBikeLndDieBl = "md_bike_lnd_die_bl";
    public const string MdBikeLndDieF = "md_bike_lnd_die_f";
    public const string MdBikeLndF = "md_bike_lnd_f";
    public const string MdBikeLndRoll = "md_bike_lnd_roll";
    public const string MdBikeLndRollF = "md_bike_lnd_roll_f";
    public const string MdBikePunch = "md_bike_punch";
    public const string MdBikePunchF = "md_bike_punch_f";
    public const string MdBikeShotF = "md_bike_shot_f";
    public const string MdHangLndRoll = "md_hang_lnd_roll";
    public const string MdHangLoop = "md_hang_loop";
}

public class AnimGroup74
{
    public const string EndSc1Ply = "end_sc1_ply";
    public const string EndSc1Ryd = "end_sc1_ryd";
    public const string EndSc1Smo = "end_sc1_smo";
    public const string EndSc1Swe = "end_sc1_swe";
    public const string EndSc2Ply = "end_sc2_ply";
    public const string EndSc2Ryd = "end_sc2_ryd";
    public const string EndSc2Smo = "end_sc2_smo";
    public const string EndSc2Swe = "end_sc2_swe";
}

public class AnimGroup75
{
    public const string Cpr = "cpr";
}

public class AnimGroup76
{
    public const string Bitchslap = "bitchslap";
    public const string BmxCelebrate = "bmx_celebrate";
    public const string BmxComeon = "bmx_comeon";
    public const string BmxIdleloop01 = "bmx_idleloop_01";
    public const string BmxIdleloop02 = "bmx_idleloop_02";
    public const string BmxTalkleftIn = "bmx_talkleft_in";
    public const string BmxTalkleftLoop = "bmx_talkleft_loop";
    public const string BmxTalkleftOut = "bmx_talkleft_out";
    public const string BmxTalkrightIn = "bmx_talkright_in";
    public const string BmxTalkrightLoop = "bmx_talkright_loop";
    public const string BmxTalkrightOut = "bmx_talkright_out";
    public const string BngWndw = "bng_wndw";
    public const string BngWndw02 = "bng_wndw_02";
    public const string CasePickup = "case_pickup";
    public const string DoorJet = "door_jet";
    public const string GrabL = "grab_l";
    public const string GrabR = "grab_r";
    public const string HikerPose = "hiker_pose";
    public const string HikerPoseL = "hiker_pose_l";
    public const string IdleChat02 = "idle_chat_02";
    public const string KatThrowK = "kat_throw_k";
    public const string KatThrowO = "kat_throw_o";
    public const string KatThrowP = "kat_throw_p";
    public const string PassRifleO = "pass_rifle_o";
    public const string PassRiflePed = "pass_rifle_ped";
    public const string PassRiflePly = "pass_rifle_ply";
    public const string PickupBox = "pickup_box";
    public const string PlaneDoor = "plane_door";
    public const string PlaneExit = "plane_exit";
    public const string PlaneHijack = "plane_hijack";
    public const string Plunger01 = "plunger_01";
    public const string PlyrleanLoop = "plyrlean_loop";
    public const string PlyrShkhead = "plyr_shkhead";
    public const string RunDive = "run_dive";
    public const string Scratchballs01 = "scratchballs_01";
    public const string SeatLr = "seat_lr";
    public const string SeatTalk01 = "seat_talk_01";
    public const string SeatTalk02 = "seat_talk_02";
    public const string SeatWatch = "seat_watch";
    public const string SmalplaneDoor = "smalplane_door";
    public const string SmlplaneDoor = "smlplane_door";
}

public class AnimGroup77
{
    public const string MtbBack = "mtb_back";
    public const string MtbBunnyhop = "mtb_bunnyhop";
    public const string MtbDrivebyft = "mtb_drivebyft";
    public const string MtbDrivebyLhs = "mtb_driveby_lhs";
    public const string MtbDrivebyRhs = "mtb_driveby_rhs";
    public const string MtbFwd = "mtb_fwd";
    public const string MtbGetoffback = "mtb_getoffback";
    public const string MtbGetofflhs = "mtb_getofflhs";
    public const string MtbGetoffrhs = "mtb_getoffrhs";
    public const string MtbJumponl = "mtb_jumponl";
    public const string MtbJumponr = "mtb_jumponr";
    public const string MtbLeft = "mtb_left";
    public const string MtbPedal = "mtb_pedal";
    public const string MtbPushes = "mtb_pushes";
    public const string MtbRide = "mtb_ride";
    public const string MtbRight = "mtb_right";
    public const string MtbSprint = "mtb_sprint";
    public const string MtbStill = "mtb_still";
}

public class AnimGroup78
{
    public const string MsclewalkstArmed = "msclewalkst_armed";
    public const string MsclewalkstCsaw = "msclewalkst_csaw";
    public const string MscleRcktRun = "mscle_rckt_run";
    public const string MscleRcktWalkst = "mscle_rckt_walkst";
    public const string MscleRunCsaw = "mscle_run_csaw";
    public const string Muscleidle = "muscleidle";
    public const string MuscleidleArmed = "muscleidle_armed";
    public const string MuscleidleCsaw = "muscleidle_csaw";
    public const string MuscleidleRocket = "muscleidle_rocket";
    public const string Musclerun = "musclerun";
    public const string MusclerunArmed = "musclerun_armed";
    public const string Musclesprint = "musclesprint";
    public const string Musclewalk = "musclewalk";
    public const string Musclewalkstart = "musclewalkstart";
    public const string MusclewalkArmed = "musclewalk_armed";
    public const string MusclewalkCsaw = "musclewalk_csaw";
    public const string MusclewalkRocket = "musclewalk_rocket";
}

public class AnimGroup79
{
    public const string NevadaGetin = "nevada_getin";
    public const string NevadaGetout = "nevada_getout";
}

public class AnimGroup80
{
    public const string LkaroundIn = "lkaround_in";
    public const string LkaroundLoop = "lkaround_loop";
    public const string LkaroundOut = "lkaround_out";
    public const string LkupIn = "lkup_in";
    public const string LkupLoop = "lkup_loop";
    public const string LkupOut = "lkup_out";
    public const string LkupPoint = "lkup_point";
    public const string PanicCower = "panic_cower";
    public const string PanicHide = "panic_hide";
    public const string PanicIn = "panic_in";
    public const string PanicLoop = "panic_loop";
    public const string PanicOut = "panic_out";
    public const string PanicPoint = "panic_point";
    public const string PanicShout = "panic_shout";
    public const string PointupIn = "pointup_in";
    public const string PointupLoop = "pointup_loop";
    public const string PointupOut = "pointup_out";
    public const string PointupShout = "pointup_shout";
    public const string PointIn = "point_in";
    public const string PointLoop = "point_loop";
    public const string PointOut = "point_out";
    public const string Shout01 = "shout_01";
    public const string Shout02 = "shout_02";
    public const string ShoutIn = "shout_in";
    public const string ShoutLoop = "shout_loop";
    public const string ShoutOut = "shout_out";
    public const string WaveIn = "wave_in";
    public const string WaveLoop = "wave_loop";
    public const string WaveOut = "wave_out";
}

public class AnimGroup81
{
    public const string BetslpIn = "betslp_in";
    public const string BetslpLkabt = "betslp_lkabt";
    public const string BetslpLoop = "betslp_loop";
    public const string BetslpOut = "betslp_out";
    public const string BetslpTnk = "betslp_tnk";
    public const string WtchraceCmon = "wtchrace_cmon";
    public const string WtchraceIn = "wtchrace_in";
    public const string WtchraceLoop = "wtchrace_loop";
    public const string WtchraceLose = "wtchrace_lose";
    public const string WtchraceOut = "wtchrace_out";
    public const string WtchraceWin = "wtchrace_win";
}

public class AnimGroup82
{
    public const string FallSkydive = "fall_skydive";
    public const string FallSkydiveAccel = "fall_skydive_accel";
    public const string FallSkydiveDie = "fall_skydive_die";
    public const string FallSkydiveL = "fall_skydive_l";
    public const string FallSkydiveR = "fall_skydive_r";
    public const string ParaDecel = "para_decel";
    public const string ParaDecelO = "para_decel_o";
    public const string ParaFloat = "para_float";
    public const string ParaFloatO = "para_float_o";
    public const string ParaLand = "para_land";
    public const string ParaLandO = "para_land_o";
    public const string ParaLandWater = "para_land_water";
    public const string ParaLandWaterO = "para_land_water_o";
    public const string ParaOpen = "para_open";
    public const string ParaOpenO = "para_open_o";
    public const string ParaRipLandO = "para_rip_land_o";
    public const string ParaRipLoopO = "para_rip_loop_o";
    public const string ParaRipO = "para_rip_o";
    public const string ParaSteerl = "para_steerl";
    public const string ParaSteerlO = "para_steerl_o";
    public const string ParaSteerr = "para_steerr";
    public const string ParaSteerrO = "para_steerr_o";
}

public class AnimGroup83
{
    public const string TaiChiIn = "tai_chi_in";
    public const string TaiChiLoop = "tai_chi_loop";
    public const string TaiChiOut = "tai_chi_out";
}

public class AnimGroup84
{
    public const string PissIn = "piss_in";
    public const string PissLoop = "piss_loop";
    public const string PissOut = "piss_out";
    public const string PnmArgue1A = "pnm_argue1_a";
    public const string PnmArgue1B = "pnm_argue1_b";
    public const string PnmArgue2A = "pnm_argue2_a";
    public const string PnmArgue2B = "pnm_argue2_b";
    public const string PnmLoopA = "pnm_loop_a";
    public const string PnmLoopB = "pnm_loop_b";
    public const string WankIn = "wank_in";
    public const string WankLoop = "wank_loop";
    public const string WankOut = "wank_out";
}

public class AnimGroup85
{
    public const string Abseil = "abseil";
    public const string Arrestgun = "arrestgun";
    public const string Atm = "atm";
    public const string BikeElbowl = "bike_elbowl";
    public const string BikeElbowr = "bike_elbowr";
    public const string BikeFallr = "bike_fallr";
    public const string BikeFallOff = "bike_fall_off";
    public const string BikePickupl = "bike_pickupl";
    public const string BikePickupr = "bike_pickupr";
    public const string BikePullupl = "bike_pullupl";
    public const string BikePullupr = "bike_pullupr";
    public const string Bomber = "bomber";
    public const string CarAlignhiLhs = "car_alignhi_lhs";
    public const string CarAlignhiRhs = "car_alignhi_rhs";
    public const string CarAlignLhs = "car_align_lhs";
    public const string CarAlignRhs = "car_align_rhs";
    public const string CarClosedoorlLhs = "car_closedoorl_lhs";
    public const string CarClosedoorlRhs = "car_closedoorl_rhs";
    public const string CarClosedoorLhs = "car_closedoor_lhs";
    public const string CarClosedoorRhs = "car_closedoor_rhs";
    public const string CarCloseLhs = "car_close_lhs";
    public const string CarCloseRhs = "car_close_rhs";
    public const string CarCrawloutrhs = "car_crawloutrhs";
    public const string CarDeadLhs = "car_dead_lhs";
    public const string CarDeadRhs = "car_dead_rhs";
    public const string CarDoorlockedLhs = "car_doorlocked_lhs";
    public const string CarDoorlockedRhs = "car_doorlocked_rhs";
    public const string CarFalloutLhs = "car_fallout_lhs";
    public const string CarFalloutRhs = "car_fallout_rhs";
    public const string CarGetinlLhs = "car_getinl_lhs";
    public const string CarGetinlRhs = "car_getinl_rhs";
    public const string CarGetinLhs = "car_getin_lhs";
    public const string CarGetinRhs = "car_getin_rhs";
    public const string CarGetoutlLhs = "car_getoutl_lhs";
    public const string CarGetoutlRhs = "car_getoutl_rhs";
    public const string CarGetoutLhs = "car_getout_lhs";
    public const string CarGetoutRhs = "car_getout_rhs";
    public const string CarHookertalk = "car_hookertalk";
    public const string CarJackedlhs = "car_jackedlhs";
    public const string CarJackedrhs = "car_jackedrhs";
    public const string CarJumpinLhs = "car_jumpin_lhs";
    public const string CarLb = "car_lb";
    public const string CarLbPro = "car_lb_pro";
    public const string CarLbWeak = "car_lb_weak";
    public const string CarLjackedlhs = "car_ljackedlhs";
    public const string CarLjackedrhs = "car_ljackedrhs";
    public const string CarLshuffleRhs = "car_lshuffle_rhs";
    public const string CarLsit = "car_lsit";
    public const string CarOpenLhs = "car_open_lhs";
    public const string CarOpenRhs = "car_open_rhs";
    public const string CarPulloutlLhs = "car_pulloutl_lhs";
    public const string CarPulloutlRhs = "car_pulloutl_rhs";
    public const string CarPulloutLhs = "car_pullout_lhs";
    public const string CarPulloutRhs = "car_pullout_rhs";
    public const string CarQjacked = "car_qjacked";
    public const string CarRolldoor = "car_rolldoor";
    public const string CarRolldoorlo = "car_rolldoorlo";
    public const string CarRolloutLhs = "car_rollout_lhs";
    public const string CarRolloutRhs = "car_rollout_rhs";
    public const string CarShuffleRhs = "car_shuffle_rhs";
    public const string CarSit = "car_sit";
    public const string CarSitp = "car_sitp";
    public const string CarSitplo = "car_sitplo";
    public const string CarSitPro = "car_sit_pro";
    public const string CarSitWeak = "car_sit_weak";
    public const string CarTuneRadio = "car_tune_radio";
    public const string ClimbIdle = "climb_idle";
    public const string ClimbJump = "climb_jump";
    public const string ClimbJump2fall = "climb_jump2fall";
    public const string ClimbJumpB = "climb_jump_b";
    public const string ClimbPull = "climb_pull";
    public const string ClimbStand = "climb_stand";
    public const string ClimbStandFinish = "climb_stand_finish";
    public const string Cower = "cower";
    public const string CrouchRollL = "crouch_roll_l";
    public const string CrouchRollR = "crouch_roll_r";
    public const string DamArmlFrmbk = "dam_arml_frmbk";
    public const string DamArmlFrmft = "dam_arml_frmft";
    public const string DamArmlFrmlt = "dam_arml_frmlt";
    public const string DamArmrFrmbk = "dam_armr_frmbk";
    public const string DamArmrFrmft = "dam_armr_frmft";
    public const string DamArmrFrmrt = "dam_armr_frmrt";
    public const string DamLeglFrmbk = "dam_legl_frmbk";
    public const string DamLeglFrmft = "dam_legl_frmft";
    public const string DamLeglFrmlt = "dam_legl_frmlt";
    public const string DamLegrFrmbk = "dam_legr_frmbk";
    public const string DamLegrFrmft = "dam_legr_frmft";
    public const string DamLegrFrmrt = "dam_legr_frmrt";
    public const string DamStomachFrmbk = "dam_stomach_frmbk";
    public const string DamStomachFrmft = "dam_stomach_frmft";
    public const string DamStomachFrmlt = "dam_stomach_frmlt";
    public const string DamStomachFrmrt = "dam_stomach_frmrt";
    public const string DoorLhingeO = "door_lhinge_o";
    public const string DoorRhingeO = "door_rhinge_o";
    public const string DrivebylL = "drivebyl_l";
    public const string DrivebylR = "drivebyl_r";
    public const string DrivebyL = "driveby_l";
    public const string DrivebyR = "driveby_r";
    public const string DriveBoat = "drive_boat";
    public const string DriveBoatBack = "drive_boat_back";
    public const string DriveBoatL = "drive_boat_l";
    public const string DriveBoatR = "drive_boat_r";
    public const string DriveL = "drive_l";
    public const string DriveLoL = "drive_lo_l";
    public const string DriveLoR = "drive_lo_r";
    public const string DriveLPro = "drive_l_pro";
    public const string DriveLProSlow = "drive_l_pro_slow";
    public const string DriveLSlow = "drive_l_slow";
    public const string DriveLWeak = "drive_l_weak";
    public const string DriveLWeakSlow = "drive_l_weak_slow";
    public const string DriveR = "drive_r";
    public const string DriveRPro = "drive_r_pro";
    public const string DriveRProSlow = "drive_r_pro_slow";
    public const string DriveRSlow = "drive_r_slow";
    public const string DriveRWeak = "drive_r_weak";
    public const string DriveRWeakSlow = "drive_r_weak_slow";
    public const string DriveTruck = "drive_truck";
    public const string DriveTruckBack = "drive_truck_back";
    public const string DriveTruckL = "drive_truck_l";
    public const string DriveTruckR = "drive_truck_r";
    public const string Drown = "drown";
    public const string DuckCower = "duck_cower";
    public const string Endchat01 = "endchat_01";
    public const string Endchat02 = "endchat_02";
    public const string Endchat03 = "endchat_03";
    public const string EvDive = "ev_dive";
    public const string EvStep = "ev_step";
    public const string Facanger = "facanger";
    public const string Facgum = "facgum";
    public const string Facsurp = "facsurp";
    public const string Facsurpm = "facsurpm";
    public const string Factalk = "factalk";
    public const string Facurios = "facurios";
    public const string FallBack = "fall_back";
    public const string FallCollapse = "fall_collapse";
    public const string FallFall = "fall_fall";
    public const string FallFront = "fall_front";
    public const string FallGlide = "fall_glide";
    public const string FallLand = "fall_land";
    public const string FallSkydive = "fall_skydive";
    public const string Fight2idle = "fight2idle";
    public const string Fighta1 = "fighta_1";
    public const string Fighta2 = "fighta_2";
    public const string Fighta3 = "fighta_3";
    public const string FightaBlock = "fighta_block";
    public const string FightaG = "fighta_g";
    public const string FightaM = "fighta_m";
    public const string Fightidle = "fightidle";
    public const string Fightshb = "fightshb";
    public const string Fightshf = "fightshf";
    public const string FightshBwd = "fightsh_bwd";
    public const string FightshFwd = "fightsh_fwd";
    public const string FightshLeft = "fightsh_left";
    public const string FightshRight = "fightsh_right";
    public const string FleeLkaround01 = "flee_lkaround_01";
    public const string FloorHit = "floor_hit";
    public const string FloorHitF = "floor_hit_f";
    public const string Fucku = "fucku";
    public const string GangGunstand = "gang_gunstand";
    public const string GasCwr = "gas_cwr";
    public const string Getup = "getup";
    public const string GetupFront = "getup_front";
    public const string GumEat = "gum_eat";
    public const string Guncrouchbwd = "guncrouchbwd";
    public const string Guncrouchfwd = "guncrouchfwd";
    public const string GunmoveBwd = "gunmove_bwd";
    public const string GunmoveFwd = "gunmove_fwd";
    public const string GunmoveL = "gunmove_l";
    public const string GunmoveR = "gunmove_r";
    public const string Gun2Idle = "gun_2_idle";
    public const string GunButt = "gun_butt";
    public const string GunButtCrouch = "gun_butt_crouch";
    public const string GunStand = "gun_stand";
    public const string Handscower = "handscower";
    public const string Handsup = "handsup";
    public const string Hita1 = "hita_1";
    public const string Hita2 = "hita_2";
    public const string Hita3 = "hita_3";
    public const string HitBack = "hit_back";
    public const string HitBehind = "hit_behind";
    public const string HitFront = "hit_front";
    public const string HitGunButt = "hit_gun_butt";
    public const string HitL = "hit_l";
    public const string HitR = "hit_r";
    public const string HitWalk = "hit_walk";
    public const string HitWall = "hit_wall";
    public const string IdlestanceFat = "idlestance_fat";
    public const string IdlestanceOld = "idlestance_old";
    public const string IdleArmed = "idle_armed";
    public const string IdleChat = "idle_chat";
    public const string IdleCsaw = "idle_csaw";
    public const string IdleGang1 = "idle_gang1";
    public const string IdleHbhb = "idle_hbhb";
    public const string IdleRocket = "idle_rocket";
    public const string IdleStance = "idle_stance";
    public const string IdleTaxi = "idle_taxi";
    public const string IdleTired = "idle_tired";
    public const string JetpackIdle = "jetpack_idle";
    public const string JogFemalea = "jog_femalea";
    public const string JogMalea = "jog_malea";
    public const string JumpGlide = "jump_glide";
    public const string JumpLand = "jump_land";
    public const string JumpLaunch = "jump_launch";
    public const string JumpLaunchR = "jump_launch_r";
    public const string KartDrive = "kart_drive";
    public const string KartL = "kart_l";
    public const string KartLb = "kart_lb";
    public const string KartR = "kart_r";
    public const string KdLeft = "kd_left";
    public const string KdRight = "kd_right";
    public const string KoShotFace = "ko_shot_face";
    public const string KoShotFront = "ko_shot_front";
    public const string KoShotStom = "ko_shot_stom";
    public const string KoSkidBack = "ko_skid_back";
    public const string KoSkidFront = "ko_skid_front";
    public const string KoSpinL = "ko_spin_l";
    public const string KoSpinR = "ko_spin_r";
    public const string PassSmokeInCar = "pass_smoke_in_car";
    public const string PhoneIn = "phone_in";
    public const string PhoneOut = "phone_out";
    public const string PhoneTalk = "phone_talk";
    public const string PlayerSneak = "player_sneak";
    public const string PlayerSneakWalkstart = "player_sneak_walkstart";
    public const string Roadcross = "roadcross";
    public const string RoadcrossFemale = "roadcross_female";
    public const string RoadcrossGang = "roadcross_gang";
    public const string RoadcrossOld = "roadcross_old";
    public const string Run1Armed = "run_1armed";
    public const string RunArmed = "run_armed";
    public const string RunCivi = "run_civi";
    public const string RunCsaw = "run_csaw";
    public const string RunFat = "run_fat";
    public const string RunFatold = "run_fatold";
    public const string RunGang1 = "run_gang1";
    public const string RunLeft = "run_left";
    public const string RunOld = "run_old";
    public const string RunPlayer = "run_player";
    public const string RunRight = "run_right";
    public const string RunRocket = "run_rocket";
    public const string RunStop = "run_stop";
    public const string RunStopr = "run_stopr";
    public const string RunWuzi = "run_wuzi";
    public const string SeatDown = "seat_down";
    public const string SeatIdle = "seat_idle";
    public const string SeatUp = "seat_up";
    public const string ShotLeftp = "shot_leftp";
    public const string ShotPartial = "shot_partial";
    public const string ShotPartialB = "shot_partial_b";
    public const string ShotRightp = "shot_rightp";
    public const string ShovePartial = "shove_partial";
    public const string SmokeInCar = "smoke_in_car";
    public const string SprintCivi = "sprint_civi";
    public const string SprintPanic = "sprint_panic";
    public const string SprintWuzi = "sprint_wuzi";
    public const string SwatRun = "swat_run";
    public const string SwimTread = "swim_tread";
    public const string TapHand = "tap_hand";
    public const string TapHandp = "tap_handp";
    public const string Turn180 = "turn_180";
    public const string TurnL = "turn_l";
    public const string TurnR = "turn_r";
    public const string WalkArmed = "walk_armed";
    public const string WalkCivi = "walk_civi";
    public const string WalkCsaw = "walk_csaw";
    public const string WalkDoorpartial = "walk_doorpartial";
    public const string WalkDrunk = "walk_drunk";
    public const string WalkFat = "walk_fat";
    public const string WalkFatold = "walk_fatold";
    public const string WalkGang1 = "walk_gang1";
    public const string WalkGang2 = "walk_gang2";
    public const string WalkOld = "walk_old";
    public const string WalkPlayer = "walk_player";
    public const string WalkRocket = "walk_rocket";
    public const string WalkShuffle = "walk_shuffle";
    public const string WalkStart = "walk_start";
    public const string WalkStartArmed = "walk_start_armed";
    public const string WalkStartCsaw = "walk_start_csaw";
    public const string WalkStartRocket = "walk_start_rocket";
    public const string WalkWuzi = "walk_wuzi";
    public const string WeaponCrouch = "weapon_crouch";
    public const string WomanIdlestance = "woman_idlestance";
    public const string WomanRun = "woman_run";
    public const string WomanRunbusy = "woman_runbusy";
    public const string WomanRunfatold = "woman_runfatold";
    public const string WomanRunpanic = "woman_runpanic";
    public const string WomanRunsexy = "woman_runsexy";
    public const string WomanWalkbusy = "woman_walkbusy";
    public const string WomanWalkfatold = "woman_walkfatold";
    public const string WomanWalknorm = "woman_walknorm";
    public const string WomanWalkold = "woman_walkold";
    public const string WomanWalkpro = "woman_walkpro";
    public const string WomanWalksexy = "woman_walksexy";
    public const string WomanWalkshop = "woman_walkshop";
    public const string Xpressscratch = "xpressscratch";
}

public class AnimGroup86
{
    public const string PlyrDrivebybwd = "plyr_drivebybwd";
    public const string PlyrDrivebyfwd = "plyr_drivebyfwd";
    public const string PlyrDrivebylhs = "plyr_drivebylhs";
    public const string PlyrDrivebyrhs = "plyr_drivebyrhs";
}

public class AnimGroup87
{
    public const string Shift = "shift";
    public const string Shldr = "shldr";
    public const string Stretch = "stretch";
    public const string Strleg = "strleg";
    public const string Time = "time";
}

public class AnimGroup88
{
    public const string CoptrafAway = "coptraf_away";
    public const string CoptrafCome = "coptraf_come";
    public const string CoptrafLeft = "coptraf_left";
    public const string CoptrafStop = "coptraf_stop";
    public const string CopGetoutcarLhs = "cop_getoutcar_lhs";
    public const string CopMoveFwd = "cop_move_fwd";
    public const string CrmDrgbst01 = "crm_drgbst_01";
    public const string DoorKick = "door_kick";
    public const string PlcDrgbst01 = "plc_drgbst_01";
    public const string PlcDrgbst02 = "plc_drgbst_02";
}

public class AnimGroup89
{
    public const string PoolChalkcue = "pool_chalkcue";
    public const string PoolIdleStance = "pool_idle_stance";
    public const string PoolLongShot = "pool_long_shot";
    public const string PoolLongShotO = "pool_long_shot_o";
    public const string PoolLongStart = "pool_long_start";
    public const string PoolLongStartO = "pool_long_start_o";
    public const string PoolMedShot = "pool_med_shot";
    public const string PoolMedShotO = "pool_med_shot_o";
    public const string PoolMedStart = "pool_med_start";
    public const string PoolMedStartO = "pool_med_start_o";
    public const string PoolPlaceWhite = "pool_place_white";
    public const string PoolShortShot = "pool_short_shot";
    public const string PoolShortShotO = "pool_short_shot_o";
    public const string PoolShortStart = "pool_short_start";
    public const string PoolShortStartO = "pool_short_start_o";
    public const string PoolWalk = "pool_walk";
    public const string PoolWalkStart = "pool_walk_start";
    public const string PoolXlongShot = "pool_xlong_shot";
    public const string PoolXlongShotO = "pool_xlong_shot_o";
    public const string PoolXlongStart = "pool_xlong_start";
    public const string PoolXlongStartO = "pool_xlong_start_o";
}

public class AnimGroup90
{
    public const string WinwashStart = "winwash_start";
    public const string WinwashWash2beg = "winwash_wash2beg";
}

public class AnimGroup91
{
    public const string PythonCrouchfire = "python_crouchfire";
    public const string PythonCrouchreload = "python_crouchreload";
    public const string PythonFire = "python_fire";
    public const string PythonFirePoor = "python_fire_poor";
    public const string PythonReload = "python_reload";
}

public class AnimGroup92
{
    public const string QuadBack = "quad_back";
    public const string QuadDrivebyFt = "quad_driveby_ft";
    public const string QuadDrivebyLhs = "quad_driveby_lhs";
    public const string QuadDrivebyRhs = "quad_driveby_rhs";
    public const string QuadFwd = "quad_fwd";
    public const string QuadGetoffB = "quad_getoff_b";
    public const string QuadGetoffLhs = "quad_getoff_lhs";
    public const string QuadGetoffRhs = "quad_getoff_rhs";
    public const string QuadGetonLhs = "quad_geton_lhs";
    public const string QuadGetonRhs = "quad_geton_rhs";
    public const string QuadHit = "quad_hit";
    public const string QuadKick = "quad_kick";
    public const string QuadLeft = "quad_left";
    public const string QuadPassenger = "quad_passenger";
    public const string QuadReverse = "quad_reverse";
    public const string QuadRide = "quad_ride";
    public const string QuadRight = "quad_right";
}

public class AnimGroup93
{
    public const string PassDrivebyBwd = "pass_driveby_bwd";
    public const string PassDrivebyFwd = "pass_driveby_fwd";
    public const string PassDrivebyLhs = "pass_driveby_lhs";
    public const string PassDrivebyRhs = "pass_driveby_rhs";
}

public class AnimGroup94
{
    public const string Laugh01 = "laugh_01";
    public const string RapAIn = "rap_a_in";
    public const string RapALoop = "rap_a_loop";
    public const string RapAOut = "rap_a_out";
    public const string RapBIn = "rap_b_in";
    public const string RapBLoop = "rap_b_loop";
    public const string RapBOut = "rap_b_out";
    public const string RapCLoop = "rap_c_loop";
}

public class AnimGroup95
{
    public const string RifleCrouchfire = "rifle_crouchfire";
    public const string RifleCrouchload = "rifle_crouchload";
    public const string RifleFire = "rifle_fire";
    public const string RifleFirePoor = "rifle_fire_poor";
    public const string RifleLoad = "rifle_load";
}

public class AnimGroup96
{
    public const string RiotAngry = "riot_angry";
    public const string RiotAngryB = "riot_angry_b";
    public const string RiotChallenge = "riot_challenge";
    public const string RiotChant = "riot_chant";
    public const string RiotFuku = "riot_fuku";
    public const string RiotPunches = "riot_punches";
    public const string RiotShout = "riot_shout";
}

public class AnimGroup97
{
    public const string CatSafeEnd = "cat_safe_end";
    public const string CatSafeOpen = "cat_safe_open";
    public const string CatSafeOpenO = "cat_safe_open_o";
    public const string CatSafeRob = "cat_safe_rob";
    public const string ShpHandsupScr = "shp_handsup_scr";
}

public class AnimGroup98
{
    public const string IdleRocket = "idle_rocket";
    public const string Rocketfire = "rocketfire";
    public const string RunRocket = "run_rocket";
    public const string WalkRocket = "walk_rocket";
    public const string WalkStartRocket = "walk_start_rocket";
}

public class AnimGroup99
{
    public const string PlaneAlignLhs = "plane_align_lhs";
    public const string PlaneClose = "plane_close";
    public const string PlaneGetin = "plane_getin";
    public const string PlaneGetout = "plane_getout";
    public const string PlaneOpen = "plane_open";
}

public class AnimGroup100
{
    public const string RydBeckon01 = "ryd_beckon_01";
    public const string RydBeckon02 = "ryd_beckon_02";
    public const string RydBeckon03 = "ryd_beckon_03";
    public const string RydDiePt1 = "ryd_die_pt1";
    public const string RydDiePt2 = "ryd_die_pt2";
    public const string VanCrateL = "van_crate_l";
    public const string VanCrateR = "van_crate_r";
    public const string VanFallL = "van_fall_l";
    public const string VanFallR = "van_fall_r";
    public const string VanLeanL = "van_lean_l";
    public const string VanLeanR = "van_lean_r";
    public const string VanPickupE = "van_pickup_e";
    public const string VanPickupS = "van_pickup_s";
    public const string VanStand = "van_stand";
    public const string VanStandCrate = "van_stand_crate";
    public const string VanThrow = "van_throw";
}

public class AnimGroup101
{
    public const string Scdldlp = "scdldlp";
    public const string Scdlulp = "scdlulp";
    public const string Scdrdlp = "scdrdlp";
    public const string Scdrulp = "scdrulp";
    public const string SclngL = "sclng_l";
    public const string SclngR = "sclng_r";
    public const string ScmidL = "scmid_l";
    public const string ScmidR = "scmid_r";
    public const string Scshrtl = "scshrtl";
    public const string Scshrtr = "scshrtr";
    public const string ScLtor = "sc_ltor";
    public const string ScRtol = "sc_rtol";
}

public class AnimGroup102
{
    public const string ShamalAlign = "shamal_align";
    public const string ShamalGetinLhs = "shamal_getin_lhs";
    public const string ShamalGetoutLhs = "shamal_getout_lhs";
    public const string ShamalOpen = "shamal_open";
}

public class AnimGroup103
{
    public const string Rob2Idle = "rob_2idle";
    public const string RobLoop = "rob_loop";
    public const string RobLoopThreat = "rob_loop_threat";
    public const string RobShifty = "rob_shifty";
    public const string RobStickupIn = "rob_stickup_in";
    public const string ShpDuck = "shp_duck";
    public const string ShpDuckAim = "shp_duck_aim";
    public const string ShpDuckFire = "shp_duck_fire";
    public const string ShpGunAim = "shp_gun_aim";
    public const string ShpGunDuck = "shp_gun_duck";
    public const string ShpGunFire = "shp_gun_fire";
    public const string ShpGunGrab = "shp_gun_grab";
    public const string ShpGunThreat = "shp_gun_threat";
    public const string ShpHandsupScr = "shp_handsup_scr";
    public const string ShpJumpGlide = "shp_jump_glide";
    public const string ShpJumpLand = "shp_jump_land";
    public const string ShpJumpLaunch = "shp_jump_launch";
    public const string ShpRobGivecash = "shp_rob_givecash";
    public const string ShpRobHandsup = "shp_rob_handsup";
    public const string ShpRobReact = "shp_rob_react";
    public const string ShpServeEnd = "shp_serve_end";
    public const string ShpServeIdle = "shp_serve_idle";
    public const string ShpServeLoop = "shp_serve_loop";
    public const string ShpServeStart = "shp_serve_start";
    public const string SmokeRyd = "smoke_ryd";
}

public class AnimGroup104
{
    public const string ShotgunCrouchfire = "shotgun_crouchfire";
    public const string ShotgunFire = "shotgun_fire";
    public const string ShotgunFirePoor = "shotgun_fire_poor";
}

public class AnimGroup105
{
    public const string Crouchreload = "crouchreload";
    public const string Silencecrouchfire = "silencecrouchfire";
    public const string SilenceFire = "silence_fire";
    public const string SilenceReload = "silence_reload";
}

public class AnimGroup106
{
    public const string SkateIdle = "skate_idle";
    public const string SkateRun = "skate_run";
    public const string SkateSprint = "skate_sprint";
}

public class AnimGroup107
{
    public const string FSmkleanLoop = "f_smklean_loop";
    public const string MSmkleanLoop = "m_smklean_loop";
    public const string MSmkstndLoop = "m_smkstnd_loop";
    public const string MSmkDrag = "m_smk_drag";
    public const string MSmkIn = "m_smk_in";
    public const string MSmkLoop = "m_smk_loop";
    public const string MSmkOut = "m_smk_out";
    public const string MSmkTap = "m_smk_tap";
}

public class AnimGroup108
{
    public const string WeaponSniper = "weapon_sniper";
}

public class AnimGroup109
{
    public const string SpraycanFire = "spraycan_fire";
    public const string SpraycanFull = "spraycan_full";
}

public class AnimGroup110
{
    public const string PlyCash = "ply_cash";
    public const string PunCash = "pun_cash";
    public const string PunHoller = "pun_holler";
    public const string PunLoop = "pun_loop";
    public const string StripA = "strip_a";
    public const string StripB = "strip_b";
    public const string StripC = "strip_c";
    public const string StripD = "strip_d";
    public const string StripE = "strip_e";
    public const string StripF = "strip_f";
    public const string StripG = "strip_g";
    public const string StrA2b = "str_a2b";
    public const string StrB2a = "str_b2a";
    public const string StrB2c = "str_b2c";
    public const string StrC1 = "str_c1";
    public const string StrC2 = "str_c2";
    public const string StrC2b = "str_c2b";
    public const string StrLoopA = "str_loop_a";
    public const string StrLoopB = "str_loop_b";
    public const string StrLoopC = "str_loop_c";
}

public class AnimGroup111
{
    public const string Batherdown = "batherdown";
    public const string Batherup = "batherup";
    public const string LayBacIn = "lay_bac_in";
    public const string LayBacOut = "lay_bac_out";
    public const string ParksitMIdlea = "parksit_m_idlea";
    public const string ParksitMIdleb = "parksit_m_idleb";
    public const string ParksitMIdlec = "parksit_m_idlec";
    public const string ParksitMIn = "parksit_m_in";
    public const string ParksitMOut = "parksit_m_out";
    public const string ParksitWIdlea = "parksit_w_idlea";
    public const string ParksitWIdleb = "parksit_w_idleb";
    public const string ParksitWIdlec = "parksit_w_idlec";
    public const string ParksitWIn = "parksit_w_in";
    public const string ParksitWOut = "parksit_w_out";
    public const string SbatheFLieb2sit = "sbathe_f_lieb2sit";
    public const string SbatheFOut = "sbathe_f_out";
    public const string SitnwaitInW = "sitnwait_in_w";
    public const string SitnwaitOutW = "sitnwait_out_w";
}

public class AnimGroup112
{
    public const string GnstwallInjurd = "gnstwall_injurd";
    public const string JmpWall1m180 = "jmp_wall1m_180";
    public const string RailFall = "rail_fall";
    public const string RailFallCrawl = "rail_fall_crawl";
    public const string SwtBreach01 = "swt_breach_01";
    public const string SwtBreach02 = "swt_breach_02";
    public const string SwtBreach03 = "swt_breach_03";
    public const string SwtGo = "swt_go";
    public const string SwtLkt = "swt_lkt";
    public const string SwtSty = "swt_sty";
    public const string SwtVent01 = "swt_vent_01";
    public const string SwtVent02 = "swt_vent_02";
    public const string SwtVntShtDie = "swt_vnt_sht_die";
    public const string SwtVntShtIn = "swt_vnt_sht_in";
    public const string SwtVntShtLoop = "swt_vnt_sht_loop";
    public const string SwtWllpkL = "swt_wllpk_l";
    public const string SwtWllpkLBack = "swt_wllpk_l_back";
    public const string SwtWllpkR = "swt_wllpk_r";
    public const string SwtWllpkRBack = "swt_wllpk_r_back";
    public const string SwtWllshootInL = "swt_wllshoot_in_l";
    public const string SwtWllshootInR = "swt_wllshoot_in_r";
    public const string SwtWllshootOutL = "swt_wllshoot_out_l";
    public const string SwtWllshootOutR = "swt_wllshoot_out_r";
}

public class AnimGroup113
{
    public const string HoAssSlapped = "ho_ass_slapped";
    public const string LafinPlayer = "lafin_player";
    public const string LafinSweet = "lafin_sweet";
    public const string PlyrHndshldr01 = "plyr_hndshldr_01";
    public const string SweetAssSlap = "sweet_ass_slap";
    public const string SweetHndshldr01 = "sweet_hndshldr_01";
    public const string SweetInjuredloop = "sweet_injuredloop";
}

public class AnimGroup114
{
    public const string SwimBreast = "swim_breast";
    public const string SwimCrawl = "swim_crawl";
    public const string SwimDiveUnder = "swim_dive_under";
    public const string SwimGlide = "swim_glide";
    public const string SwimJumpout = "swim_jumpout";
    public const string SwimTread = "swim_tread";
    public const string SwimUnder = "swim_under";
}

public class AnimGroup115
{
    public const string Sword1 = "sword_1";
    public const string Sword2 = "sword_2";
    public const string Sword3 = "sword_3";
    public const string Sword4 = "sword_4";
    public const string SwordBlock = "sword_block";
    public const string SwordHit1 = "sword_hit_1";
    public const string SwordHit2 = "sword_hit_2";
    public const string SwordHit3 = "sword_hit_3";
    public const string SwordIdle = "sword_idle";
    public const string SwordPart = "sword_part";
}

public class AnimGroup116
{
    public const string TankAlignLhs = "tank_align_lhs";
    public const string TankCloseLhs = "tank_close_lhs";
    public const string TankDoorlocked = "tank_doorlocked";
    public const string TankGetinLhs = "tank_getin_lhs";
    public const string TankGetoutLhs = "tank_getout_lhs";
    public const string TankOpenLhs = "tank_open_lhs";
}

public class AnimGroup117
{
    public const string TatArmlInO = "tat_arml_in_o";
    public const string TatArmlInP = "tat_arml_in_p";
    public const string TatArmlInT = "tat_arml_in_t";
    public const string TatArmlOutO = "tat_arml_out_o";
    public const string TatArmlOutP = "tat_arml_out_p";
    public const string TatArmlOutT = "tat_arml_out_t";
    public const string TatArmlPoseO = "tat_arml_pose_o";
    public const string TatArmlPoseP = "tat_arml_pose_p";
    public const string TatArmlPoseT = "tat_arml_pose_t";
    public const string TatArmrInO = "tat_armr_in_o";
    public const string TatArmrInP = "tat_armr_in_p";
    public const string TatArmrInT = "tat_armr_in_t";
    public const string TatArmrOutO = "tat_armr_out_o";
    public const string TatArmrOutP = "tat_armr_out_p";
    public const string TatArmrOutT = "tat_armr_out_t";
    public const string TatArmrPoseO = "tat_armr_pose_o";
    public const string TatArmrPoseP = "tat_armr_pose_p";
    public const string TatArmrPoseT = "tat_armr_pose_t";
    public const string TatBackInO = "tat_back_in_o";
    public const string TatBackInP = "tat_back_in_p";
    public const string TatBackInT = "tat_back_in_t";
    public const string TatBackOutO = "tat_back_out_o";
    public const string TatBackOutP = "tat_back_out_p";
    public const string TatBackOutT = "tat_back_out_t";
    public const string TatBackPoseO = "tat_back_pose_o";
    public const string TatBackPoseP = "tat_back_pose_p";
    public const string TatBackPoseT = "tat_back_pose_t";
    public const string TatBackSitInP = "tat_back_sit_in_p";
    public const string TatBackSitLoopP = "tat_back_sit_loop_p";
    public const string TatBackSitOutP = "tat_back_sit_out_p";
    public const string TatBelInO = "tat_bel_in_o";
    public const string TatBelInT = "tat_bel_in_t";
    public const string TatBelOutO = "tat_bel_out_o";
    public const string TatBelOutT = "tat_bel_out_t";
    public const string TatBelPoseO = "tat_bel_pose_o";
    public const string TatBelPoseT = "tat_bel_pose_t";
    public const string TatCheInO = "tat_che_in_o";
    public const string TatCheInP = "tat_che_in_p";
    public const string TatCheInT = "tat_che_in_t";
    public const string TatCheOutO = "tat_che_out_o";
    public const string TatCheOutP = "tat_che_out_p";
    public const string TatCheOutT = "tat_che_out_t";
    public const string TatChePoseO = "tat_che_pose_o";
    public const string TatChePoseP = "tat_che_pose_p";
    public const string TatChePoseT = "tat_che_pose_t";
    public const string TatDropO = "tat_drop_o";
    public const string TatIdleLoopO = "tat_idle_loop_o";
    public const string TatIdleLoopT = "tat_idle_loop_t";
    public const string TatSitInO = "tat_sit_in_o";
    public const string TatSitInP = "tat_sit_in_p";
    public const string TatSitInT = "tat_sit_in_t";
    public const string TatSitLoopO = "tat_sit_loop_o";
    public const string TatSitLoopP = "tat_sit_loop_p";
    public const string TatSitLoopT = "tat_sit_loop_t";
    public const string TatSitOutO = "tat_sit_out_o";
    public const string TatSitOutP = "tat_sit_out_p";
    public const string TatSitOutT = "tat_sit_out_t";
}

public class AnimGroup118
{
    public const string TecCrouchfire = "tec_crouchfire";
    public const string TecCrouchreload = "tec_crouchreload";
    public const string TecFire = "tec_fire";
    public const string TecReload = "tec_reload";
}

public class AnimGroup119
{
    public const string TranGtup = "tran_gtup";
    public const string TranHng = "tran_hng";
    public const string TranOuch = "tran_ouch";
    public const string TranStmb = "tran_stmb";
}

public class AnimGroup120
{
    public const string TruckAlignLhs = "truck_align_lhs";
    public const string TruckAlignRhs = "truck_align_rhs";
    public const string TruckClosedoorLhs = "truck_closedoor_lhs";
    public const string TruckClosedoorRhs = "truck_closedoor_rhs";
    public const string TruckCloseLhs = "truck_close_lhs";
    public const string TruckCloseRhs = "truck_close_rhs";
    public const string TruckGetinLhs = "truck_getin_lhs";
    public const string TruckGetinRhs = "truck_getin_rhs";
    public const string TruckGetoutLhs = "truck_getout_lhs";
    public const string TruckGetoutRhs = "truck_getout_rhs";
    public const string TruckJackedlhs = "truck_jackedlhs";
    public const string TruckJackedrhs = "truck_jackedrhs";
    public const string TruckOpenLhs = "truck_open_lhs";
    public const string TruckOpenRhs = "truck_open_rhs";
    public const string TruckPulloutLhs = "truck_pullout_lhs";
    public const string TruckPulloutRhs = "truck_pullout_rhs";
    public const string TruckShuffle = "truck_shuffle";
}

public class AnimGroup121
{
    public const string UziCrouchfire = "uzi_crouchfire";
    public const string UziCrouchreload = "uzi_crouchreload";
    public const string UziFire = "uzi_fire";
    public const string UziFirePoor = "uzi_fire_poor";
    public const string UziReload = "uzi_reload";
}

public class AnimGroup122
{
    public const string VanCloseBackLhs = "van_close_back_lhs";
    public const string VanCloseBackRhs = "van_close_back_rhs";
    public const string VanGetinBackLhs = "van_getin_back_lhs";
    public const string VanGetinBackRhs = "van_getin_back_rhs";
    public const string VanGetoutBackLhs = "van_getout_back_lhs";
    public const string VanGetoutBackRhs = "van_getout_back_rhs";
    public const string VanOpenBackLhs = "van_open_back_lhs";
    public const string VanOpenBackRhs = "van_open_back_rhs";
}

public class AnimGroup123
{
    public const string VendDrink2P = "vend_drink2_p";
    public const string VendDrinkP = "vend_drink_p";
    public const string VendEat1P = "vend_eat1_p";
    public const string VendEatP = "vend_eat_p";
    public const string VendUse = "vend_use";
    public const string VendUsePt2 = "vend_use_pt2";
}

public class AnimGroup124
{
    public const string CarJumpinLhs = "car_jumpin_lhs";
    public const string CarJumpinRhs = "car_jumpin_rhs";
    public const string VortexGetoutLhs = "vortex_getout_lhs";
    public const string VortexGetoutRhs = "vortex_getout_rhs";
}

public class AnimGroup125
{
    public const string WfBack = "wf_back";
    public const string WfDrivebyft = "wf_drivebyft";
    public const string WfDrivebylhs = "wf_drivebylhs";
    public const string WfDrivebyrhs = "wf_drivebyrhs";
    public const string WfFwd = "wf_fwd";
    public const string WfGetoffback = "wf_getoffback";
    public const string WfGetofflhs = "wf_getofflhs";
    public const string WfGetoffrhs = "wf_getoffrhs";
    public const string WfHit = "wf_hit";
    public const string WfJumponl = "wf_jumponl";
    public const string WfJumponr = "wf_jumponr";
    public const string WfKick = "wf_kick";
    public const string WfLeft = "wf_left";
    public const string WfPassenger = "wf_passenger";
    public const string WfPushes = "wf_pushes";
    public const string WfRide = "wf_ride";
    public const string WfRight = "wf_right";
    public const string WfStill = "wf_still";
}

public class AnimGroup126
{
    public const string Shp1HLift = "shp_1h_lift";
    public const string Shp1HLiftEnd = "shp_1h_lift_end";
    public const string Shp1HRet = "shp_1h_ret";
    public const string Shp1HRetS = "shp_1h_ret_s";
    public const string Shp2HLift = "shp_2h_lift";
    public const string Shp2HLiftEnd = "shp_2h_lift_end";
    public const string Shp2HRet = "shp_2h_ret";
    public const string Shp2HRetS = "shp_2h_ret_s";
    public const string ShpArLift = "shp_ar_lift";
    public const string ShpArLiftEnd = "shp_ar_lift_end";
    public const string ShpArRet = "shp_ar_ret";
    public const string ShpArRetS = "shp_ar_ret_s";
    public const string ShpGLiftIn = "shp_g_lift_in";
    public const string ShpGLiftOut = "shp_g_lift_out";
    public const string ShpTrayIn = "shp_tray_in";
    public const string ShpTrayOut = "shp_tray_out";
    public const string ShpTrayPose = "shp_tray_pose";
}

public class AnimGroup127
{
    public const string CsDeadGuy = "cs_dead_guy";
    public const string CsPlyrPt1 = "cs_plyr_pt1";
    public const string CsPlyrPt2 = "cs_plyr_pt2";
    public const string CsWuziPt1 = "cs_wuzi_pt1";
    public const string CsWuziPt2 = "cs_wuzi_pt2";
    public const string WalkstartIdle01 = "walkstart_idle_01";
    public const string WuziFollow = "wuzi_follow";
    public const string WuziGreetPlyr = "wuzi_greet_plyr";
    public const string WuziGreetWuzi = "wuzi_greet_wuzi";
    public const string WuziGrndChk = "wuzi_grnd_chk";
    public const string WuziStandLoop = "wuzi_stand_loop";
    public const string WuziWalk = "wuzi_walk";
}