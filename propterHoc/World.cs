using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace propterHoc
{

    [XmlInclude(typeof(ThingSaveData))]
    [XmlRoot("WorldData")]
    public class WorldData
    {

        [XmlElement]
        public String Game;
        [XmlElement]
        public String GameVersion;
        [XmlElement]
        public Int64 DateTime;
        [XmlElement]
        public Int32 WorldType;
        [XmlElement]
        public Int32 WorldSeed;
        [XmlElement]
        public Single BedrockLevel;
        [XmlElement]
        public Single SunTime;
        [XmlArray("Rooms")]
        public Room[] Rooms;
        [XmlArray("PipeNetworks")]
        [XmlArrayItem("NetworkId")]
        public Int64[] PipeNetworks;
        [XmlArray("CableNetworks")]
        [XmlArrayItem("NetworkId")]
        public Int64[] CableNetworks;
        [XmlArray("ChuteNetworks")]
        [XmlArrayItem("NetworkId")]
        public Int64[] ChuteNetworks;
        [XmlArray("SpawnPoints")]
        public ThingSaveData[] SpawnPoints;
        [XmlArray("Motherships")]
        public ThingSaveData[] Motherships;
        [XmlArray("Things")]
        public ThingSaveData[] Things;
        [XmlArray("Atmospheres")]
        public AtmosphereSaveData[] Atmospheres;
    }

    [XmlRoot]
    public class AtmosphereSaveData
    {

        [XmlElement]
        public Vector3 Position;
        [XmlElement]
        public Single Oxygen;
        [XmlElement]
        public Single Nitrogen;
        [XmlElement]
        public Single CarbonDioxide;
        [XmlElement]
        public Single Volatiles;
        [XmlElement]
        public Single Chlorine;
        [XmlElement]
        public Single Water;
        [XmlElement]
        public Single Energy;
        [XmlElement]
        public Single Volume;
        [XmlElement]
        public Vector3 Direction;
        [XmlElement]
        public Int64 NetworkReferenceId;
        [XmlElement]
        public Int64 ThingReferenceId;
        [XmlElement]
        public Single CleanBurnRate;
        [XmlElement]
        public Int64 MothershipReferenceId;
    }

    [XmlInclude(typeof(AtmosphericItemSaveData))]
    public class SuitSaveData : AtmosphericItemSaveData
    {

        [XmlElement]
        public Single OutputSetting;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class DynamicGasCanisterSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public Single OutputSetting;
    }

    [XmlInclude(typeof(ThingSaveData))]
    public class DynamicThingSaveData : ThingSaveData
    {

        [XmlElement]
        public Int64 ParentReferenceId;
        [XmlElement]
        public Int32 ParentSlotId;
        [XmlElement]
        public Boolean Dragged;
        [XmlElement]
        public Int32 DraggedInteractionIndex;
        [XmlElement]
        public Vector3 DragOffset;
        [XmlElement]
        public Vector3 Velocity;
        [XmlElement]
        public Vector3 AngularVelocity;
        [XmlElement]
        public Single HealthCurrent;
    }

    [XmlInclude(typeof(MachineSaveData))]
    public class AirConditionerSaveData : MachineSaveData
    {

        [XmlElement]
        public Single GoalTemperature;
    }

    [XmlInclude(typeof(MachineSaveData))]
    public class BatterySaveData : MachineSaveData
    {

        [XmlElement]
        public Single PowerStored;
    }

    [XmlInclude(typeof(StructureSaveData))]
    public class CableSaveSaveData : StructureSaveData
    {

        [XmlElement]
        public Int64 CableNetworkId;
    }

    [XmlInclude(typeof(StructureSaveData))]
    public class FabricatorSaveData : StructureSaveData
    {

        [XmlArray("Jobs")]
        [XmlArrayItem("Job")]
        public FabricatorJob[] FabricatorJobs;
    }

    [XmlInclude(typeof(LogicBaseSaveData))]
    public class LogicBatchWriterSaveData : LogicBaseSaveData
    {

        [XmlElement]
        public Int32 CurrentOutputHash;
        [XmlElement]
        public Int64 CurrentInputId;
        [XmlElement]
        public LogicType LogicType;
    }

    [XmlInclude(typeof(LogicBaseSaveData))]
    public class LogicMathSaveData : LogicBaseSaveData
    {

        [XmlElement]
        public Int64 Input1;
        [XmlElement]
        public Int64 Input2;
        [XmlElement]
        public Int64 Input3;
    }

    [XmlInclude(typeof(StructureSaveData))]
    public class LogicBaseSaveData : StructureSaveData
    {

        [XmlElement]
        public Single Setting;
    }

    [XmlInclude(typeof(LogicBaseSaveData))]
    public class LogicReaderSaveData : LogicBaseSaveData
    {

        [XmlElement]
        public Int64 CurrentDeviceId;
        [XmlElement]
        public Int32 InputIndex;
    }

    [XmlInclude(typeof(LogicBaseSaveData))]
    public class LogicWriterSaveData : LogicBaseSaveData
    {

        [XmlElement]
        public Int64 CurrentOutputId;
        [XmlElement]
        public Int64 CurrentInputId;
        [XmlElement]
        public LogicType LogicType;
    }

    [XmlInclude(typeof(StructureSaveData))]
    public class SolarPanelSaveData : StructureSaveData
    {

        [XmlElement]
        public Single Horizontal;
    }

    [XmlInclude(typeof(StructureSaveData))]
    public class SorterSaveData : StructureSaveData
    {

        [XmlElement]
        public Byte CurrentOutput;
        [XmlArray("Filters")]
        [XmlArrayItem("Filter")]
        public FilterReference[] FilterReferences;
    }

    [XmlInclude(typeof(StructureSaveData))]
    public class StackerSaveData : StructureSaveData
    {

        [XmlElement]
        public Single Setting;
    }

    [XmlInclude(typeof(MachineSaveData))]
    public class TransformerSaveData : MachineSaveData
    {

        [XmlElement]
        public Single OutputSetting;
    }

    [XmlInclude(typeof(EntitySaveData))]
    public class ChickSaveData : EntitySaveData
    {

        [XmlElement]
        public Single CurrentGrowthTime;
    }

    [XmlInclude(typeof(EntitySaveData))]
    public class ChickenSaveData : EntitySaveData
    {

        [XmlElement]
        public Single LayEggTimer;
    }

    [XmlInclude(typeof(EntitySaveData))]
    public class HumanSaveData : EntitySaveData
    {

        [XmlElement]
        public Byte GenderIndex;
        [XmlElement]
        public Byte HairIndex;
        [XmlElement]
        public Byte FacialhairIndex;
        [XmlElement]
        public Byte EyeIndex;
        [XmlElement]
        public Byte EyeColourIndex;
        [XmlElement]
        public Byte SkinCololurIndex;
        [XmlElement]
        public Byte HairColourIndex;
        [XmlElement]
        public Byte SkinIndex;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class EntitySaveData : DynamicThingSaveData
    {

        [XmlElement]
        public EntityState State;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class AtmosphericItemSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public Single LeakRatio;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class BatteryCellSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public Single PowerStored;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class BrainSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public UInt64 ClientSteamId;
    }

    [XmlInclude(typeof(MotherboardSaveData))]
    public class CircuitboardSaveData : MotherboardSaveData
    {

        [XmlElement]
        public Int32 LastIndex;
        [XmlElement]
        public String FilterString;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class ConsumableSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public Single Quantity;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class FertilizedEggSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public Single EggHatchTime;
    }

    [XmlInclude(typeof(AtmosphericItemSaveData))]
    public class GasMaskSaveData : AtmosphericItemSaveData
    {

    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class MotherboardSaveData : DynamicThingSaveData
    {

        [XmlArray]
        public Int64[] LinkedDeviceReferences;
        [XmlElement]
        public Int32 Flag;
        [XmlElement]
        public Int64 MasterMotherboard;
    }

    [XmlInclude(typeof(StackableSaveData))]
    public class PlantSaveData : StackableSaveData
    {

        [XmlElement]
        public Single StageTime;
        [XmlElement]
        public Int32 Stage;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class RoadflareSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public Single Lifetime;
    }

    [XmlInclude(typeof(StackableSaveData))]
    public class SlagSaveData : StackableSaveData
    {

        [XmlArray("CreatedReagents")]
        [XmlArrayItem("Reagent")]
        public ReagentSaveData[] CreatedReagents;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class StackableSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public Int32 Quantity;
        [XmlElement]
        public Int64 MothershipReferenceId;
    }

    [XmlInclude(typeof(CircuitboardSaveData))]
    public class AirContolCircuitboardSaveData : CircuitboardSaveData
    {

        [XmlArray("AirControlVents")]
        [XmlArrayItem("ActiveVent")]
        public AirControlVent[] AirControlVents;
    }

    [XmlInclude(typeof(MotherboardSaveData))]
    public class LogicMotherboardSaveData : MotherboardSaveData
    {

        [XmlArray("LogicStates")]
        [XmlArrayItem("LogicState")]
        public LogicStateSave[] LogicStates;
        [XmlElement]
        public Int32 CurrentLogicIndex;
    }

    [XmlInclude(typeof(MotherboardSaveData))]
    public class MultiMotherboardSaveData : MotherboardSaveData
    {

        [XmlElement]
        public Int32 CurrentTab;
    }

    [XmlInclude(typeof(MotherboardSaveData))]
    public class SolarControlSaveData : MotherboardSaveData
    {

        [XmlElement]
        public Single TargetHorizontal;
        [XmlElement]
        public Single TargetVertical;
    }

    [XmlInclude(typeof(MultiMotherboardSaveData))]
    public class SorterMotherboardSaveData : MultiMotherboardSaveData
    {

    }

    [XmlInclude(typeof(StructureSaveData))]
    public class ChuteSaveData : StructureSaveData
    {

        [XmlElement]
        public Int64 ChuteNetworkId;
    }

    [XmlInclude(typeof(StructureSaveData))]
    public class DeviceAtmosphericSaveData : StructureSaveData
    {

        [XmlElement]
        public Single OutputSetting;
    }

    [XmlInclude(typeof(DeviceAtmosphericSaveData))]
    public class FurnaceSaveData : DeviceAtmosphericSaveData
    {

    }

    [XmlInclude(typeof(StructureSaveData))]
    public class MachineSaveData : StructureSaveData
    {

        [XmlElement]
        public Int32 MachineState;
        [XmlElement]
        public Single GoalPressure;
    }

    [XmlInclude(typeof(MachineSaveData))]
    public class MixingMachineSaveData : MachineSaveData
    {

        [XmlElement]
        public Single Ratio;
        [XmlElement]
        public Single OutputMaxPressure;
    }

    [XmlInclude(typeof(StructureSaveData))]
    public class PipeSaveData : StructureSaveData
    {

        [XmlElement]
        public Int64 PipeNetworkId;
        [XmlElement]
        public Boolean IsBurst;
    }

    [XmlInclude(typeof(ThingSaveData))]
    public class StructureSaveData : ThingSaveData
    {

        [XmlElement]
        public Int32 CurrentBuildState;
        [XmlElement]
        public Int64 MothershipReferenceId;
    }

    [XmlRoot]
    public class ThingSaveData
    {

        [XmlElement]
        public Int64 ReferenceId;
        [XmlElement]
        public String PrefabName;
        [XmlElement]
        public String CustomName;
        [XmlElement]
        public Vector3 WorldPosition;
        [XmlElement]
        public Quaternion WorldRotation;
        [XmlArray("States")]
        [XmlArrayItem("State")]
        public InteractableState[] States;
        [XmlElement]
        public Boolean IsCustomName;
        [XmlElement]
        public Int32 CustomColorIndex;
        [XmlElement]
        public UInt64 OwnerSteamId;
        [XmlArray("Reagents")]
        [XmlArrayItem("Reagent")]
        public ReagentSaveData[] Reagents;
        [XmlElement]
        public Boolean Indestructable;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class DynamiteSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public Single Lifetime;
    }

    [XmlInclude(typeof(DynamicThingSaveData))]
    public class GrenadeSaveData : DynamicThingSaveData
    {

        [XmlElement]
        public Single Lifetime;
    }

    [XmlRoot]
    public class ReagentSaveData
    {

        [XmlElement]
        public String TypeName;
        [XmlElement]
        public Single Quantity;
    }

    [XmlRoot]
    public class Room
    {

        [XmlArray("Grids")]
        [XmlArrayItem("Grid")]
        public Grid3[] Grids;
    }

    [Serializable]
    public struct Vector3
    {
        public System.Single x;
        public System.Single y;
        public System.Single z;
    }
    [XmlRoot]
    public class FabricatorJob
    {

    }

    public enum LogicType
    {
        None = 0,
        Power = 1,
        Open = 2,
        Mode = 3,
        Error = 4,
        Lock = 10,
        Pressure = 5,
        Temperature = 6,
        PressureExternal = 7,
        PressureInternal = 8,
        Activate = 9,
        Charge = 11,
        Setting = 12,
        Reagents = 13,
        RatioOxygen = 14,
        RatioCarbonDioxide = 15,
        RatioNitrogen = 16,
        RatioPollutant = 17,
        RatioVolatiles = 18,
        RatioWater = 19,
        Horizontal = 20,
        Vertical = 21,
        SolarAngle = 22,
        Maximum = 23,
        Ratio = 24,
        PowerPotential = 25,
        PowerActual = 26,
        Quantity = 27,
        On = 28,
        ImportQuantity = 29,
        ImportSlotOccupant = 30,
        ExportQuantity = 31,
        ExportSlotOccupant = 32,
        RequiredPower = 33,
        HorizontalRatio = 34,
        VerticalRatio = 35,
    }

    [XmlRoot]
    public class FilterReference
    {

        [XmlElement]
        public String PrefabName;
        [XmlElement]
        public Class SlotType;
    }

    public enum EntityState
    {
        Alive = 0,
        Dead = 1,
        Unconscious = 2,
    }

    [XmlRoot]
    public class AirControlVent
    {

        [XmlElement]
        public Int64 ReferenceId;
        [XmlElement]
        public VentDirection Direction;
    }

    [XmlRoot]
    public class LogicStateSave
    {

        [XmlElement]
        public String DisplayName;
        [XmlArray("Conditions")]
        [XmlArrayItem("Condition")]
        public LogicConditionSave[] Conditions;
        [XmlArray("Actions")]
        [XmlArrayItem("Action")]
        public LogicActionSave[] Actions;
        [XmlElement]
        public Boolean IsTriggered;
        [XmlElement]
        public Int32 NextLogicIndex;
    }

    [Serializable]
    public struct Quaternion
    {
        public System.Single x;
        public System.Single y;
        public System.Single z;
        public System.Single w;
    }
    [XmlRoot]
    public class InteractableState
    {

        [XmlElement]
        public String StateName;
        [XmlElement]
        public Int32 State;
    }

    public enum Class
    {
        None = 0,
        Helmet = 1,
        Suit = 2,
        Back = 3,
        GasFilter = 4,
        GasCanister = 5,
        Motherboard = 6,
        Circuitboard = 7,
        DataDisk = 8,
        Organ = 9,
        Ore = 10,
        Plant = 11,
        Uniform = 12,
        Entity = 13,
        Battery = 14,
        Egg = 15,
        Belt = 16,
        Tool = 17,
        Appliance = 18,
        Ingot = 19,
        Torpedo = 20,
        Cartridge = 21,
    }

    public enum VentDirection
    {
        Inward = 1,
        Outward = 0,
    }

    [Serializable]
    public struct Grid3
    {
        public System.Int32 x;
        public System.Int32 y;
        public System.Int32 z;
    }
    [XmlRoot]
    public class LogicConditionSave
    {

        [XmlElement]
        public Int64 DeviceReferenceId;
        [XmlElement]
        public LogicType Type;
        [XmlElement]
        public ConditionOperation Operation;
        [XmlElement]
        public Single Value;
        [XmlElement]
        public Boolean IsDisconnected;
        [XmlElement]
        public Boolean IsTrue;
    }

    [XmlRoot]
    public class LogicActionSave
    {

        [XmlElement]
        public Int64 DeviceReferenceId;
        [XmlElement]
        public LogicType Type;
        [XmlElement]
        public Single Value;
    }

    public enum ConditionOperation
    {
        Equals = 0,
        Greater = 1,
        Less = 2,
        NotEquals = 3,
    }

    public static class Serialization
    {
        public static List<Type> Types = new List<Type>{
typeof(AtmosphereSaveData), typeof(SuitSaveData), typeof(DynamicGasCanisterSaveData), typeof(DynamicThingSaveData), typeof(AirConditionerSaveData), typeof(BatterySaveData), typeof(CableSaveSaveData), typeof(FabricatorSaveData), typeof(LogicBatchWriterSaveData), typeof(LogicMathSaveData), typeof(LogicBaseSaveData), typeof(LogicReaderSaveData), typeof(LogicWriterSaveData), typeof(SolarPanelSaveData), typeof(SorterSaveData), typeof(StackerSaveData), typeof(TransformerSaveData), typeof(ChickSaveData), typeof(ChickenSaveData), typeof(HumanSaveData), typeof(EntitySaveData), typeof(AtmosphericItemSaveData), typeof(BatteryCellSaveData), typeof(BrainSaveData), typeof(CircuitboardSaveData), typeof(ConsumableSaveData), typeof(FertilizedEggSaveData), typeof(GasMaskSaveData), typeof(MotherboardSaveData), typeof(PlantSaveData), typeof(RoadflareSaveData), typeof(SlagSaveData), typeof(StackableSaveData), typeof(AirContolCircuitboardSaveData), typeof(LogicMotherboardSaveData), typeof(MultiMotherboardSaveData), typeof(SolarControlSaveData), typeof(SorterMotherboardSaveData), typeof(ChuteSaveData), typeof(DeviceAtmosphericSaveData), typeof(FurnaceSaveData), typeof(MachineSaveData), typeof(MixingMachineSaveData), typeof(PipeSaveData), typeof(StructureSaveData), typeof(ThingSaveData), typeof(DynamiteSaveData), typeof(GrenadeSaveData), typeof(ReagentSaveData), typeof(Room), typeof(Vector3), typeof(FabricatorJob), typeof(LogicType), typeof(LogicType), typeof(FilterReference), typeof(EntityState), typeof(EntityState), typeof(AirControlVent), typeof(LogicStateSave), typeof(Quaternion), typeof(InteractableState), typeof(Class), typeof(Class), typeof(VentDirection), typeof(VentDirection), typeof(Grid3), typeof(LogicConditionSave), typeof(LogicActionSave), typeof(ConditionOperation), typeof(ConditionOperation)};
    };
}
