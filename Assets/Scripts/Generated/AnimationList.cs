using System.Collections.Generic;
using System.Linq;

namespace SanAndreasUnity.Generated
{
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

    /// <summary>
    /// To use this simply call: PlayAnim(AnimationGroups.Something, AnimGroup<Number_That_Enum_Tooltip_Display>.Something);
    /// </summary>

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

        public static string GetAnimGroupName(AnimationGroups group)
        {
            return animGroups[(int)group];
        }

        public static AnimationGroups GetGroupFromName(string animName)
        {
            return animList.FirstOrDefault(x => x.Value.Any(y => y.anim == animName)).Key;
        }

        public static Dictionary<AnimationGroups, List<AnimFlag>> CurAnims { get { return animList; } }

        private static Dictionary<AnimationGroups, List<AnimFlag>> animList = new Dictionary<AnimationGroups, List<AnimFlag>>()
        {
            {
                AnimationGroups.Airport,
                new List<AnimFlag>()
                {
                    new AnimFlag("thrw_barl_thrw")
                }
            },
            {
                AnimationGroups.Attractors,
                new List<AnimFlag>()
                {
                    new AnimFlag("stepsit_in"),
                    new AnimFlag("stepsit_loop", true),
                    new AnimFlag("stepsit_out")
                }
            },
            {
                AnimationGroups.Bar,
                new List<AnimFlag>()
                {
                    new AnimFlag("barcustom_get"),
                    new AnimFlag("barcustom_loop"),
                    new AnimFlag("barcustom_order"),
                    new AnimFlag("barman_idle"),
                    new AnimFlag("barserve_bottle"),
                    new AnimFlag("barserve_give"),
                    new AnimFlag("barserve_glass"),
                    new AnimFlag("barserve_in"),
                    new AnimFlag("barserve_loop"),
                    new AnimFlag("barserve_order"),
                    new AnimFlag("dnk_stndf_loop"),
                    new AnimFlag("dnk_stndm_loop")
                }
            },
            {
                AnimationGroups.Baseball,
                new List<AnimFlag>()
                {
                    new AnimFlag("bat_1"),
                    new AnimFlag("bat_2"),
                    new AnimFlag("bat_3"),
                    new AnimFlag("bat_4"),
                    new AnimFlag("bat_block"),
                    new AnimFlag("bat_hit_1"),
                    new AnimFlag("bat_hit_2"),
                    new AnimFlag("bat_hit_3"),
                    new AnimFlag("bat_idle"),
                    new AnimFlag("bat_m"),
                    new AnimFlag("bat_part")
                }
            },
            {
                AnimationGroups.Bd_Fire,
                new List<AnimFlag>()
                {
                    new AnimFlag("bd_fire1"),
                    new AnimFlag("bd_fire2"),
                    new AnimFlag("bd_fire3"),
                    new AnimFlag("bd_gf_wave"),
                    new AnimFlag("bd_panic_01"),
                    new AnimFlag("bd_panic_02"),
                    new AnimFlag("bd_panic_03"),
                    new AnimFlag("bd_panic_04"),
                    new AnimFlag("bd_panic_loop"),
                    new AnimFlag("grlfrd_kiss_03"),
                    new AnimFlag("m_smklean_loop"),
                    new AnimFlag("playa_kiss_03"),
                    new AnimFlag("wash_up")
                }
            },
            {
                AnimationGroups.Beach,
                new List<AnimFlag>()
                {
                    new AnimFlag("bather"),
                    new AnimFlag("lay_bac_loop"),
                    new AnimFlag("parksit_m_loop"),
                    new AnimFlag("parksit_w_loop"),
                    new AnimFlag("sitnwait_loop_w")
                }
            },
            {
                AnimationGroups.Benchpress,
                new List<AnimFlag>()
                {
                    new AnimFlag("gym_bp_celebrate"),
                    new AnimFlag("gym_bp_down"),
                    new AnimFlag("gym_bp_getoff"),
                    new AnimFlag("gym_bp_geton"),
                    new AnimFlag("gym_bp_up_a"),
                    new AnimFlag("gym_bp_up_b"),
                    new AnimFlag("gym_bp_up_smooth")
                }
            },
            {
                AnimationGroups.Bf_Injection,
                new List<AnimFlag>()
                {
                    new AnimFlag("bf_getin_lhs"),
                    new AnimFlag("bf_getin_rhs"),
                    new AnimFlag("bf_getout_lhs"),
                    new AnimFlag("bf_getout_rhs")
                }
            },
            {
                AnimationGroups.Biked,
                new List<AnimFlag>()
                {
                    new AnimFlag("biked_back"),
                    new AnimFlag("biked_drivebyft"),
                    new AnimFlag("biked_drivebylhs"),
                    new AnimFlag("biked_drivebyrhs"),
                    new AnimFlag("biked_fwd"),
                    new AnimFlag("biked_getoffback"),
                    new AnimFlag("biked_getofflhs"),
                    new AnimFlag("biked_getoffrhs"),
                    new AnimFlag("biked_hit"),
                    new AnimFlag("biked_jumponl"),
                    new AnimFlag("biked_jumponr"),
                    new AnimFlag("biked_kick"),
                    new AnimFlag("biked_left"),
                    new AnimFlag("biked_passenger"),
                    new AnimFlag("biked_pushes"),
                    new AnimFlag("biked_ride"),
                    new AnimFlag("biked_right"),
                    new AnimFlag("biked_shuffle"),
                    new AnimFlag("biked_still")
                }
            },
            {
                AnimationGroups.Bikeh,
                new List<AnimFlag>()
                {
                    new AnimFlag("bikeh_back"),
                    new AnimFlag("bikeh_drivebyft"),
                    new AnimFlag("bikeh_drivebylhs"),
                    new AnimFlag("bikeh_drivebyrhs"),
                    new AnimFlag("bikeh_fwd"),
                    new AnimFlag("bikeh_getoffback"),
                    new AnimFlag("bikeh_getofflhs"),
                    new AnimFlag("bikeh_getoffrhs"),
                    new AnimFlag("bikeh_hit"),
                    new AnimFlag("bikeh_jumponl"),
                    new AnimFlag("bikeh_jumponr"),
                    new AnimFlag("bikeh_kick"),
                    new AnimFlag("bikeh_left"),
                    new AnimFlag("bikeh_passenger"),
                    new AnimFlag("bikeh_pushes"),
                    new AnimFlag("bikeh_ride"),
                    new AnimFlag("bikeh_right"),
                    new AnimFlag("bikeh_still")
                }
            },
            {
                AnimationGroups.Bikeleap,
                new List<AnimFlag>()
                {
                    new AnimFlag("bk_blnce_in"),
                    new AnimFlag("bk_blnce_out"),
                    new AnimFlag("bk_jmp"),
                    new AnimFlag("bk_rdy_in"),
                    new AnimFlag("bk_rdy_out"),
                    new AnimFlag("struggle_cesar"),
                    new AnimFlag("struggle_driver"),
                    new AnimFlag("truck_driver"),
                    new AnimFlag("truck_getin")
                }
            },
            {
                AnimationGroups.Bikes,
                new List<AnimFlag>()
                {
                    new AnimFlag("bikes_back"),
                    new AnimFlag("bikes_drivebyft"),
                    new AnimFlag("bikes_drivebylhs"),
                    new AnimFlag("bikes_drivebyrhs"),
                    new AnimFlag("bikes_fwd"),
                    new AnimFlag("bikes_getoffback"),
                    new AnimFlag("bikes_getofflhs"),
                    new AnimFlag("bikes_getoffrhs"),
                    new AnimFlag("bikes_hit"),
                    new AnimFlag("bikes_jumponl"),
                    new AnimFlag("bikes_jumponr"),
                    new AnimFlag("bikes_kick"),
                    new AnimFlag("bikes_left"),
                    new AnimFlag("bikes_passenger"),
                    new AnimFlag("bikes_pushes"),
                    new AnimFlag("bikes_ride"),
                    new AnimFlag("bikes_right"),
                    new AnimFlag("bikes_snatch_l"),
                    new AnimFlag("bikes_snatch_r"),
                    new AnimFlag("bikes_still")
                }
            },
            {
                AnimationGroups.Bikev,
                new List<AnimFlag>()
                {
                    new AnimFlag("bikev_back"),
                    new AnimFlag("bikev_drivebyft"),
                    new AnimFlag("bikev_drivebylhs"),
                    new AnimFlag("bikev_drivebyrhs"),
                    new AnimFlag("bikev_fwd"),
                    new AnimFlag("bikev_getoffback"),
                    new AnimFlag("bikev_getofflhs"),
                    new AnimFlag("bikev_getoffrhs"),
                    new AnimFlag("bikev_hit"),
                    new AnimFlag("bikev_jumponl"),
                    new AnimFlag("bikev_jumponr"),
                    new AnimFlag("bikev_kick"),
                    new AnimFlag("bikev_left"),
                    new AnimFlag("bikev_passenger"),
                    new AnimFlag("bikev_pushes"),
                    new AnimFlag("bikev_ride"),
                    new AnimFlag("bikev_right"),
                    new AnimFlag("bikev_still")
                }
            },
            {
                AnimationGroups.Bike_Dbz,
                new List<AnimFlag>()
                {
                    new AnimFlag("pass_driveby_bwd"),
                    new AnimFlag("pass_driveby_fwd"),
                    new AnimFlag("pass_driveby_lhs"),
                    new AnimFlag("pass_driveby_rhs")
                }
            },
            {
                AnimationGroups.Bmx,
                new List<AnimFlag>()
                {
                    new AnimFlag("bmx_back"),
                    new AnimFlag("bmx_bunnyhop"),
                    new AnimFlag("bmx_drivebyft"),
                    new AnimFlag("bmx_driveby_lhs"),
                    new AnimFlag("bmx_driveby_rhs"),
                    new AnimFlag("bmx_fwd"),
                    new AnimFlag("bmx_getoffback"),
                    new AnimFlag("bmx_getofflhs"),
                    new AnimFlag("bmx_getoffrhs"),
                    new AnimFlag("bmx_jumponl"),
                    new AnimFlag("bmx_jumponr"),
                    new AnimFlag("bmx_left"),
                    new AnimFlag("bmx_pedal"),
                    new AnimFlag("bmx_pushes"),
                    new AnimFlag("bmx_ride"),
                    new AnimFlag("bmx_right"),
                    new AnimFlag("bmx_sprint"),
                    new AnimFlag("bmx_still")
                }
            },
            {
                AnimationGroups.Bomber,
                new List<AnimFlag>()
                {
                    new AnimFlag("bom_plant"),
                    new AnimFlag("bom_plant_2idle"),
                    new AnimFlag("bom_plant_crouch_in"),
                    new AnimFlag("bom_plant_crouch_out"),
                    new AnimFlag("bom_plant_in"),
                    new AnimFlag("bom_plant_loop")
                }
            },
            {
                AnimationGroups.Box,
                new List<AnimFlag>()
                {
                    new AnimFlag("boxhipin"),
                    new AnimFlag("boxhipup"),
                    new AnimFlag("boxshdwn"),
                    new AnimFlag("boxshup"),
                    new AnimFlag("bxhipwlk"),
                    new AnimFlag("bxhwlki"),
                    new AnimFlag("bxshwlk"),
                    new AnimFlag("bxshwlki"),
                    new AnimFlag("bxwlko"),
                    new AnimFlag("catch_box")
                }
            },
            {
                AnimationGroups.Bsktball,
                new List<AnimFlag>()
                {
                    new AnimFlag("bball_def_jump_shot"),
                    new AnimFlag("bball_def_loop"),
                    new AnimFlag("bball_def_stepl"),
                    new AnimFlag("bball_def_stepr"),
                    new AnimFlag("bball_dnk"),
                    new AnimFlag("bball_dnk_gli"),
                    new AnimFlag("bball_dnk_gli_o"),
                    new AnimFlag("bball_dnk_lnch"),
                    new AnimFlag("bball_dnk_lnch_o"),
                    new AnimFlag("bball_dnk_lnd"),
                    new AnimFlag("bball_dnk_o"),
                    new AnimFlag("bball_idle"),
                    new AnimFlag("bball_idle2"),
                    new AnimFlag("bball_idle2_o"),
                    new AnimFlag("bball_idleloop"),
                    new AnimFlag("bball_idleloop_o"),
                    new AnimFlag("bball_idle_o"),
                    new AnimFlag("bball_jump_cancel"),
                    new AnimFlag("bball_jump_cancel_o"),
                    new AnimFlag("bball_jump_end"),
                    new AnimFlag("bball_jump_shot"),
                    new AnimFlag("bball_jump_shot_o"),
                    new AnimFlag("bball_net_dnk_o"),
                    new AnimFlag("bball_pickup"),
                    new AnimFlag("bball_pickup_o"),
                    new AnimFlag("bball_react_miss"),
                    new AnimFlag("bball_react_score"),
                    new AnimFlag("bball_run"),
                    new AnimFlag("bball_run_o"),
                    new AnimFlag("bball_skidstop_l"),
                    new AnimFlag("bball_skidstop_l_o"),
                    new AnimFlag("bball_skidstop_r"),
                    new AnimFlag("bball_skidstop_r_o"),
                    new AnimFlag("bball_walk"),
                    new AnimFlag("bball_walkstop_l"),
                    new AnimFlag("bball_walkstop_l_o"),
                    new AnimFlag("bball_walkstop_r"),
                    new AnimFlag("bball_walkstop_r_o"),
                    new AnimFlag("bball_walk_o"),
                    new AnimFlag("bball_walk_start"),
                    new AnimFlag("bball_walk_start_o")
                }
            },
            {
                AnimationGroups.Buddy,
                new List<AnimFlag>()
                {
                    new AnimFlag("buddy_crouchfire"),
                    new AnimFlag("buddy_crouchreload"),
                    new AnimFlag("buddy_fire"),
                    new AnimFlag("buddy_fire_poor"),
                    new AnimFlag("buddy_reload")
                }
            },
            {
                AnimationGroups.Bus,
                new List<AnimFlag>()
                {
                    new AnimFlag("bus_close"),
                    new AnimFlag("bus_getin_lhs"),
                    new AnimFlag("bus_getin_rhs"),
                    new AnimFlag("bus_getout_lhs"),
                    new AnimFlag("bus_getout_rhs"),
                    new AnimFlag("bus_jacked_lhs"),
                    new AnimFlag("bus_open"),
                    new AnimFlag("bus_open_rhs"),
                    new AnimFlag("bus_pullout_lhs")
                }
            },
            {
                AnimationGroups.Camera,
                new List<AnimFlag>()
                {
                    new AnimFlag("camcrch_cmon"),
                    new AnimFlag("camcrch_idleloop"),
                    new AnimFlag("camcrch_stay"),
                    new AnimFlag("camcrch_to_camstnd"),
                    new AnimFlag("camstnd_cmon"),
                    new AnimFlag("camstnd_idleloop"),
                    new AnimFlag("camstnd_lkabt"),
                    new AnimFlag("camstnd_to_camcrch"),
                    new AnimFlag("piccrch_in"),
                    new AnimFlag("piccrch_out"),
                    new AnimFlag("piccrch_take"),
                    new AnimFlag("picstnd_in"),
                    new AnimFlag("picstnd_out"),
                    new AnimFlag("picstnd_take")
                }
            },
            {
                AnimationGroups.Car,
                new List<AnimFlag>()
                {
                    new AnimFlag("fixn_car_loop"),
                    new AnimFlag("fixn_car_out"),
                    new AnimFlag("flag_drop"),
                    new AnimFlag("sit_relaxed"),
                    new AnimFlag("tap_hand"),
                    new AnimFlag("tyd2car_bump"),
                    new AnimFlag("tyd2car_high"),
                    new AnimFlag("tyd2car_low"),
                    new AnimFlag("tyd2car_med"),
                    new AnimFlag("tyd2car_turnl"),
                    new AnimFlag("tyd2car_turnr")
                }
            },
            {
                AnimationGroups.Carry,
                new List<AnimFlag>()
                {
                    new AnimFlag("crry_prtial"),
                    new AnimFlag("liftup"),
                    new AnimFlag("liftup05"),
                    new AnimFlag("liftup105"),
                    new AnimFlag("putdwn"),
                    new AnimFlag("putdwn05"),
                    new AnimFlag("putdwn105")
                }
            },
            {
                AnimationGroups.Car_Chat,
                new List<AnimFlag>()
                {
                    new AnimFlag("carfone_in"),
                    new AnimFlag("carfone_loopa"),
                    new AnimFlag("carfone_loopa_to_b"),
                    new AnimFlag("carfone_loopb"),
                    new AnimFlag("carfone_loopb_to_a"),
                    new AnimFlag("carfone_out"),
                    new AnimFlag("car_sc1_bl"),
                    new AnimFlag("car_sc1_br"),
                    new AnimFlag("car_sc1_fl"),
                    new AnimFlag("car_sc1_fr"),
                    new AnimFlag("car_sc2_fl"),
                    new AnimFlag("car_sc3_br"),
                    new AnimFlag("car_sc3_fl"),
                    new AnimFlag("car_sc3_fr"),
                    new AnimFlag("car_sc4_bl"),
                    new AnimFlag("car_sc4_br"),
                    new AnimFlag("car_sc4_fl"),
                    new AnimFlag("car_sc4_fr"),
                    new AnimFlag("car_talkm_in"),
                    new AnimFlag("car_talkm_loop"),
                    new AnimFlag("car_talkm_out")
                }
            },
            {
                AnimationGroups.Casino,
                new List<AnimFlag>()
                {
                    new AnimFlag("cards_in"),
                    new AnimFlag("cards_loop"),
                    new AnimFlag("cards_lose"),
                    new AnimFlag("cards_out"),
                    new AnimFlag("cards_pick_01"),
                    new AnimFlag("cards_pick_02"),
                    new AnimFlag("cards_raise"),
                    new AnimFlag("cards_win"),
                    new AnimFlag("dealone"),
                    new AnimFlag("manwinb"),
                    new AnimFlag("manwind"),
                    new AnimFlag("roulette_bet"),
                    new AnimFlag("roulette_in"),
                    new AnimFlag("roulette_loop"),
                    new AnimFlag("roulette_lose"),
                    new AnimFlag("roulette_out"),
                    new AnimFlag("roulette_win"),
                    new AnimFlag("slot_bet_01"),
                    new AnimFlag("slot_bet_02"),
                    new AnimFlag("slot_in"),
                    new AnimFlag("slot_lose_out"),
                    new AnimFlag("slot_plyr"),
                    new AnimFlag("slot_wait"),
                    new AnimFlag("slot_win_out"),
                    new AnimFlag("wof")
                }
            },
            {
                AnimationGroups.Chainsaw,
                new List<AnimFlag>()
                {
                    new AnimFlag("csaw_1"),
                    new AnimFlag("csaw_2"),
                    new AnimFlag("csaw_3"),
                    new AnimFlag("csaw_g"),
                    new AnimFlag("csaw_hit_1"),
                    new AnimFlag("csaw_hit_2"),
                    new AnimFlag("csaw_hit_3"),
                    new AnimFlag("csaw_part"),
                    new AnimFlag("idle_csaw"),
                    new AnimFlag("weapon_csaw"),
                    new AnimFlag("weapon_csawlo")
                }
            },
            {
                AnimationGroups.Choppa,
                new List<AnimFlag>()
                {
                    new AnimFlag("choppa_back"),
                    new AnimFlag("choppa_bunnyhop"),
                    new AnimFlag("choppa_drivebyft"),
                    new AnimFlag("choppa_driveby_lhs"),
                    new AnimFlag("choppa_driveby_rhs"),
                    new AnimFlag("choppa_fwd"),
                    new AnimFlag("choppa_getoffback"),
                    new AnimFlag("choppa_getofflhs"),
                    new AnimFlag("choppa_getoffrhs"),
                    new AnimFlag("choppa_jumponl"),
                    new AnimFlag("choppa_jumponr"),
                    new AnimFlag("choppa_left"),
                    new AnimFlag("choppa_pedal"),
                    new AnimFlag("choppa_pushes"),
                    new AnimFlag("choppa_ride"),
                    new AnimFlag("choppa_right"),
                    new AnimFlag("choppa_sprint"),
                    new AnimFlag("choppa_still")
                }
            },
            {
                AnimationGroups.Clothes,
                new List<AnimFlag>()
                {
                    new AnimFlag("clo_buy"),
                    new AnimFlag("clo_in"),
                    new AnimFlag("clo_out"),
                    new AnimFlag("clo_pose_hat"),
                    new AnimFlag("clo_pose_in"),
                    new AnimFlag("clo_pose_in_o"),
                    new AnimFlag("clo_pose_legs"),
                    new AnimFlag("clo_pose_loop"),
                    new AnimFlag("clo_pose_out"),
                    new AnimFlag("clo_pose_out_o"),
                    new AnimFlag("clo_pose_shoes"),
                    new AnimFlag("clo_pose_torso"),
                    new AnimFlag("clo_pose_watch")
                }
            },
            {
                AnimationGroups.Coach,
                new List<AnimFlag>()
                {
                    new AnimFlag("coach_inl"),
                    new AnimFlag("coach_inr"),
                    new AnimFlag("coach_opnl"),
                    new AnimFlag("coach_opnr"),
                    new AnimFlag("coach_outl"),
                    new AnimFlag("coach_outr")
                }
            },
            {
                AnimationGroups.Colt45,
                new List<AnimFlag>()
                {
                    new AnimFlag("2guns_crouchfire"),
                    new AnimFlag("colt45_crouchfire"),
                    new AnimFlag("colt45_crouchreload"),
                    new AnimFlag("colt45_fire"),
                    new AnimFlag("colt45_fire_2hands"),
                    new AnimFlag("colt45_reload"),
                    new AnimFlag("sawnoff_reload")
                }
            },
            {
                AnimationGroups.Cop_Ambient,
                new List<AnimFlag>()
                {
                    new AnimFlag("copbrowse_in"),
                    new AnimFlag("copbrowse_loop"),
                    new AnimFlag("copbrowse_nod"),
                    new AnimFlag("copbrowse_out"),
                    new AnimFlag("copbrowse_shake"),
                    new AnimFlag("coplook_in"),
                    new AnimFlag("coplook_loop"),
                    new AnimFlag("coplook_nod"),
                    new AnimFlag("coplook_out"),
                    new AnimFlag("coplook_shake"),
                    new AnimFlag("coplook_think"),
                    new AnimFlag("coplook_watch")
                }
            },
            {
                AnimationGroups.Cop_Dvbyz,
                new List<AnimFlag>()
                {
                    new AnimFlag("cop_dvby_b"),
                    new AnimFlag("cop_dvby_ft"),
                    new AnimFlag("cop_dvby_l"),
                    new AnimFlag("cop_dvby_r")
                }
            },
            {
                AnimationGroups.Crack,
                new List<AnimFlag>()
                {
                    new AnimFlag("bbalbat_idle_01"),
                    new AnimFlag("bbalbat_idle_02"),
                    new AnimFlag("crckdeth1"),
                    new AnimFlag("crckdeth2"),
                    new AnimFlag("crckdeth3"),
                    new AnimFlag("crckdeth4"),
                    new AnimFlag("crckidle1"),
                    new AnimFlag("crckidle2"),
                    new AnimFlag("crckidle3"),
                    new AnimFlag("crckidle4")
                }
            },
            {
                AnimationGroups.Crib,
                new List<AnimFlag>()
                {
                    new AnimFlag("crib_console_loop"),
                    new AnimFlag("crib_use_switch"),
                    new AnimFlag("ped_console_loop"),
                    new AnimFlag("ped_console_loose"),
                    new AnimFlag("ped_console_win")
                }
            },
            {
                AnimationGroups.Dam_Jump,
                new List<AnimFlag>()
                {
                    new AnimFlag("dam_dive_loop"),
                    new AnimFlag("dam_land"),
                    new AnimFlag("dam_launch"),
                    new AnimFlag("jump_roll"),
                    new AnimFlag("sf_jumpwall")
                }
            },
            {
                AnimationGroups.Dancing,
                new List<AnimFlag>()
                {
                    new AnimFlag("bd_clap"),
                    new AnimFlag("bd_clap1"),
                    new AnimFlag("dance_loop"),
                    new AnimFlag("dan_down_a"),
                    new AnimFlag("dan_left_a"),
                    new AnimFlag("dan_loop_a"),
                    new AnimFlag("dan_right_a"),
                    new AnimFlag("dan_up_a"),
                    new AnimFlag("dnce_m_a"),
                    new AnimFlag("dnce_m_b"),
                    new AnimFlag("dnce_m_c"),
                    new AnimFlag("dnce_m_d"),
                    new AnimFlag("dnce_m_e")
                }
            },
            {
                AnimationGroups.Dealer,
                new List<AnimFlag>()
                {
                    new AnimFlag("dealer_deal"),
                    new AnimFlag("dealer_idle"),
                    new AnimFlag("dealer_idle_01"),
                    new AnimFlag("dealer_idle_02"),
                    new AnimFlag("dealer_idle_03"),
                    new AnimFlag("drugs_buy"),
                    new AnimFlag("shop_pay")
                }
            },
            {
                AnimationGroups.Dildo,
                new List<AnimFlag>()
                {
                    new AnimFlag("dildo_1"),
                    new AnimFlag("dildo_2"),
                    new AnimFlag("dildo_3"),
                    new AnimFlag("dildo_block"),
                    new AnimFlag("dildo_g"),
                    new AnimFlag("dildo_hit_1"),
                    new AnimFlag("dildo_hit_2"),
                    new AnimFlag("dildo_hit_3"),
                    new AnimFlag("dildo_idle")
                }
            },
            {
                AnimationGroups.Dodge,
                new List<AnimFlag>()
                {
                    new AnimFlag("cover_dive_01"),
                    new AnimFlag("cover_dive_02"),
                    new AnimFlag("crushed"),
                    new AnimFlag("crush_jump")
                }
            },
            {
                AnimationGroups.Dozer,
                new List<AnimFlag>()
                {
                    new AnimFlag("dozer_align_lhs"),
                    new AnimFlag("dozer_align_rhs"),
                    new AnimFlag("dozer_getin_lhs"),
                    new AnimFlag("dozer_getin_rhs"),
                    new AnimFlag("dozer_getout_lhs"),
                    new AnimFlag("dozer_getout_rhs"),
                    new AnimFlag("dozer_jacked_lhs"),
                    new AnimFlag("dozer_jacked_rhs"),
                    new AnimFlag("dozer_pullout_lhs"),
                    new AnimFlag("dozer_pullout_rhs")
                }
            },
            {
                AnimationGroups.Drivebys,
                new List<AnimFlag>()
                {
                    new AnimFlag("gang_drivebylhs"),
                    new AnimFlag("gang_drivebylhs_bwd"),
                    new AnimFlag("gang_drivebylhs_fwd"),
                    new AnimFlag("gang_drivebyrhs"),
                    new AnimFlag("gang_drivebyrhs_bwd"),
                    new AnimFlag("gang_drivebyrhs_fwd"),
                    new AnimFlag("gang_drivebytop_lhs"),
                    new AnimFlag("gang_drivebytop_rhs")
                }
            },
            {
                AnimationGroups.Fat,
                new List<AnimFlag>()
                {
                    new AnimFlag("fatidle"),
                    new AnimFlag("fatidle_armed"),
                    new AnimFlag("fatidle_csaw"),
                    new AnimFlag("fatidle_rocket"),
                    new AnimFlag("fatrun"),
                    new AnimFlag("fatrun_armed"),
                    new AnimFlag("fatrun_csaw"),
                    new AnimFlag("fatrun_rocket"),
                    new AnimFlag("fatsprint"),
                    new AnimFlag("fatwalk"),
                    new AnimFlag("fatwalkstart"),
                    new AnimFlag("fatwalkstart_csaw"),
                    new AnimFlag("fatwalkst_armed"),
                    new AnimFlag("fatwalkst_rocket"),
                    new AnimFlag("fatwalk_armed"),
                    new AnimFlag("fatwalk_csaw"),
                    new AnimFlag("fatwalk_rocket"),
                    new AnimFlag("idle_tired")
                }
            },
            {
                AnimationGroups.Fight_B,
                new List<AnimFlag>()
                {
                    new AnimFlag("fightb_1"),
                    new AnimFlag("fightb_2"),
                    new AnimFlag("fightb_3"),
                    new AnimFlag("fightb_block"),
                    new AnimFlag("fightb_g"),
                    new AnimFlag("fightb_idle"),
                    new AnimFlag("fightb_m"),
                    new AnimFlag("hitb_1"),
                    new AnimFlag("hitb_2"),
                    new AnimFlag("hitb_3")
                }
            },
            {
                AnimationGroups.Fight_C,
                new List<AnimFlag>()
                {
                    new AnimFlag("fightc_1"),
                    new AnimFlag("fightc_2"),
                    new AnimFlag("fightc_3"),
                    new AnimFlag("fightc_block"),
                    new AnimFlag("fightc_blocking"),
                    new AnimFlag("fightc_g"),
                    new AnimFlag("fightc_idle"),
                    new AnimFlag("fightc_m"),
                    new AnimFlag("fightc_spar"),
                    new AnimFlag("hitc_1"),
                    new AnimFlag("hitc_2"),
                    new AnimFlag("hitc_3")
                }
            },
            {
                AnimationGroups.Fight_D,
                new List<AnimFlag>()
                {
                    new AnimFlag("fightd_1"),
                    new AnimFlag("fightd_2"),
                    new AnimFlag("fightd_3"),
                    new AnimFlag("fightd_block"),
                    new AnimFlag("fightd_g"),
                    new AnimFlag("fightd_idle"),
                    new AnimFlag("fightd_m"),
                    new AnimFlag("hitd_1"),
                    new AnimFlag("hitd_2"),
                    new AnimFlag("hitd_3")
                }
            },
            {
                AnimationGroups.Fight_E,
                new List<AnimFlag>()
                {
                    new AnimFlag("fightkick"),
                    new AnimFlag("fightkick_b"),
                    new AnimFlag("hit_fightkick"),
                    new AnimFlag("hit_fightkick_b")
                }
            },
            {
                AnimationGroups.Finale,
                new List<AnimFlag>()
                {
                    new AnimFlag("fin_climb_in"),
                    new AnimFlag("fin_cop1_climbout2"),
                    new AnimFlag("fin_cop1_loop"),
                    new AnimFlag("fin_cop1_stomp"),
                    new AnimFlag("fin_hang_l"),
                    new AnimFlag("fin_hang_loop"),
                    new AnimFlag("fin_hang_r"),
                    new AnimFlag("fin_hang_slip"),
                    new AnimFlag("fin_jump_on"),
                    new AnimFlag("fin_land_car"),
                    new AnimFlag("fin_land_die"),
                    new AnimFlag("fin_legsup"),
                    new AnimFlag("fin_legsup_l"),
                    new AnimFlag("fin_legsup_loop"),
                    new AnimFlag("fin_legsup_r"),
                    new AnimFlag("fin_let_go")
                }
            },
            {
                AnimationGroups.Finale2,
                new List<AnimFlag>()
                {
                    new AnimFlag("fin_cop1_climbout"),
                    new AnimFlag("fin_cop1_fall"),
                    new AnimFlag("fin_cop1_loop"),
                    new AnimFlag("fin_cop1_shot"),
                    new AnimFlag("fin_cop1_swing"),
                    new AnimFlag("fin_cop2_climbout"),
                    new AnimFlag("fin_switch_p"),
                    new AnimFlag("fin_switch_s")
                }
            },
            {
                AnimationGroups.Flame,
                new List<AnimFlag>()
                {
                    new AnimFlag("flame_fire")
                }
            },
            {
                AnimationGroups.Flowers,
                new List<AnimFlag>()
                {
                    new AnimFlag("flower_attack"),
                    new AnimFlag("flower_attack_m"),
                    new AnimFlag("flower_hit")
                }
            },
            {
                AnimationGroups.Food,
                new List<AnimFlag>()
                {
                    new AnimFlag("eat_burger"),
                    new AnimFlag("eat_chicken"),
                    new AnimFlag("eat_pizza"),
                    new AnimFlag("eat_vomit_p"),
                    new AnimFlag("eat_vomit_sk"),
                    new AnimFlag("ff_dam_bkw"),
                    new AnimFlag("ff_dam_fwd"),
                    new AnimFlag("ff_dam_left"),
                    new AnimFlag("ff_dam_right"),
                    new AnimFlag("ff_die_bkw"),
                    new AnimFlag("ff_die_fwd"),
                    new AnimFlag("ff_die_left"),
                    new AnimFlag("ff_die_right"),
                    new AnimFlag("ff_sit_eat1"),
                    new AnimFlag("ff_sit_eat2"),
                    new AnimFlag("ff_sit_eat3"),
                    new AnimFlag("ff_sit_in"),
                    new AnimFlag("ff_sit_in_l"),
                    new AnimFlag("ff_sit_in_r"),
                    new AnimFlag("ff_sit_look"),
                    new AnimFlag("ff_sit_loop"),
                    new AnimFlag("ff_sit_out_180"),
                    new AnimFlag("ff_sit_out_l_180"),
                    new AnimFlag("ff_sit_out_r_180"),
                    new AnimFlag("shp_thank"),
                    new AnimFlag("shp_tray_in"),
                    new AnimFlag("shp_tray_lift"),
                    new AnimFlag("shp_tray_lift_in"),
                    new AnimFlag("shp_tray_lift_loop"),
                    new AnimFlag("shp_tray_lift_out"),
                    new AnimFlag("shp_tray_out"),
                    new AnimFlag("shp_tray_pose"),
                    new AnimFlag("shp_tray_return")
                }
            },
            {
                AnimationGroups.Freeweights,
                new List<AnimFlag>()
                {
                    new AnimFlag("gym_barbell"),
                    new AnimFlag("gym_free_a"),
                    new AnimFlag("gym_free_b"),
                    new AnimFlag("gym_free_celebrate"),
                    new AnimFlag("gym_free_down"),
                    new AnimFlag("gym_free_loop"),
                    new AnimFlag("gym_free_pickup"),
                    new AnimFlag("gym_free_putdown"),
                    new AnimFlag("gym_free_up_smooth")
                }
            },
            {
                AnimationGroups.Gangs,
                new List<AnimFlag>()
                {
                    new AnimFlag("dealer_deal"),
                    new AnimFlag("dealer_idle"),
                    new AnimFlag("drnkbr_prtl"),
                    new AnimFlag("drnkbr_prtl_f"),
                    new AnimFlag("drugs_buy"),
                    new AnimFlag("hndshkaa"),
                    new AnimFlag("hndshkba"),
                    new AnimFlag("hndshkca"),
                    new AnimFlag("hndshkcb"),
                    new AnimFlag("hndshkda"),
                    new AnimFlag("hndshkea"),
                    new AnimFlag("hndshkfa"),
                    new AnimFlag("hndshkfa_swt"),
                    new AnimFlag("invite_no"),
                    new AnimFlag("invite_yes"),
                    new AnimFlag("leanidle"),
                    new AnimFlag("leanin"),
                    new AnimFlag("leanout"),
                    new AnimFlag("prtial_gngtlka"),
                    new AnimFlag("prtial_gngtlkb"),
                    new AnimFlag("prtial_gngtlkc"),
                    new AnimFlag("prtial_gngtlkd"),
                    new AnimFlag("prtial_gngtlke"),
                    new AnimFlag("prtial_gngtlkf"),
                    new AnimFlag("prtial_gngtlkg"),
                    new AnimFlag("prtial_gngtlkh"),
                    new AnimFlag("prtial_hndshk_01"),
                    new AnimFlag("prtial_hndshk_biz_01"),
                    new AnimFlag("shake_cara"),
                    new AnimFlag("shake_cark"),
                    new AnimFlag("shake_carsh"),
                    new AnimFlag("smkcig_prtl"),
                    new AnimFlag("smkcig_prtl_f")
                }
            },
            {
                AnimationGroups.Ghands,
                new List<AnimFlag>()
                {
                    new AnimFlag("gsign1"),
                    new AnimFlag("gsign1lh"),
                    new AnimFlag("gsign2"),
                    new AnimFlag("gsign2lh"),
                    new AnimFlag("gsign3"),
                    new AnimFlag("gsign3lh"),
                    new AnimFlag("gsign4"),
                    new AnimFlag("gsign4lh"),
                    new AnimFlag("gsign5"),
                    new AnimFlag("gsign5lh"),
                    new AnimFlag("lhgsign1"),
                    new AnimFlag("lhgsign2"),
                    new AnimFlag("lhgsign3"),
                    new AnimFlag("lhgsign4"),
                    new AnimFlag("lhgsign5"),
                    new AnimFlag("rhgsign1"),
                    new AnimFlag("rhgsign2"),
                    new AnimFlag("rhgsign3"),
                    new AnimFlag("rhgsign4"),
                    new AnimFlag("rhgsign5")
                }
            },
            {
                AnimationGroups.Ghetto_Db,
                new List<AnimFlag>()
                {
                    new AnimFlag("gdb_car2_ply"),
                    new AnimFlag("gdb_car2_smo"),
                    new AnimFlag("gdb_car2_swe"),
                    new AnimFlag("gdb_car_ply"),
                    new AnimFlag("gdb_car_ryd"),
                    new AnimFlag("gdb_car_smo"),
                    new AnimFlag("gdb_car_swe")
                }
            },
            {
                AnimationGroups.Goggles,
                new List<AnimFlag>()
                {
                    new AnimFlag("goggles_put_on")
                }
            },
            {
                AnimationGroups.Graffiti,
                new List<AnimFlag>()
                {
                    new AnimFlag("graffiti_chkout"),
                    new AnimFlag("spraycan_fire")
                }
            },
            {
                AnimationGroups.Graveyard,
                new List<AnimFlag>()
                {
                    new AnimFlag("mrnf_loop"),
                    new AnimFlag("mrnm_loop"),
                    new AnimFlag("prst_loopa")
                }
            },
            {
                AnimationGroups.Grenade,
                new List<AnimFlag>()
                {
                    new AnimFlag("weapon_start_throw"),
                    new AnimFlag("weapon_throw"),
                    new AnimFlag("weapon_throwu")
                }
            },
            {
                AnimationGroups.Gymnasium,
                new List<AnimFlag>()
                {
                    new AnimFlag("gymshadowbox"),
                    new AnimFlag("gym_bike_celebrate"),
                    new AnimFlag("gym_bike_fast"),
                    new AnimFlag("gym_bike_faster"),
                    new AnimFlag("gym_bike_getoff"),
                    new AnimFlag("gym_bike_geton"),
                    new AnimFlag("gym_bike_pedal"),
                    new AnimFlag("gym_bike_slow"),
                    new AnimFlag("gym_bike_still"),
                    new AnimFlag("gym_jog_falloff"),
                    new AnimFlag("gym_shadowbox"),
                    new AnimFlag("gym_tread_celebrate"),
                    new AnimFlag("gym_tread_falloff"),
                    new AnimFlag("gym_tread_getoff"),
                    new AnimFlag("gym_tread_geton"),
                    new AnimFlag("gym_tread_jog"),
                    new AnimFlag("gym_tread_sprint"),
                    new AnimFlag("gym_tread_tired"),
                    new AnimFlag("gym_tread_walk"),
                    new AnimFlag("gym_walk_falloff"),
                    new AnimFlag("pedals_fast"),
                    new AnimFlag("pedals_med"),
                    new AnimFlag("pedals_slow"),
                    new AnimFlag("pedals_still")
                }
            },
            {
                AnimationGroups.Haircuts,
                new List<AnimFlag>()
                {
                    new AnimFlag("brb_beard_01"),
                    new AnimFlag("brb_buy"),
                    new AnimFlag("brb_cut"),
                    new AnimFlag("brb_cut_in"),
                    new AnimFlag("brb_cut_out"),
                    new AnimFlag("brb_hair_01"),
                    new AnimFlag("brb_hair_02"),
                    new AnimFlag("brb_in"),
                    new AnimFlag("brb_loop"),
                    new AnimFlag("brb_out"),
                    new AnimFlag("brb_sit_in"),
                    new AnimFlag("brb_sit_loop"),
                    new AnimFlag("brb_sit_out")
                }
            },
            {
                AnimationGroups.Heist9,
                new List<AnimFlag>()
                {
                    new AnimFlag("cas_g2_gasko"),
                    new AnimFlag("swt_wllpk_l"),
                    new AnimFlag("swt_wllpk_l_back"),
                    new AnimFlag("swt_wllpk_r"),
                    new AnimFlag("swt_wllpk_r_back"),
                    new AnimFlag("swt_wllshoot_in_l"),
                    new AnimFlag("swt_wllshoot_in_r"),
                    new AnimFlag("swt_wllshoot_out_l"),
                    new AnimFlag("swt_wllshoot_out_r"),
                    new AnimFlag("use_swipecard")
                }
            },
            {
                AnimationGroups.Int_House,
                new List<AnimFlag>()
                {
                    new AnimFlag("bed_in_l"),
                    new AnimFlag("bed_in_r"),
                    new AnimFlag("bed_loop_l"),
                    new AnimFlag("bed_loop_r"),
                    new AnimFlag("bed_out_l"),
                    new AnimFlag("bed_out_r"),
                    new AnimFlag("lou_in"),
                    new AnimFlag("lou_loop"),
                    new AnimFlag("lou_out"),
                    new AnimFlag("wash_up")
                }
            },
            {
                AnimationGroups.Int_Office,
                new List<AnimFlag>()
                {
                    new AnimFlag("ff_dam_fwd"),
                    new AnimFlag("off_sit_2idle_180"),
                    new AnimFlag("off_sit_bored_loop"),
                    new AnimFlag("off_sit_crash"),
                    new AnimFlag("off_sit_drink"),
                    new AnimFlag("off_sit_idle_loop"),
                    new AnimFlag("off_sit_in"),
                    new AnimFlag("off_sit_read"),
                    new AnimFlag("off_sit_type_loop"),
                    new AnimFlag("off_sit_watch")
                }
            },
            {
                AnimationGroups.Int_Shop,
                new List<AnimFlag>()
                {
                    new AnimFlag("shop_cashier"),
                    new AnimFlag("shop_in"),
                    new AnimFlag("shop_looka"),
                    new AnimFlag("shop_lookb"),
                    new AnimFlag("shop_loop"),
                    new AnimFlag("shop_out"),
                    new AnimFlag("shop_pay"),
                    new AnimFlag("shop_shelf")
                }
            },
            {
                AnimationGroups.Jst_Buisness,
                new List<AnimFlag>()
                {
                    new AnimFlag("girl_01"),
                    new AnimFlag("girl_02"),
                    new AnimFlag("player_01"),
                    new AnimFlag("smoke_01")
                }
            },
            {
                AnimationGroups.Kart,
                new List<AnimFlag>()
                {
                    new AnimFlag("kart_getin_lhs"),
                    new AnimFlag("kart_getin_rhs"),
                    new AnimFlag("kart_getout_lhs"),
                    new AnimFlag("kart_getout_rhs")
                }
            },
            {
                AnimationGroups.Kissing,
                new List<AnimFlag>()
                {
                    new AnimFlag("bd_gf_wave"),
                    new AnimFlag("gfwave2"),
                    new AnimFlag("gf_carargue_01"),
                    new AnimFlag("gf_carargue_02"),
                    new AnimFlag("gf_carspot"),
                    new AnimFlag("gf_streetargue_01"),
                    new AnimFlag("gf_streetargue_02"),
                    new AnimFlag("gift_get"),
                    new AnimFlag("gift_give"),
                    new AnimFlag("grlfrd_kiss_01"),
                    new AnimFlag("grlfrd_kiss_02"),
                    new AnimFlag("grlfrd_kiss_03"),
                    new AnimFlag("playa_kiss_01"),
                    new AnimFlag("playa_kiss_02"),
                    new AnimFlag("playa_kiss_03")
                }
            },
            {
                AnimationGroups.Knife,
                new List<AnimFlag>()
                {
                    new AnimFlag("kill_knife_ped_damage"),
                    new AnimFlag("kill_knife_ped_die"),
                    new AnimFlag("kill_knife_player"),
                    new AnimFlag("kill_partial"),
                    new AnimFlag("knife_1"),
                    new AnimFlag("knife_2"),
                    new AnimFlag("knife_3"),
                    new AnimFlag("knife_4"),
                    new AnimFlag("knife_block"),
                    new AnimFlag("knife_g"),
                    new AnimFlag("knife_hit_1"),
                    new AnimFlag("knife_hit_2"),
                    new AnimFlag("knife_hit_3"),
                    new AnimFlag("knife_idle"),
                    new AnimFlag("knife_part"),
                    new AnimFlag("weapon_knifeidle")
                }
            },
            {
                AnimationGroups.Lapdan1,
                new List<AnimFlag>()
                {
                    new AnimFlag("lapdan_d"),
                    new AnimFlag("lapdan_p")
                }
            },
            {
                AnimationGroups.Lapdan2,
                new List<AnimFlag>()
                {
                    new AnimFlag("lapdan_d"),
                    new AnimFlag("lapdan_p")
                }
            },
            {
                AnimationGroups.Lapdan3,
                new List<AnimFlag>()
                {
                    new AnimFlag("lapdan_d"),
                    new AnimFlag("lapdan_p")
                }
            },
            {
                AnimationGroups.Lowrider,
                new List<AnimFlag>()
                {
                    new AnimFlag("f_smklean_loop"),
                    new AnimFlag("lrgirl_bdbnce"),
                    new AnimFlag("lrgirl_hair"),
                    new AnimFlag("lrgirl_hurry"),
                    new AnimFlag("lrgirl_idleloop"),
                    new AnimFlag("lrgirl_idle_to_l0"),
                    new AnimFlag("lrgirl_l0_bnce"),
                    new AnimFlag("lrgirl_l0_loop"),
                    new AnimFlag("lrgirl_l0_to_l1"),
                    new AnimFlag("lrgirl_l12_to_l0"),
                    new AnimFlag("lrgirl_l1_bnce"),
                    new AnimFlag("lrgirl_l1_loop"),
                    new AnimFlag("lrgirl_l1_to_l2"),
                    new AnimFlag("lrgirl_l2_bnce"),
                    new AnimFlag("lrgirl_l2_loop"),
                    new AnimFlag("lrgirl_l2_to_l3"),
                    new AnimFlag("lrgirl_l345_to_l1"),
                    new AnimFlag("lrgirl_l3_bnce"),
                    new AnimFlag("lrgirl_l3_loop"),
                    new AnimFlag("lrgirl_l3_to_l4"),
                    new AnimFlag("lrgirl_l4_bnce"),
                    new AnimFlag("lrgirl_l4_loop"),
                    new AnimFlag("lrgirl_l4_to_l5"),
                    new AnimFlag("lrgirl_l5_bnce"),
                    new AnimFlag("lrgirl_l5_loop"),
                    new AnimFlag("m_smklean_loop"),
                    new AnimFlag("m_smkstnd_loop"),
                    new AnimFlag("prtial_gngtlkb"),
                    new AnimFlag("prtial_gngtlkc"),
                    new AnimFlag("prtial_gngtlkd"),
                    new AnimFlag("prtial_gngtlke"),
                    new AnimFlag("prtial_gngtlkf"),
                    new AnimFlag("prtial_gngtlkg"),
                    new AnimFlag("prtial_gngtlkh"),
                    new AnimFlag("rap_a_loop"),
                    new AnimFlag("rap_b_loop"),
                    new AnimFlag("rap_c_loop"),
                    new AnimFlag("sit_relaxed"),
                    new AnimFlag("tap_hand")
                }
            },
            {
                AnimationGroups.Md_Chase,
                new List<AnimFlag>()
                {
                    new AnimFlag("carhit_hangon"),
                    new AnimFlag("carhit_tumble"),
                    new AnimFlag("donutdrop"),
                    new AnimFlag("fen_choppa_l1"),
                    new AnimFlag("fen_choppa_l2"),
                    new AnimFlag("fen_choppa_l3"),
                    new AnimFlag("fen_choppa_r1"),
                    new AnimFlag("fen_choppa_r2"),
                    new AnimFlag("fen_choppa_r3"),
                    new AnimFlag("hangon_stun_loop"),
                    new AnimFlag("hangon_stun_turn"),
                    new AnimFlag("md_bike_2_hang"),
                    new AnimFlag("md_bike_jmp_bl"),
                    new AnimFlag("md_bike_jmp_f"),
                    new AnimFlag("md_bike_lnd_bl"),
                    new AnimFlag("md_bike_lnd_die_bl"),
                    new AnimFlag("md_bike_lnd_die_f"),
                    new AnimFlag("md_bike_lnd_f"),
                    new AnimFlag("md_bike_lnd_roll"),
                    new AnimFlag("md_bike_lnd_roll_f"),
                    new AnimFlag("md_bike_punch"),
                    new AnimFlag("md_bike_punch_f"),
                    new AnimFlag("md_bike_shot_f"),
                    new AnimFlag("md_hang_lnd_roll"),
                    new AnimFlag("md_hang_loop")
                }
            },
            {
                AnimationGroups.Md_End,
                new List<AnimFlag>()
                {
                    new AnimFlag("end_sc1_ply"),
                    new AnimFlag("end_sc1_ryd"),
                    new AnimFlag("end_sc1_smo"),
                    new AnimFlag("end_sc1_swe"),
                    new AnimFlag("end_sc2_ply"),
                    new AnimFlag("end_sc2_ryd"),
                    new AnimFlag("end_sc2_smo"),
                    new AnimFlag("end_sc2_swe")
                }
            },
            {
                AnimationGroups.Medic,
                new List<AnimFlag>()
                {
                    new AnimFlag("cpr")
                }
            },
            {
                AnimationGroups.Misc,
                new List<AnimFlag>()
                {
                    new AnimFlag("bitchslap"),
                    new AnimFlag("bmx_celebrate"),
                    new AnimFlag("bmx_comeon"),
                    new AnimFlag("bmx_idleloop_01"),
                    new AnimFlag("bmx_idleloop_02"),
                    new AnimFlag("bmx_talkleft_in"),
                    new AnimFlag("bmx_talkleft_loop"),
                    new AnimFlag("bmx_talkleft_out"),
                    new AnimFlag("bmx_talkright_in"),
                    new AnimFlag("bmx_talkright_loop"),
                    new AnimFlag("bmx_talkright_out"),
                    new AnimFlag("bng_wndw"),
                    new AnimFlag("bng_wndw_02"),
                    new AnimFlag("case_pickup"),
                    new AnimFlag("door_jet"),
                    new AnimFlag("grab_l"),
                    new AnimFlag("grab_r"),
                    new AnimFlag("hiker_pose"),
                    new AnimFlag("hiker_pose_l"),
                    new AnimFlag("idle_chat_02"),
                    new AnimFlag("kat_throw_k"),
                    new AnimFlag("kat_throw_o"),
                    new AnimFlag("kat_throw_p"),
                    new AnimFlag("pass_rifle_o"),
                    new AnimFlag("pass_rifle_ped"),
                    new AnimFlag("pass_rifle_ply"),
                    new AnimFlag("pickup_box"),
                    new AnimFlag("plane_door"),
                    new AnimFlag("plane_exit"),
                    new AnimFlag("plane_hijack"),
                    new AnimFlag("plunger_01"),
                    new AnimFlag("plyrlean_loop"),
                    new AnimFlag("plyr_shkhead"),
                    new AnimFlag("run_dive"),
                    new AnimFlag("scratchballs_01"),
                    new AnimFlag("seat_lr"),
                    new AnimFlag("seat_talk_01"),
                    new AnimFlag("seat_talk_02"),
                    new AnimFlag("seat_watch"),
                    new AnimFlag("smalplane_door"),
                    new AnimFlag("smlplane_door")
                }
            },
            {
                AnimationGroups.Mtb,
                new List<AnimFlag>()
                {
                    new AnimFlag("mtb_back"),
                    new AnimFlag("mtb_bunnyhop"),
                    new AnimFlag("mtb_drivebyft"),
                    new AnimFlag("mtb_driveby_lhs"),
                    new AnimFlag("mtb_driveby_rhs"),
                    new AnimFlag("mtb_fwd"),
                    new AnimFlag("mtb_getoffback"),
                    new AnimFlag("mtb_getofflhs"),
                    new AnimFlag("mtb_getoffrhs"),
                    new AnimFlag("mtb_jumponl"),
                    new AnimFlag("mtb_jumponr"),
                    new AnimFlag("mtb_left"),
                    new AnimFlag("mtb_pedal"),
                    new AnimFlag("mtb_pushes"),
                    new AnimFlag("mtb_ride"),
                    new AnimFlag("mtb_right"),
                    new AnimFlag("mtb_sprint"),
                    new AnimFlag("mtb_still")
                }
            },
            {
                AnimationGroups.Muscular,
                new List<AnimFlag>()
                {
                    new AnimFlag("msclewalkst_armed"),
                    new AnimFlag("msclewalkst_csaw"),
                    new AnimFlag("mscle_rckt_run"),
                    new AnimFlag("mscle_rckt_walkst"),
                    new AnimFlag("mscle_run_csaw"),
                    new AnimFlag("muscleidle"),
                    new AnimFlag("muscleidle_armed"),
                    new AnimFlag("muscleidle_csaw"),
                    new AnimFlag("muscleidle_rocket"),
                    new AnimFlag("musclerun"),
                    new AnimFlag("musclerun_armed"),
                    new AnimFlag("musclesprint"),
                    new AnimFlag("musclewalk"),
                    new AnimFlag("musclewalkstart"),
                    new AnimFlag("musclewalk_armed"),
                    new AnimFlag("musclewalk_csaw"),
                    new AnimFlag("musclewalk_rocket")
                }
            },
            {
                AnimationGroups.Nevada,
                new List<AnimFlag>()
                {
                    new AnimFlag("nevada_getin"),
                    new AnimFlag("nevada_getout")
                }
            },
            {
                AnimationGroups.On_Lookers,
                new List<AnimFlag>()
                {
                    new AnimFlag("lkaround_in"),
                    new AnimFlag("lkaround_loop"),
                    new AnimFlag("lkaround_out"),
                    new AnimFlag("lkup_in"),
                    new AnimFlag("lkup_loop"),
                    new AnimFlag("lkup_out"),
                    new AnimFlag("lkup_point"),
                    new AnimFlag("panic_cower"),
                    new AnimFlag("panic_hide"),
                    new AnimFlag("panic_in"),
                    new AnimFlag("panic_loop"),
                    new AnimFlag("panic_out"),
                    new AnimFlag("panic_point"),
                    new AnimFlag("panic_shout"),
                    new AnimFlag("pointup_in"),
                    new AnimFlag("pointup_loop"),
                    new AnimFlag("pointup_out"),
                    new AnimFlag("pointup_shout"),
                    new AnimFlag("point_in"),
                    new AnimFlag("point_loop"),
                    new AnimFlag("point_out"),
                    new AnimFlag("shout_01"),
                    new AnimFlag("shout_02"),
                    new AnimFlag("shout_in"),
                    new AnimFlag("shout_loop"),
                    new AnimFlag("shout_out"),
                    new AnimFlag("wave_in"),
                    new AnimFlag("wave_loop"),
                    new AnimFlag("wave_out")
                }
            },
            {
                AnimationGroups.Otb,
                new List<AnimFlag>()
                {
                    new AnimFlag("betslp_in"),
                    new AnimFlag("betslp_lkabt"),
                    new AnimFlag("betslp_loop"),
                    new AnimFlag("betslp_out"),
                    new AnimFlag("betslp_tnk"),
                    new AnimFlag("wtchrace_cmon"),
                    new AnimFlag("wtchrace_in"),
                    new AnimFlag("wtchrace_loop"),
                    new AnimFlag("wtchrace_lose"),
                    new AnimFlag("wtchrace_out"),
                    new AnimFlag("wtchrace_win")
                }
            },
            {
                AnimationGroups.Parachute,
                new List<AnimFlag>()
                {
                    new AnimFlag("fall_skydive"),
                    new AnimFlag("fall_skydive_accel"),
                    new AnimFlag("fall_skydive_die"),
                    new AnimFlag("fall_skydive_l"),
                    new AnimFlag("fall_skydive_r"),
                    new AnimFlag("para_decel"),
                    new AnimFlag("para_decel_o"),
                    new AnimFlag("para_float"),
                    new AnimFlag("para_float_o"),
                    new AnimFlag("para_land"),
                    new AnimFlag("para_land_o"),
                    new AnimFlag("para_land_water"),
                    new AnimFlag("para_land_water_o"),
                    new AnimFlag("para_open"),
                    new AnimFlag("para_open_o"),
                    new AnimFlag("para_rip_land_o"),
                    new AnimFlag("para_rip_loop_o"),
                    new AnimFlag("para_rip_o"),
                    new AnimFlag("para_steerl"),
                    new AnimFlag("para_steerl_o"),
                    new AnimFlag("para_steerr"),
                    new AnimFlag("para_steerr_o")
                }
            },
            {
                AnimationGroups.Park,
                new List<AnimFlag>()
                {
                    new AnimFlag("tai_chi_in"),
                    new AnimFlag("tai_chi_loop"),
                    new AnimFlag("tai_chi_out")
                }
            },
            {
                AnimationGroups.Paulnmac,
                new List<AnimFlag>()
                {
                    new AnimFlag("piss_in"),
                    new AnimFlag("piss_loop"),
                    new AnimFlag("piss_out"),
                    new AnimFlag("pnm_argue1_a"),
                    new AnimFlag("pnm_argue1_b"),
                    new AnimFlag("pnm_argue2_a"),
                    new AnimFlag("pnm_argue2_b"),
                    new AnimFlag("pnm_loop_a"),
                    new AnimFlag("pnm_loop_b"),
                    new AnimFlag("wank_in"),
                    new AnimFlag("wank_loop"),
                    new AnimFlag("wank_out")
                }
            },
            {
                AnimationGroups.Ped,
                new List<AnimFlag>()
                {
                    new AnimFlag("abseil"),
                    new AnimFlag("arrestgun"),
                    new AnimFlag("atm"),
                    new AnimFlag("bike_elbowl"),
                    new AnimFlag("bike_elbowr"),
                    new AnimFlag("bike_fallr"),
                    new AnimFlag("bike_fall_off"),
                    new AnimFlag("bike_pickupl"),
                    new AnimFlag("bike_pickupr"),
                    new AnimFlag("bike_pullupl"),
                    new AnimFlag("bike_pullupr"),
                    new AnimFlag("bomber"),
                    new AnimFlag("car_alignhi_lhs"),
                    new AnimFlag("car_alignhi_rhs"),
                    new AnimFlag("car_align_lhs"),
                    new AnimFlag("car_align_rhs"),
                    new AnimFlag("car_closedoorl_lhs"),
                    new AnimFlag("car_closedoorl_rhs"),
                    new AnimFlag("car_closedoor_lhs"),
                    new AnimFlag("car_closedoor_rhs"),
                    new AnimFlag("car_close_lhs"),
                    new AnimFlag("car_close_rhs"),
                    new AnimFlag("car_crawloutrhs"),
                    new AnimFlag("car_dead_lhs"),
                    new AnimFlag("car_dead_rhs"),
                    new AnimFlag("car_doorlocked_lhs"),
                    new AnimFlag("car_doorlocked_rhs"),
                    new AnimFlag("car_fallout_lhs"),
                    new AnimFlag("car_fallout_rhs"),
                    new AnimFlag("car_getinl_lhs"),
                    new AnimFlag("car_getinl_rhs"),
                    new AnimFlag("car_getin_lhs"),
                    new AnimFlag("car_getin_rhs"),
                    new AnimFlag("car_getoutl_lhs"),
                    new AnimFlag("car_getoutl_rhs"),
                    new AnimFlag("car_getout_lhs"),
                    new AnimFlag("car_getout_rhs"),
                    new AnimFlag("car_hookertalk"),
                    new AnimFlag("car_jackedlhs"),
                    new AnimFlag("car_jackedrhs"),
                    new AnimFlag("car_jumpin_lhs"),
                    new AnimFlag("car_lb"),
                    new AnimFlag("car_lb_pro"),
                    new AnimFlag("car_lb_weak"),
                    new AnimFlag("car_ljackedlhs"),
                    new AnimFlag("car_ljackedrhs"),
                    new AnimFlag("car_lshuffle_rhs"),
                    new AnimFlag("car_lsit"),
                    new AnimFlag("car_open_lhs"),
                    new AnimFlag("car_open_rhs"),
                    new AnimFlag("car_pulloutl_lhs"),
                    new AnimFlag("car_pulloutl_rhs"),
                    new AnimFlag("car_pullout_lhs"),
                    new AnimFlag("car_pullout_rhs"),
                    new AnimFlag("car_qjacked"),
                    new AnimFlag("car_rolldoor"),
                    new AnimFlag("car_rolldoorlo"),
                    new AnimFlag("car_rollout_lhs"),
                    new AnimFlag("car_rollout_rhs"),
                    new AnimFlag("car_shuffle_rhs"),
                    new AnimFlag("car_sit"),
                    new AnimFlag("car_sitp"),
                    new AnimFlag("car_sitplo"),
                    new AnimFlag("car_sit_pro"),
                    new AnimFlag("car_sit_weak"),
                    new AnimFlag("car_tune_radio"),
                    new AnimFlag("climb_idle"),
                    new AnimFlag("climb_jump"),
                    new AnimFlag("climb_jump2fall"),
                    new AnimFlag("climb_jump_b"),
                    new AnimFlag("climb_pull"),
                    new AnimFlag("climb_stand"),
                    new AnimFlag("climb_stand_finish"),
                    new AnimFlag("cower"),
                    new AnimFlag("crouch_roll_l"),
                    new AnimFlag("crouch_roll_r"),
                    new AnimFlag("dam_arml_frmbk"),
                    new AnimFlag("dam_arml_frmft"),
                    new AnimFlag("dam_arml_frmlt"),
                    new AnimFlag("dam_armr_frmbk"),
                    new AnimFlag("dam_armr_frmft"),
                    new AnimFlag("dam_armr_frmrt"),
                    new AnimFlag("dam_legl_frmbk"),
                    new AnimFlag("dam_legl_frmft"),
                    new AnimFlag("dam_legl_frmlt"),
                    new AnimFlag("dam_legr_frmbk"),
                    new AnimFlag("dam_legr_frmft"),
                    new AnimFlag("dam_legr_frmrt"),
                    new AnimFlag("dam_stomach_frmbk"),
                    new AnimFlag("dam_stomach_frmft"),
                    new AnimFlag("dam_stomach_frmlt"),
                    new AnimFlag("dam_stomach_frmrt"),
                    new AnimFlag("door_lhinge_o"),
                    new AnimFlag("door_rhinge_o"),
                    new AnimFlag("drivebyl_l"),
                    new AnimFlag("drivebyl_r"),
                    new AnimFlag("driveby_l"),
                    new AnimFlag("driveby_r"),
                    new AnimFlag("drive_boat"),
                    new AnimFlag("drive_boat_back"),
                    new AnimFlag("drive_boat_l"),
                    new AnimFlag("drive_boat_r"),
                    new AnimFlag("drive_l"),
                    new AnimFlag("drive_lo_l"),
                    new AnimFlag("drive_lo_r"),
                    new AnimFlag("drive_l_pro"),
                    new AnimFlag("drive_l_pro_slow"),
                    new AnimFlag("drive_l_slow"),
                    new AnimFlag("drive_l_weak"),
                    new AnimFlag("drive_l_weak_slow"),
                    new AnimFlag("drive_r"),
                    new AnimFlag("drive_r_pro"),
                    new AnimFlag("drive_r_pro_slow"),
                    new AnimFlag("drive_r_slow"),
                    new AnimFlag("drive_r_weak"),
                    new AnimFlag("drive_r_weak_slow"),
                    new AnimFlag("drive_truck"),
                    new AnimFlag("drive_truck_back"),
                    new AnimFlag("drive_truck_l"),
                    new AnimFlag("drive_truck_r"),
                    new AnimFlag("drown"),
                    new AnimFlag("duck_cower"),
                    new AnimFlag("endchat_01"),
                    new AnimFlag("endchat_02"),
                    new AnimFlag("endchat_03"),
                    new AnimFlag("ev_dive"),
                    new AnimFlag("ev_step"),
                    new AnimFlag("facanger"),
                    new AnimFlag("facgum"),
                    new AnimFlag("facsurp"),
                    new AnimFlag("facsurpm"),
                    new AnimFlag("factalk"),
                    new AnimFlag("facurios"),
                    new AnimFlag("fall_back"),
                    new AnimFlag("fall_collapse"),
                    new AnimFlag("fall_fall"),
                    new AnimFlag("fall_front"),
                    new AnimFlag("fall_glide"),
                    new AnimFlag("fall_land"),
                    new AnimFlag("fall_skydive"),
                    new AnimFlag("fight2idle"),
                    new AnimFlag("fighta_1"),
                    new AnimFlag("fighta_2"),
                    new AnimFlag("fighta_3"),
                    new AnimFlag("fighta_block"),
                    new AnimFlag("fighta_g"),
                    new AnimFlag("fighta_m"),
                    new AnimFlag("fightidle"),
                    new AnimFlag("fightshb"),
                    new AnimFlag("fightshf"),
                    new AnimFlag("fightsh_bwd"),
                    new AnimFlag("fightsh_fwd"),
                    new AnimFlag("fightsh_left"),
                    new AnimFlag("fightsh_right"),
                    new AnimFlag("flee_lkaround_01"),
                    new AnimFlag("floor_hit"),
                    new AnimFlag("floor_hit_f"),
                    new AnimFlag("fucku"),
                    new AnimFlag("gang_gunstand"),
                    new AnimFlag("gas_cwr"),
                    new AnimFlag("getup"),
                    new AnimFlag("getup_front"),
                    new AnimFlag("gum_eat"),
                    new AnimFlag("guncrouchbwd"),
                    new AnimFlag("guncrouchfwd"),
                    new AnimFlag("gunmove_bwd"),
                    new AnimFlag("gunmove_fwd"),
                    new AnimFlag("gunmove_l"),
                    new AnimFlag("gunmove_r"),
                    new AnimFlag("gun_2_idle"),
                    new AnimFlag("gun_butt"),
                    new AnimFlag("gun_butt_crouch"),
                    new AnimFlag("gun_stand"),
                    new AnimFlag("handscower"),
                    new AnimFlag("handsup"),
                    new AnimFlag("hita_1"),
                    new AnimFlag("hita_2"),
                    new AnimFlag("hita_3"),
                    new AnimFlag("hit_back"),
                    new AnimFlag("hit_behind"),
                    new AnimFlag("hit_front"),
                    new AnimFlag("hit_gun_butt"),
                    new AnimFlag("hit_l"),
                    new AnimFlag("hit_r"),
                    new AnimFlag("hit_walk"),
                    new AnimFlag("hit_wall"),
                    new AnimFlag("idlestance_fat"),
                    new AnimFlag("idlestance_old"),
                    new AnimFlag("idle_armed"),
                    new AnimFlag("idle_chat"),
                    new AnimFlag("idle_csaw"),
                    new AnimFlag("idle_gang1"),
                    new AnimFlag("idle_hbhb"),
                    new AnimFlag("idle_rocket"),
                    new AnimFlag("idle_stance"),
                    new AnimFlag("idle_taxi"),
                    new AnimFlag("idle_tired"),
                    new AnimFlag("jetpack_idle"),
                    new AnimFlag("jog_femalea"),
                    new AnimFlag("jog_malea"),
                    new AnimFlag("jump_glide"),
                    new AnimFlag("jump_land"),
                    new AnimFlag("jump_launch"),
                    new AnimFlag("jump_launch_r"),
                    new AnimFlag("kart_drive"),
                    new AnimFlag("kart_l"),
                    new AnimFlag("kart_lb"),
                    new AnimFlag("kart_r"),
                    new AnimFlag("kd_left"),
                    new AnimFlag("kd_right"),
                    new AnimFlag("ko_shot_face"),
                    new AnimFlag("ko_shot_front"),
                    new AnimFlag("ko_shot_stom"),
                    new AnimFlag("ko_skid_back"),
                    new AnimFlag("ko_skid_front"),
                    new AnimFlag("ko_spin_l"),
                    new AnimFlag("ko_spin_r"),
                    new AnimFlag("pass_smoke_in_car"),
                    new AnimFlag("phone_in"),
                    new AnimFlag("phone_out"),
                    new AnimFlag("phone_talk"),
                    new AnimFlag("player_sneak"),
                    new AnimFlag("player_sneak_walkstart"),
                    new AnimFlag("roadcross"),
                    new AnimFlag("roadcross_female"),
                    new AnimFlag("roadcross_gang"),
                    new AnimFlag("roadcross_old"),
                    new AnimFlag("run_1armed"),
                    new AnimFlag("run_armed"),
                    new AnimFlag("run_civi"),
                    new AnimFlag("run_csaw"),
                    new AnimFlag("run_fat"),
                    new AnimFlag("run_fatold"),
                    new AnimFlag("run_gang1"),
                    new AnimFlag("run_left"),
                    new AnimFlag("run_old"),
                    new AnimFlag("run_player"),
                    new AnimFlag("run_right"),
                    new AnimFlag("run_rocket"),
                    new AnimFlag("run_stop"),
                    new AnimFlag("run_stopr"),
                    new AnimFlag("run_wuzi"),
                    new AnimFlag("seat_down"),
                    new AnimFlag("seat_idle"),
                    new AnimFlag("seat_up"),
                    new AnimFlag("shot_leftp"),
                    new AnimFlag("shot_partial"),
                    new AnimFlag("shot_partial_b"),
                    new AnimFlag("shot_rightp"),
                    new AnimFlag("shove_partial"),
                    new AnimFlag("smoke_in_car"),
                    new AnimFlag("sprint_civi"),
                    new AnimFlag("sprint_panic"),
                    new AnimFlag("sprint_wuzi"),
                    new AnimFlag("swat_run"),
                    new AnimFlag("swim_tread"),
                    new AnimFlag("tap_hand"),
                    new AnimFlag("tap_handp"),
                    new AnimFlag("turn_180"),
                    new AnimFlag("turn_l"),
                    new AnimFlag("turn_r"),
                    new AnimFlag("walk_armed"),
                    new AnimFlag("walk_civi"),
                    new AnimFlag("walk_csaw"),
                    new AnimFlag("walk_doorpartial"),
                    new AnimFlag("walk_drunk"),
                    new AnimFlag("walk_fat"),
                    new AnimFlag("walk_fatold"),
                    new AnimFlag("walk_gang1"),
                    new AnimFlag("walk_gang2"),
                    new AnimFlag("walk_old"),
                    new AnimFlag("walk_player"),
                    new AnimFlag("walk_rocket"),
                    new AnimFlag("walk_shuffle"),
                    new AnimFlag("walk_start"),
                    new AnimFlag("walk_start_armed"),
                    new AnimFlag("walk_start_csaw"),
                    new AnimFlag("walk_start_rocket"),
                    new AnimFlag("walk_wuzi"),
                    new AnimFlag("weapon_crouch"),
                    new AnimFlag("woman_idlestance"),
                    new AnimFlag("woman_run"),
                    new AnimFlag("woman_runbusy"),
                    new AnimFlag("woman_runfatold"),
                    new AnimFlag("woman_runpanic"),
                    new AnimFlag("woman_runsexy"),
                    new AnimFlag("woman_walkbusy"),
                    new AnimFlag("woman_walkfatold"),
                    new AnimFlag("woman_walknorm"),
                    new AnimFlag("woman_walkold"),
                    new AnimFlag("woman_walkpro"),
                    new AnimFlag("woman_walksexy"),
                    new AnimFlag("woman_walkshop"),
                    new AnimFlag("xpressscratch")
                }
            },
            {
                AnimationGroups.Player_Dvbys,
                new List<AnimFlag>()
                {
                    new AnimFlag("plyr_drivebybwd"),
                    new AnimFlag("plyr_drivebyfwd"),
                    new AnimFlag("plyr_drivebylhs"),
                    new AnimFlag("plyr_drivebyrhs")
                }
            },
            {
                AnimationGroups.Playidles,
                new List<AnimFlag>()
                {
                    new AnimFlag("shift"),
                    new AnimFlag("shldr"),
                    new AnimFlag("stretch"),
                    new AnimFlag("strleg"),
                    new AnimFlag("time")
                }
            },
            {
                AnimationGroups.Police,
                new List<AnimFlag>()
                {
                    new AnimFlag("coptraf_away"),
                    new AnimFlag("coptraf_come"),
                    new AnimFlag("coptraf_left"),
                    new AnimFlag("coptraf_stop"),
                    new AnimFlag("cop_getoutcar_lhs"),
                    new AnimFlag("cop_move_fwd"),
                    new AnimFlag("crm_drgbst_01"),
                    new AnimFlag("door_kick"),
                    new AnimFlag("plc_drgbst_01"),
                    new AnimFlag("plc_drgbst_02")
                }
            },
            {
                AnimationGroups.Pool,
                new List<AnimFlag>()
                {
                    new AnimFlag("pool_chalkcue"),
                    new AnimFlag("pool_idle_stance"),
                    new AnimFlag("pool_long_shot"),
                    new AnimFlag("pool_long_shot_o"),
                    new AnimFlag("pool_long_start"),
                    new AnimFlag("pool_long_start_o"),
                    new AnimFlag("pool_med_shot"),
                    new AnimFlag("pool_med_shot_o"),
                    new AnimFlag("pool_med_start"),
                    new AnimFlag("pool_med_start_o"),
                    new AnimFlag("pool_place_white"),
                    new AnimFlag("pool_short_shot"),
                    new AnimFlag("pool_short_shot_o"),
                    new AnimFlag("pool_short_start"),
                    new AnimFlag("pool_short_start_o"),
                    new AnimFlag("pool_walk"),
                    new AnimFlag("pool_walk_start"),
                    new AnimFlag("pool_xlong_shot"),
                    new AnimFlag("pool_xlong_shot_o"),
                    new AnimFlag("pool_xlong_start"),
                    new AnimFlag("pool_xlong_start_o")
                }
            },
            {
                AnimationGroups.Poor,
                new List<AnimFlag>()
                {
                    new AnimFlag("winwash_start"),
                    new AnimFlag("winwash_wash2beg")
                }
            },
            {
                AnimationGroups.Python,
                new List<AnimFlag>()
                {
                    new AnimFlag("python_crouchfire"),
                    new AnimFlag("python_crouchreload"),
                    new AnimFlag("python_fire"),
                    new AnimFlag("python_fire_poor"),
                    new AnimFlag("python_reload")
                }
            },
            {
                AnimationGroups.Quad,
                new List<AnimFlag>()
                {
                    new AnimFlag("quad_back"),
                    new AnimFlag("quad_driveby_ft"),
                    new AnimFlag("quad_driveby_lhs"),
                    new AnimFlag("quad_driveby_rhs"),
                    new AnimFlag("quad_fwd"),
                    new AnimFlag("quad_getoff_b"),
                    new AnimFlag("quad_getoff_lhs"),
                    new AnimFlag("quad_getoff_rhs"),
                    new AnimFlag("quad_geton_lhs"),
                    new AnimFlag("quad_geton_rhs"),
                    new AnimFlag("quad_hit"),
                    new AnimFlag("quad_kick"),
                    new AnimFlag("quad_left"),
                    new AnimFlag("quad_passenger"),
                    new AnimFlag("quad_reverse"),
                    new AnimFlag("quad_ride"),
                    new AnimFlag("quad_right")
                }
            },
            {
                AnimationGroups.Quad_Dbz,
                new List<AnimFlag>()
                {
                    new AnimFlag("pass_driveby_bwd"),
                    new AnimFlag("pass_driveby_fwd"),
                    new AnimFlag("pass_driveby_lhs"),
                    new AnimFlag("pass_driveby_rhs")
                }
            },
            {
                AnimationGroups.Rapping,
                new List<AnimFlag>()
                {
                    new AnimFlag("laugh_01"),
                    new AnimFlag("rap_a_in"),
                    new AnimFlag("rap_a_loop"),
                    new AnimFlag("rap_a_out"),
                    new AnimFlag("rap_b_in"),
                    new AnimFlag("rap_b_loop"),
                    new AnimFlag("rap_b_out"),
                    new AnimFlag("rap_c_loop")
                }
            },
            {
                AnimationGroups.Rifle,
                new List<AnimFlag>()
                {
                    new AnimFlag("rifle_crouchfire"),
                    new AnimFlag("rifle_crouchload"),
                    new AnimFlag("rifle_fire"),
                    new AnimFlag("rifle_fire_poor"),
                    new AnimFlag("rifle_load")
                }
            },
            {
                AnimationGroups.Riot,
                new List<AnimFlag>()
                {
                    new AnimFlag("riot_angry"),
                    new AnimFlag("riot_angry_b"),
                    new AnimFlag("riot_challenge"),
                    new AnimFlag("riot_chant"),
                    new AnimFlag("riot_fuku"),
                    new AnimFlag("riot_punches"),
                    new AnimFlag("riot_shout")
                }
            },
            {
                AnimationGroups.Rob_Bank,
                new List<AnimFlag>()
                {
                    new AnimFlag("cat_safe_end"),
                    new AnimFlag("cat_safe_open"),
                    new AnimFlag("cat_safe_open_o"),
                    new AnimFlag("cat_safe_rob"),
                    new AnimFlag("shp_handsup_scr")
                }
            },
            {
                AnimationGroups.Rocket,
                new List<AnimFlag>()
                {
                    new AnimFlag("idle_rocket"),
                    new AnimFlag("rocketfire"),
                    new AnimFlag("run_rocket"),
                    new AnimFlag("walk_rocket"),
                    new AnimFlag("walk_start_rocket")
                }
            },
            {
                AnimationGroups.Rustler,
                new List<AnimFlag>()
                {
                    new AnimFlag("plane_align_lhs"),
                    new AnimFlag("plane_close"),
                    new AnimFlag("plane_getin"),
                    new AnimFlag("plane_getout"),
                    new AnimFlag("plane_open")
                }
            },
            {
                AnimationGroups.Ryder,
                new List<AnimFlag>()
                {
                    new AnimFlag("ryd_beckon_01"),
                    new AnimFlag("ryd_beckon_02"),
                    new AnimFlag("ryd_beckon_03"),
                    new AnimFlag("ryd_die_pt1"),
                    new AnimFlag("ryd_die_pt2"),
                    new AnimFlag("van_crate_l"),
                    new AnimFlag("van_crate_r"),
                    new AnimFlag("van_fall_l"),
                    new AnimFlag("van_fall_r"),
                    new AnimFlag("van_lean_l"),
                    new AnimFlag("van_lean_r"),
                    new AnimFlag("van_pickup_e"),
                    new AnimFlag("van_pickup_s"),
                    new AnimFlag("van_stand"),
                    new AnimFlag("van_stand_crate"),
                    new AnimFlag("van_throw")
                }
            },
            {
                AnimationGroups.Scratching,
                new List<AnimFlag>()
                {
                    new AnimFlag("scdldlp"),
                    new AnimFlag("scdlulp"),
                    new AnimFlag("scdrdlp"),
                    new AnimFlag("scdrulp"),
                    new AnimFlag("sclng_l"),
                    new AnimFlag("sclng_r"),
                    new AnimFlag("scmid_l"),
                    new AnimFlag("scmid_r"),
                    new AnimFlag("scshrtl"),
                    new AnimFlag("scshrtr"),
                    new AnimFlag("sc_ltor"),
                    new AnimFlag("sc_rtol")
                }
            },
            {
                AnimationGroups.Shamal,
                new List<AnimFlag>()
                {
                    new AnimFlag("shamal_align"),
                    new AnimFlag("shamal_getin_lhs"),
                    new AnimFlag("shamal_getout_lhs"),
                    new AnimFlag("shamal_open")
                }
            },
            {
                AnimationGroups.Shop,
                new List<AnimFlag>()
                {
                    new AnimFlag("rob_2idle"),
                    new AnimFlag("rob_loop"),
                    new AnimFlag("rob_loop_threat"),
                    new AnimFlag("rob_shifty"),
                    new AnimFlag("rob_stickup_in"),
                    new AnimFlag("shp_duck"),
                    new AnimFlag("shp_duck_aim"),
                    new AnimFlag("shp_duck_fire"),
                    new AnimFlag("shp_gun_aim"),
                    new AnimFlag("shp_gun_duck"),
                    new AnimFlag("shp_gun_fire"),
                    new AnimFlag("shp_gun_grab"),
                    new AnimFlag("shp_gun_threat"),
                    new AnimFlag("shp_handsup_scr"),
                    new AnimFlag("shp_jump_glide"),
                    new AnimFlag("shp_jump_land"),
                    new AnimFlag("shp_jump_launch"),
                    new AnimFlag("shp_rob_givecash"),
                    new AnimFlag("shp_rob_handsup"),
                    new AnimFlag("shp_rob_react"),
                    new AnimFlag("shp_serve_end"),
                    new AnimFlag("shp_serve_idle"),
                    new AnimFlag("shp_serve_loop"),
                    new AnimFlag("shp_serve_start"),
                    new AnimFlag("smoke_ryd")
                }
            },
            {
                AnimationGroups.Shotgun,
                new List<AnimFlag>()
                {
                    new AnimFlag("shotgun_crouchfire"),
                    new AnimFlag("shotgun_fire"),
                    new AnimFlag("shotgun_fire_poor")
                }
            },
            {
                AnimationGroups.Silenced,
                new List<AnimFlag>()
                {
                    new AnimFlag("crouchreload"),
                    new AnimFlag("silencecrouchfire"),
                    new AnimFlag("silence_fire"),
                    new AnimFlag("silence_reload")
                }
            },
            {
                AnimationGroups.Skate,
                new List<AnimFlag>()
                {
                    new AnimFlag("skate_idle"),
                    new AnimFlag("skate_run"),
                    new AnimFlag("skate_sprint")
                }
            },
            {
                AnimationGroups.Smoking,
                new List<AnimFlag>()
                {
                    new AnimFlag("f_smklean_loop"),
                    new AnimFlag("m_smklean_loop"),
                    new AnimFlag("m_smkstnd_loop"),
                    new AnimFlag("m_smk_drag"),
                    new AnimFlag("m_smk_in"),
                    new AnimFlag("m_smk_loop"),
                    new AnimFlag("m_smk_out"),
                    new AnimFlag("m_smk_tap")
                }
            },
            {
                AnimationGroups.Sniper,
                new List<AnimFlag>()
                {
                    new AnimFlag("weapon_sniper")
                }
            },
            {
                AnimationGroups.Spraycan,
                new List<AnimFlag>()
                {
                    new AnimFlag("spraycan_fire"),
                    new AnimFlag("spraycan_full")
                }
            },
            {
                AnimationGroups.Strip,
                new List<AnimFlag>()
                {
                    new AnimFlag("ply_cash"),
                    new AnimFlag("pun_cash"),
                    new AnimFlag("pun_holler"),
                    new AnimFlag("pun_loop"),
                    new AnimFlag("strip_a"),
                    new AnimFlag("strip_b"),
                    new AnimFlag("strip_c"),
                    new AnimFlag("strip_d"),
                    new AnimFlag("strip_e"),
                    new AnimFlag("strip_f"),
                    new AnimFlag("strip_g"),
                    new AnimFlag("str_a2b"),
                    new AnimFlag("str_b2a"),
                    new AnimFlag("str_b2c"),
                    new AnimFlag("str_c1"),
                    new AnimFlag("str_c2"),
                    new AnimFlag("str_c2b"),
                    new AnimFlag("str_loop_a"),
                    new AnimFlag("str_loop_b"),
                    new AnimFlag("str_loop_c")
                }
            },
            {
                AnimationGroups.Sunbathe,
                new List<AnimFlag>()
                {
                    new AnimFlag("batherdown"),
                    new AnimFlag("batherup"),
                    new AnimFlag("lay_bac_in"),
                    new AnimFlag("lay_bac_out"),
                    new AnimFlag("parksit_m_idlea"),
                    new AnimFlag("parksit_m_idleb"),
                    new AnimFlag("parksit_m_idlec"),
                    new AnimFlag("parksit_m_in"),
                    new AnimFlag("parksit_m_out"),
                    new AnimFlag("parksit_w_idlea"),
                    new AnimFlag("parksit_w_idleb"),
                    new AnimFlag("parksit_w_idlec"),
                    new AnimFlag("parksit_w_in"),
                    new AnimFlag("parksit_w_out"),
                    new AnimFlag("sbathe_f_lieb2sit"),
                    new AnimFlag("sbathe_f_out"),
                    new AnimFlag("sitnwait_in_w"),
                    new AnimFlag("sitnwait_out_w")
                }
            },
            {
                AnimationGroups.Swat,
                new List<AnimFlag>()
                {
                    new AnimFlag("gnstwall_injurd"),
                    new AnimFlag("jmp_wall1m_180"),
                    new AnimFlag("rail_fall"),
                    new AnimFlag("rail_fall_crawl"),
                    new AnimFlag("swt_breach_01"),
                    new AnimFlag("swt_breach_02"),
                    new AnimFlag("swt_breach_03"),
                    new AnimFlag("swt_go"),
                    new AnimFlag("swt_lkt"),
                    new AnimFlag("swt_sty"),
                    new AnimFlag("swt_vent_01"),
                    new AnimFlag("swt_vent_02"),
                    new AnimFlag("swt_vnt_sht_die"),
                    new AnimFlag("swt_vnt_sht_in"),
                    new AnimFlag("swt_vnt_sht_loop"),
                    new AnimFlag("swt_wllpk_l"),
                    new AnimFlag("swt_wllpk_l_back"),
                    new AnimFlag("swt_wllpk_r"),
                    new AnimFlag("swt_wllpk_r_back"),
                    new AnimFlag("swt_wllshoot_in_l"),
                    new AnimFlag("swt_wllshoot_in_r"),
                    new AnimFlag("swt_wllshoot_out_l"),
                    new AnimFlag("swt_wllshoot_out_r")
                }
            },
            {
                AnimationGroups.Sweet,
                new List<AnimFlag>()
                {
                    new AnimFlag("ho_ass_slapped"),
                    new AnimFlag("lafin_player"),
                    new AnimFlag("lafin_sweet"),
                    new AnimFlag("plyr_hndshldr_01"),
                    new AnimFlag("sweet_ass_slap"),
                    new AnimFlag("sweet_hndshldr_01"),
                    new AnimFlag("sweet_injuredloop")
                }
            },
            {
                AnimationGroups.Swim,
                new List<AnimFlag>()
                {
                    new AnimFlag("swim_breast"),
                    new AnimFlag("swim_crawl"),
                    new AnimFlag("swim_dive_under"),
                    new AnimFlag("swim_glide"),
                    new AnimFlag("swim_jumpout"),
                    new AnimFlag("swim_tread"),
                    new AnimFlag("swim_under")
                }
            },
            {
                AnimationGroups.Sword,
                new List<AnimFlag>()
                {
                    new AnimFlag("sword_1"),
                    new AnimFlag("sword_2"),
                    new AnimFlag("sword_3"),
                    new AnimFlag("sword_4"),
                    new AnimFlag("sword_block"),
                    new AnimFlag("sword_hit_1"),
                    new AnimFlag("sword_hit_2"),
                    new AnimFlag("sword_hit_3"),
                    new AnimFlag("sword_idle"),
                    new AnimFlag("sword_part")
                }
            },
            {
                AnimationGroups.Tank,
                new List<AnimFlag>()
                {
                    new AnimFlag("tank_align_lhs"),
                    new AnimFlag("tank_close_lhs"),
                    new AnimFlag("tank_doorlocked"),
                    new AnimFlag("tank_getin_lhs"),
                    new AnimFlag("tank_getout_lhs"),
                    new AnimFlag("tank_open_lhs")
                }
            },
            {
                AnimationGroups.Tattoos,
                new List<AnimFlag>()
                {
                    new AnimFlag("tat_arml_in_o"),
                    new AnimFlag("tat_arml_in_p"),
                    new AnimFlag("tat_arml_in_t"),
                    new AnimFlag("tat_arml_out_o"),
                    new AnimFlag("tat_arml_out_p"),
                    new AnimFlag("tat_arml_out_t"),
                    new AnimFlag("tat_arml_pose_o"),
                    new AnimFlag("tat_arml_pose_p"),
                    new AnimFlag("tat_arml_pose_t"),
                    new AnimFlag("tat_armr_in_o"),
                    new AnimFlag("tat_armr_in_p"),
                    new AnimFlag("tat_armr_in_t"),
                    new AnimFlag("tat_armr_out_o"),
                    new AnimFlag("tat_armr_out_p"),
                    new AnimFlag("tat_armr_out_t"),
                    new AnimFlag("tat_armr_pose_o"),
                    new AnimFlag("tat_armr_pose_p"),
                    new AnimFlag("tat_armr_pose_t"),
                    new AnimFlag("tat_back_in_o"),
                    new AnimFlag("tat_back_in_p"),
                    new AnimFlag("tat_back_in_t"),
                    new AnimFlag("tat_back_out_o"),
                    new AnimFlag("tat_back_out_p"),
                    new AnimFlag("tat_back_out_t"),
                    new AnimFlag("tat_back_pose_o"),
                    new AnimFlag("tat_back_pose_p"),
                    new AnimFlag("tat_back_pose_t"),
                    new AnimFlag("tat_back_sit_in_p"),
                    new AnimFlag("tat_back_sit_loop_p"),
                    new AnimFlag("tat_back_sit_out_p"),
                    new AnimFlag("tat_bel_in_o"),
                    new AnimFlag("tat_bel_in_t"),
                    new AnimFlag("tat_bel_out_o"),
                    new AnimFlag("tat_bel_out_t"),
                    new AnimFlag("tat_bel_pose_o"),
                    new AnimFlag("tat_bel_pose_t"),
                    new AnimFlag("tat_che_in_o"),
                    new AnimFlag("tat_che_in_p"),
                    new AnimFlag("tat_che_in_t"),
                    new AnimFlag("tat_che_out_o"),
                    new AnimFlag("tat_che_out_p"),
                    new AnimFlag("tat_che_out_t"),
                    new AnimFlag("tat_che_pose_o"),
                    new AnimFlag("tat_che_pose_p"),
                    new AnimFlag("tat_che_pose_t"),
                    new AnimFlag("tat_drop_o"),
                    new AnimFlag("tat_idle_loop_o"),
                    new AnimFlag("tat_idle_loop_t"),
                    new AnimFlag("tat_sit_in_o"),
                    new AnimFlag("tat_sit_in_p"),
                    new AnimFlag("tat_sit_in_t"),
                    new AnimFlag("tat_sit_loop_o"),
                    new AnimFlag("tat_sit_loop_p"),
                    new AnimFlag("tat_sit_loop_t"),
                    new AnimFlag("tat_sit_out_o"),
                    new AnimFlag("tat_sit_out_p"),
                    new AnimFlag("tat_sit_out_t")
                }
            },
            {
                AnimationGroups.Tec,
                new List<AnimFlag>()
                {
                    new AnimFlag("tec_crouchfire"),
                    new AnimFlag("tec_crouchreload"),
                    new AnimFlag("tec_fire"),
                    new AnimFlag("tec_reload")
                }
            },
            {
                AnimationGroups.Train,
                new List<AnimFlag>()
                {
                    new AnimFlag("tran_gtup"),
                    new AnimFlag("tran_hng"),
                    new AnimFlag("tran_ouch"),
                    new AnimFlag("tran_stmb")
                }
            },
            {
                AnimationGroups.Truck,
                new List<AnimFlag>()
                {
                    new AnimFlag("truck_align_lhs"),
                    new AnimFlag("truck_align_rhs"),
                    new AnimFlag("truck_closedoor_lhs"),
                    new AnimFlag("truck_closedoor_rhs"),
                    new AnimFlag("truck_close_lhs"),
                    new AnimFlag("truck_close_rhs"),
                    new AnimFlag("truck_getin_lhs"),
                    new AnimFlag("truck_getin_rhs"),
                    new AnimFlag("truck_getout_lhs"),
                    new AnimFlag("truck_getout_rhs"),
                    new AnimFlag("truck_jackedlhs"),
                    new AnimFlag("truck_jackedrhs"),
                    new AnimFlag("truck_open_lhs"),
                    new AnimFlag("truck_open_rhs"),
                    new AnimFlag("truck_pullout_lhs"),
                    new AnimFlag("truck_pullout_rhs"),
                    new AnimFlag("truck_shuffle")
                }
            },
            {
                AnimationGroups.Uzi,
                new List<AnimFlag>()
                {
                    new AnimFlag("uzi_crouchfire"),
                    new AnimFlag("uzi_crouchreload"),
                    new AnimFlag("uzi_fire"),
                    new AnimFlag("uzi_fire_poor"),
                    new AnimFlag("uzi_reload")
                }
            },
            {
                AnimationGroups.Van,
                new List<AnimFlag>()
                {
                    new AnimFlag("van_close_back_lhs"),
                    new AnimFlag("van_close_back_rhs"),
                    new AnimFlag("van_getin_back_lhs"),
                    new AnimFlag("van_getin_back_rhs"),
                    new AnimFlag("van_getout_back_lhs"),
                    new AnimFlag("van_getout_back_rhs"),
                    new AnimFlag("van_open_back_lhs"),
                    new AnimFlag("van_open_back_rhs")
                }
            },
            {
                AnimationGroups.Vending,
                new List<AnimFlag>()
                {
                    new AnimFlag("vend_drink2_p"),
                    new AnimFlag("vend_drink_p"),
                    new AnimFlag("vend_eat1_p"),
                    new AnimFlag("vend_eat_p"),
                    new AnimFlag("vend_use"),
                    new AnimFlag("vend_use_pt2")
                }
            },
            {
                AnimationGroups.Vortex,
                new List<AnimFlag>()
                {
                    new AnimFlag("car_jumpin_lhs"),
                    new AnimFlag("car_jumpin_rhs"),
                    new AnimFlag("vortex_getout_lhs"),
                    new AnimFlag("vortex_getout_rhs")
                }
            },
            {
                AnimationGroups.Wayfarer,
                new List<AnimFlag>()
                {
                    new AnimFlag("wf_back"),
                    new AnimFlag("wf_drivebyft"),
                    new AnimFlag("wf_drivebylhs"),
                    new AnimFlag("wf_drivebyrhs"),
                    new AnimFlag("wf_fwd"),
                    new AnimFlag("wf_getoffback"),
                    new AnimFlag("wf_getofflhs"),
                    new AnimFlag("wf_getoffrhs"),
                    new AnimFlag("wf_hit"),
                    new AnimFlag("wf_jumponl"),
                    new AnimFlag("wf_jumponr"),
                    new AnimFlag("wf_kick"),
                    new AnimFlag("wf_left"),
                    new AnimFlag("wf_passenger"),
                    new AnimFlag("wf_pushes"),
                    new AnimFlag("wf_ride"),
                    new AnimFlag("wf_right"),
                    new AnimFlag("wf_still")
                }
            },
            {
                AnimationGroups.Weapons,
                new List<AnimFlag>()
                {
                    new AnimFlag("shp_1h_lift"),
                    new AnimFlag("shp_1h_lift_end"),
                    new AnimFlag("shp_1h_ret"),
                    new AnimFlag("shp_1h_ret_s"),
                    new AnimFlag("shp_2h_lift"),
                    new AnimFlag("shp_2h_lift_end"),
                    new AnimFlag("shp_2h_ret"),
                    new AnimFlag("shp_2h_ret_s"),
                    new AnimFlag("shp_ar_lift"),
                    new AnimFlag("shp_ar_lift_end"),
                    new AnimFlag("shp_ar_ret"),
                    new AnimFlag("shp_ar_ret_s"),
                    new AnimFlag("shp_g_lift_in"),
                    new AnimFlag("shp_g_lift_out"),
                    new AnimFlag("shp_tray_in"),
                    new AnimFlag("shp_tray_out"),
                    new AnimFlag("shp_tray_pose")
                }
            },
            {
                AnimationGroups.Wuzi,
                new List<AnimFlag>()
                {
                    new AnimFlag("cs_dead_guy"),
                    new AnimFlag("cs_plyr_pt1"),
                    new AnimFlag("cs_plyr_pt2"),
                    new AnimFlag("cs_wuzi_pt1"),
                    new AnimFlag("cs_wuzi_pt2"),
                    new AnimFlag("walkstart_idle_01"),
                    new AnimFlag("wuzi_follow"),
                    new AnimFlag("wuzi_greet_plyr"),
                    new AnimFlag("wuzi_greet_wuzi"),
                    new AnimFlag("wuzi_grnd_chk"),
                    new AnimFlag("wuzi_stand_loop"),
                    new AnimFlag("wuzi_walk"),
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

    public class AnimFlag
    {
        public string anim;
        public bool m_buggy;

        public AnimFlag(string a, bool b = false)
        {
            anim = a;
            m_buggy = b;
        }
    }
}