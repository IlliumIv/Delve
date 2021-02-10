using ExileCore.PoEMemory.Components;
using ExileCore.PoEMemory.MemoryObjects;
using ExileCore.Shared.AtlasHelper;
using Delve.Libs;
using SharpDX;
using System.Linq;

namespace Delve
{
    partial class DelveCore
    {
        private AtlasTexture _iconAbberantFossil;
        private AtlasTexture _iconAbberantFossilT1;
        private AtlasTexture _iconAbberantFossilT2;
        private AtlasTexture _iconAbberantFossilT3;
        private AtlasTexture _iconAbyssChest;
        private AtlasTexture _iconAbyssCrack;
        private AtlasTexture _iconAbyssJewelChest;
        private AtlasTexture _iconAdditionalSockets;
        private AtlasTexture _iconAmbushInvasionChest;
        private AtlasTexture _iconAzurite;
        private AtlasTexture _iconAzuriteT1;
        private AtlasTexture _iconAzuriteT2;
        private AtlasTexture _iconAzuriteT3;
        private AtlasTexture _iconBestiaryChest;
        private AtlasTexture _iconBeyondChest;
        private AtlasTexture _iconBloodlinesChest;
        private AtlasTexture _iconBombs;
        private AtlasTexture _iconBreachChest;
        private AtlasTexture _iconCorrupted;
        private AtlasTexture _iconCurrency;
        private AtlasTexture _iconDelveChest;
        private AtlasTexture _iconDivinationCard;
        private AtlasTexture _iconDominationChest;
        private AtlasTexture _iconEnchant;
        private AtlasTexture _iconEssence;
        private AtlasTexture _iconFlare;
        private AtlasTexture _iconFragment;
        private AtlasTexture _iconGate;
        private AtlasTexture _iconHarbingerChest;
        private AtlasTexture _iconHiddenDoor;
        private AtlasTexture _iconHighLevelGem;
        private AtlasTexture _iconIncursionChest;
        private AtlasTexture _iconMap;
        private AtlasTexture _iconNemesisChest;
        private AtlasTexture _iconOfferingChest;
        private AtlasTexture _iconOnslaughtChest;
        private AtlasTexture _iconPaleCourtComplete;
        private AtlasTexture _iconPerandusChest;
        private AtlasTexture _iconPerandusCoins;
        private AtlasTexture _iconProphecy;
        private AtlasTexture _iconRampageChest;
        private AtlasTexture _iconRareAmulet;
        private AtlasTexture _iconResonatorT1;
        private AtlasTexture _iconResonatorT2;
        private AtlasTexture _iconResonatorT3;
        private AtlasTexture _iconSilverCoin;
        private AtlasTexture _iconSixLink;
        private AtlasTexture _iconSpeedArmour;
        private AtlasTexture _iconStrongbox;
        private AtlasTexture _iconStygianViseChest;
        private AtlasTexture _iconTalismanChest;
        private AtlasTexture _iconTempestChest;
        private AtlasTexture _iconTormentChest;
        private AtlasTexture _iconUniqueManaFlask;
        private AtlasTexture _iconUpgrade2x1A;
        private AtlasTexture _iconUpgrade2x2A;
        private AtlasTexture _iconWarbandsChest;
        private AtlasTexture _iconWisdomCurrency;

        public void AtlasTextureInit()
        {
            _iconAbberantFossil = GetAtlasTexture("AbberantFossil");
            _iconAbberantFossilT1 = GetAtlasTexture("AbberantFossilT1");
            _iconAbberantFossilT2 = GetAtlasTexture("AbberantFossilT2");
            _iconAbberantFossilT3 = GetAtlasTexture("AbberantFossilT3");
            _iconAbyssChest = GetAtlasTexture("AbyssChest");
            _iconAbyssCrack = GetAtlasTexture("AbyssCrack");
            _iconAbyssJewelChest = GetAtlasTexture("AbyssJewelChest");
            _iconAdditionalSockets = GetAtlasTexture("AdditionalSockets");
            _iconAmbushInvasionChest = GetAtlasTexture("AmbushInvasionChest");
            _iconAzurite = GetAtlasTexture("Azurite");
            _iconAzuriteT1 = GetAtlasTexture("AzuriteT1");
            _iconAzuriteT2 = GetAtlasTexture("AzuriteT2");
            _iconAzuriteT3 = GetAtlasTexture("AzuriteT3");
            _iconBestiaryChest = GetAtlasTexture("BestiaryChest");
            _iconBeyondChest = GetAtlasTexture("BeyondChest");
            _iconBloodlinesChest = GetAtlasTexture("BloodlinesChest");
            _iconBombs = GetAtlasTexture("Bombs");
            _iconBreachChest = GetAtlasTexture("BreachChest");
            _iconCorrupted = GetAtlasTexture("Corrupted");
            _iconCurrency = GetAtlasTexture("Currency");
            _iconDelveChest = GetAtlasTexture("DelveChest");
            _iconDivinationCard = GetAtlasTexture("DivinationCard");
            _iconDominationChest = GetAtlasTexture("DominationChest");
            _iconEnchant = GetAtlasTexture("Enchant");
            _iconEssence = GetAtlasTexture("Essence");
            _iconFlare = GetAtlasTexture("Flare");
            _iconFragment = GetAtlasTexture("Fragment");
            _iconGate = GetAtlasTexture("Gate");
            _iconHarbingerChest = GetAtlasTexture("HarbingerChest");
            _iconHiddenDoor = GetAtlasTexture("HiddenDoor");
            _iconHighLevelGem = GetAtlasTexture("HighLevelGem");
            _iconIncursionChest = GetAtlasTexture("IncursionChest");
            _iconMap = GetAtlasTexture("Map");
            _iconNemesisChest = GetAtlasTexture("NemesisChest");
            _iconOfferingChest = GetAtlasTexture("OfferingChest");
            _iconOnslaughtChest = GetAtlasTexture("OnslaughtChest");
            _iconPaleCourtComplete = GetAtlasTexture("PaleCourtComplete");
            _iconPerandusChest = GetAtlasTexture("PerandusChest");
            _iconPerandusCoins = GetAtlasTexture("PerandusCoins");
            _iconProphecy = GetAtlasTexture("Prophecy");
            _iconRampageChest = GetAtlasTexture("RampageChest");
            _iconRareAmulet = GetAtlasTexture("RareAmulet");
            _iconResonatorT1 = GetAtlasTexture("ResonatorT1");
            _iconResonatorT2 = GetAtlasTexture("ResonatorT2");
            _iconResonatorT3 = GetAtlasTexture("ResonatorT3");
            _iconSilverCoin = GetAtlasTexture("SilverCoin");
            _iconSixLink = GetAtlasTexture("SixLink");
            _iconSpeedArmour = GetAtlasTexture("SpeedArmour");
            _iconStrongbox = GetAtlasTexture("Strongbox.png");
            _iconStygianViseChest = GetAtlasTexture("StygianViseChest");
            _iconTalismanChest = GetAtlasTexture("TalismanChest");
            _iconTempestChest = GetAtlasTexture("TempestChest");
            _iconTormentChest = GetAtlasTexture("TormentChest");
            _iconUniqueManaFlask = GetAtlasTexture("UniqueManaFlask");
            _iconUpgrade2x1A = GetAtlasTexture("Upgrade2x1A");
            _iconUpgrade2x2A = GetAtlasTexture("Upgrade2x2A");
            _iconWarbandsChest = GetAtlasTexture("WarbandsChest");
            _iconWisdomCurrency = GetAtlasTexture("WisdomCurrency");
        }

        private MapIcon GetMapIcon(Entity e)
        {
            if (e == null) return null;

            if (Settings.DelvePathWays)
            {
                if (e.Path == "Metadata/Terrain/Leagues/Delve/Objects/DelveLight")
                {
                    return new MapIcon(_iconAbyssCrack, Settings.DelvePathWaysNodeColor, Settings.DelvePathWaysNodeSize);
                }
            }
            if (Settings.DelveChests)
            {
                var chestIsOpened = e?.GetComponent<Chest>()?.IsOpened;

                if (chestIsOpened == false)
                {
                    if (e.Path.EndsWith("Encounter"))
                    {
                        return null;
                    }
                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveMiningSuppliesDynamite"))
                    {
                        return new MapIcon(_iconBombs, Settings.DelveMiningSuppliesDynamiteChestColor, Settings.DelveMiningSuppliesDynamiteChestSize);
                    }
                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DynamiteGeneric"))
                    {
                        return new MapIcon(_iconBombs, Settings.DelveMiningSuppliesDynamiteChestColor, Settings.DelveMiningSuppliesDynamiteChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveMiningSuppliesFlares"))
                    {
                        return new MapIcon(_iconFlare, Settings.DelveMiningSuppliesFlaresChestColor, Settings.DelveMiningSuppliesFlaresChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/OffPathCurrency")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/PathCurrency")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericCurrency"))
                    {
                        return new MapIcon(_iconCurrency, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericRandomEnchant"))
                    {
                        return new MapIcon(_iconEnchant, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmour6LinkedUniqueBody")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeapon6LinkedTwoHanded")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourFullyLinkedBody"))
                    {
                        return new MapIcon(_iconSixLink, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DynamiteCurrency")
                       || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCurrency")
                       )
                    {
                        string tempPath = e.Path.Replace("Metadata/Chests/DelveChests/", "");
                        if (tempPath.Contains("Currency1") || tempPath == "DynamiteCurrency" || tempPath.Contains("DelveChestCurrencyHighShards"))
                            return new MapIcon(_iconCurrency, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                        else if (tempPath.Contains("Currency2"))
                            return new MapIcon(_iconCurrency, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize.Value * 2);
                        else if (tempPath.Contains("Currency3"))
                            return new MapIcon(_iconCurrency, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize.Value * 3);
                        else if (tempPath.Contains("DelveChestCurrencySilverCoins"))
                            return new MapIcon(_iconSilverCoin, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                        else if (tempPath.Contains("DelveChestCurrencyWisdomScrolls"))
                            return new MapIcon(_iconWisdomCurrency, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                        else if (tempPath.Contains("DelveChestCurrencyDivination"))
                            return new MapIcon(_iconDivinationCard, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                        else if (tempPath.Contains("DelveChestCurrencyMaps"))
                            return new MapIcon(_iconMap, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                        else if (tempPath.Contains("DelveChestCurrencyVaal"))
                            return new MapIcon(_iconCorrupted, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                        else if (tempPath.Contains("DelveChestCurrencySockets"))
                            return new MapIcon(_iconAdditionalSockets, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourBody2AdditionalSockets"))
                    {
                        return new MapIcon(_iconAdditionalSockets, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericAtziriFragment"))
                    {
                        return new MapIcon(_iconFragment, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericPaleCourtFragment"))
                    {
                        return new MapIcon(_iconPaleCourtComplete, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericRandomEssence")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialGenericEssence"))
                    {
                        return new MapIcon(_iconEssence, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericDivination")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourDivination")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponDivination")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsDivination")
                        )
                    {
                        return new MapIcon(_iconDivinationCard, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveAzuriteVein"))
                    {
                        int size = Settings.DelveAzuriteVeinChestSize;
                        var AzuriteImage = _iconAzurite; // this will only draw if the path end matches below
                        if (e.Path.EndsWith("1_1")) // Smallest
                        {
                            AzuriteImage = _iconAzuriteT3;
                        }
                        else if (e.Path.EndsWith("1_2")) // Medium
                        {
                            AzuriteImage = _iconAzuriteT3;
                        }
                        else if (e.Path.EndsWith("1_3")) // Large
                        {
                            AzuriteImage = _iconAzuriteT2;
                            size *= 2;
                        }
                        else if (e.Path.EndsWith("2_1")) // Huge
                        {
                            AzuriteImage = _iconAzuriteT1;
                            size *= 2;
                        }
                        return new MapIcon(AzuriteImage, size);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/Resonator3")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/Resonator4")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/Resonator5"))
                    {
                        return new MapIcon(_iconResonatorT1, Settings.DelveResonatorChestColor, Settings.DelveResonatorChestSize * 0.7f);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/Resonator2"))
                    {
                        return new MapIcon(_iconResonatorT2, Settings.DelveResonatorChestColor, Settings.DelveResonatorChestSize * 0.7f);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/Resonator1"))
                    {
                        return new MapIcon(_iconResonatorT3, Settings.DelveResonatorChestColor, Settings.DelveResonatorChestSize * 0.7f);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourMovementSpeed"))
                    {
                        return new MapIcon(_iconSpeedArmour, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialUniqueMana"))
                    {
                        return new MapIcon(_iconUniqueManaFlask, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize * 1.3f);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericRandomEnchant"))
                    {
                        return new MapIcon(_iconEnchant, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests")
                        && (e.Path.EndsWith("FossilChest") || e.Path.EndsWith("FossilChestDynamite")))
                    {
                        foreach (var @string in FossilList.T1)
                        {
                            if (e.Path.ToLower().Contains(@string.ToLower()))
                            {
                                return new MapIcon(_iconAbberantFossilT1, Settings.DelveFossilChestColor, Settings.DelveFossilChestSize);
                            }
                        }
                        foreach (var @string in FossilList.T2)
                        {
                            if (e.Path.ToLower().Contains(@string.ToLower()))
                            {
                                return new MapIcon(_iconAbberantFossilT2, Settings.DelveFossilChestColor, Settings.DelveFossilChestSize);
                            }
                        }
                        foreach (var @string in FossilList.T3)
                        {
                            if (e.Path.ToLower().Contains(@string.ToLower()))
                            {
                                return new MapIcon(_iconAbberantFossilT3, Settings.DelveFossilChestColor, Settings.DelveFossilChestSize);
                            }
                        }


                        return new MapIcon(_iconAbberantFossil, Settings.DelveFossilChestColor, Settings.DelveFossilChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityProtoVaalResonator")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/Resonator"))
                    {
                        return new MapIcon(_iconResonatorT1, Settings.DelveResonatorChestColor, Settings.DelveResonatorChestSize * 0.7f);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestMap"))
                    {
                        return new MapIcon(_iconMap, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourCorrupted")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponCorrupted")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsCorrupted")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityVaalDoubleCorrupted"))
                    {
                        return new MapIcon(_iconCorrupted, Settings.DelveCurrencyChestColor, Settings.DelveCurrencyChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Terrain/Leagues/Delve/Objects/DelveWall"))
                    {

                        switch (e.IsAlive)
                        {
                            case false:
                                return new MapIcon(_iconHiddenDoor, Settings.DelveWallColor, Settings.DelveWallSize);
                            case true:
                                return new MapIcon(_iconGate, Settings.DelveWallColor, Settings.DelveWallSize);
                        }
                    }

                    // TODO: Add useful icons to these

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/PathGeneric")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/OffPathGeneric"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/PathArmour")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/OffPathArmour")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DynamiteArmour"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/PathWeapon")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/OffPathWeapon")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DynamiteWeapon")
                        )
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/PathTrinkets")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/OffPathTrinkets")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericTrinkets")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DynamiteTrinkets")
                        )
                    {
                        return new MapIcon(_iconRareAmulet, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/ProsperoChest"))
                    {
                        return new MapIcon(_iconPerandusCoins, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericAdditionalUniques")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourMultipleUnique")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponMultipleUnique")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsMultipleUnique"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericAdditionalUnique")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsUnique")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourUnique")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponUnique")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialUniquePhysical")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialUniqueFire")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialUniqueCold")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialUniqueLightning")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialUniqueChaos")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialUniqueMana")
                    )
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericProphecyItem"))
                    {
                        return new MapIcon(_iconProphecy, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericElderItem")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsElder")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourElder")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponElder"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericShaperItem")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponShaper")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsShaper")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourShaper"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericOffering"))
                    {
                        return new MapIcon(_iconOfferingChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericDelveUnique"))
                    {
                        return new MapIcon(_iconDelveChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueOnslaught"))
                    {
                        return new MapIcon(_iconOnslaughtChest, Settings.DelvePathwayChestSize * 2);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueAnarchy"))
                    {
                        return new MapIcon(_iconOnslaughtChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueAmbushInvasion"))
                    {
                        return new MapIcon(_iconAmbushInvasionChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueDomination"))
                    {
                        return new MapIcon(_iconDominationChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueNemesis"))
                    {
                        return new MapIcon(_iconNemesisChest, Settings.DelvePathwayChestSize * 2);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueRampage"))
                    {
                        return new MapIcon(_iconRampageChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueBeyond"))
                    {
                        return new MapIcon(_iconBeyondChest, Settings.DelvePathwayChestSize);
                    }
                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityAbyssUnique"))
                    {
                        return new MapIcon(_iconAbyssChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueBloodlines"))
                    {
                        return new MapIcon(_iconBloodlinesChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueTorment"))
                    {
                        return new MapIcon(_iconTormentChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueWarbands"))
                    {
                        return new MapIcon(_iconWarbandsChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueTempest"))
                    {
                        return new MapIcon(_iconTempestChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueTalisman"))
                    {
                        return new MapIcon(_iconTalismanChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeaguePerandus"))
                    {
                        return new MapIcon(_iconPerandusChest, Settings.DelvePathwayChestSize * 2);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueBreach"))
                    {
                        return new MapIcon(_iconBreachChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueHarbinger"))
                    {
                        return new MapIcon(_iconHarbingerChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueAbyss"))
                    {
                        return new MapIcon(_iconAbyssChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueBestiary"))
                    {
                        return new MapIcon(_iconBestiaryChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGenericLeagueIncursion"))
                    {
                        return new MapIcon(_iconIncursionChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourMultipleResists"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourLife"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourAtlas"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmourOfCrafting")
                        || e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsOfCrafting"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponPhysicalDamage"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponCaster"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponExtraQuality"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponCannotRollCaster"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeaponCannotRollAttacker"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeapon30QualityUnique"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsAmulet"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsRing"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsJewel"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsAtlas"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinketsEyesOfTheGreatwolf"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGemGCP"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGemHighQuality"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGemHighLevel"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGemHighLevelQuality"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGemLevel4Special"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestMapChisels"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestMapCorrupted"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestAssortedFossils"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialArmourMinion"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialTrinketsMinion"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecialGenericMinion"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityVaalImplicit"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityVaalAtzoatlRare"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityVaalUberAtziri"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityVaalDoubleCorrupted"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityAbyssStygian"))
                    {
                        return new MapIcon(_iconStygianViseChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityAbyssJewels"))
                    {
                        return new MapIcon(_iconAbyssJewelChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityAbyssHighJewel")) // High iLvl?
                    {
                        return new MapIcon(_iconAbyssJewelChest, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityProtoVaalAzurite"))
                    {
                        return new MapIcon(_iconAzuriteT1, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityProtoVaalFossils")) // using base fossil image for now
                    {
                        return new MapIcon(_iconAbberantFossil, Settings.DelveFossilChestColor, Settings.DelveFossilChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestCityProtoVaalEmblem"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestSpecial"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGem"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestTrinkets"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestWeapon"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestArmour"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    if (e.Path.StartsWith("Metadata/Chests/DelveChests/DelveChestGeneric"))
                    {
                        return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                    }

                    // catch missing delve chests
                    if (Settings.DelvePathwayChest)
                    {
                        if (e.Path.StartsWith("Metadata/Chests/DelveChests") && !e.Path.Contains("Encounter"))
                        {
                            return new MapIcon(_iconStrongbox, Settings.DelvePathwayChestColor, Settings.DelvePathwayChestSize);
                        }
                    }
                }
            }
            return null;
        }
    }
}
