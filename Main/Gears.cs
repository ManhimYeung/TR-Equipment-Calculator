using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Gears
{
    //ID of the item, according to the No. in game
    public Dictionary<string, int> IDLookup = new Dictionary<string, int>();
    //Rarity of the item
    //C = 1
    //B = 2
    //A = 3
    //S = 4
    //SS = 5
    //SSS = 6
    public Dictionary<string, int> CRarityLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BRarityLookup = new Dictionary<string, int>();
    public Dictionary<string, int> ARarityLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SRarityLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSRarityLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSRarityLookup = new Dictionary<string, int>();
    //Avatar = true
    //Character = false
    public Dictionary<string, bool> CModeLookup = new Dictionary<string, bool>();
    public Dictionary<string, bool> BModeLookup = new Dictionary<string, bool>();
    public Dictionary<string, bool> AModeLookup = new Dictionary<string, bool>();
    public Dictionary<string, bool> SModeLookup = new Dictionary<string, bool>();
    public Dictionary<string, bool> SSModeLookup = new Dictionary<string, bool>();
    public Dictionary<string, bool> SSSModeLookup = new Dictionary<string, bool>();
    //Highest speed given from the item (最高速度)
    public Dictionary<string, int> CSpeedLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BSpeedLookup = new Dictionary<string, int>();
    public Dictionary<string, int> ASpeedLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSpeedLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSpeedLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSSpeedLookup = new Dictionary<string, int>();
    //Acceleration given from the item (加速度)
    public Dictionary<string, int> CAccelerationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BAccelerationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> AAccelerationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SAccelerationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSAccelerationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSAccelerationLookup = new Dictionary<string, int>();
    //Power given from the item (力量)
    public Dictionary<string, int> CPowerLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BPowerLookup = new Dictionary<string, int>();
    public Dictionary<string, int> APowerLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SPowerLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSPowerLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSPowerLookup = new Dictionary<string, int>();
    //Sensitivity/Control given from the item (控制)
    public Dictionary<string, int> CControlLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BControlLookup = new Dictionary<string, int>();
    public Dictionary<string, int> AControlLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SControlLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSControlLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSControlLookup = new Dictionary<string, int>();
    //Rage time given from the item (憤怒持續)
    public Dictionary<string, int> CRageDurationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BRageDurationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> ARageDurationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SRageDurationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSRageDurationLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSRageDurationLookup = new Dictionary<string, int>();
    //Rage charge speed given from the item (憤怒累積)
    public Dictionary<string, int> CRageChargeLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BRageChargeLookup = new Dictionary<string, int>();
    public Dictionary<string, int> ARageChargeLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SRageChargeLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSRageChargeLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSRageChargeLookup = new Dictionary<string, int>();
    //Max energy given from the item (最大體力值)
    public Dictionary<string, int> CMaxEnergyLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BMaxEnergyLookup = new Dictionary<string, int>();
    public Dictionary<string, int> AMaxEnergyLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SMaxEnergyLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSMaxEnergyLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSMaxEnergyLookup = new Dictionary<string, int>();
    //Max sprint speed given from the item (最高衝刺)
    public Dictionary<string, int> CMaxSprintLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BMaxSprintLookup = new Dictionary<string, int>();
    public Dictionary<string, int> AMaxSprintLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SMaxSprintLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSMaxSprintLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSMaxSprintLookup = new Dictionary<string, int>();
    //Force given from the item (推進力)
    public Dictionary<string, int> CForceLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BForceLookup = new Dictionary<string, int>();
    public Dictionary<string, int> AForceLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SForceLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSForceLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSForceLookup = new Dictionary<string, int>();
    //Luck given from the item (幸運)
    public Dictionary<string, int> CLuckLookup = new Dictionary<string, int>();
    public Dictionary<string, int> BLuckLookup = new Dictionary<string, int>();
    public Dictionary<string, int> ALuckLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SLuckLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSLuckLookup = new Dictionary<string, int>();
    public Dictionary<string, int> SSSLuckLookup = new Dictionary<string, int>();
}

