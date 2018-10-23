using System.Runtime.Serialization;

namespace CthulhuCharacterSheet.Models
{
    [DataContract]
    public class Characteristics : ICharacteristics
    {
        [DataMember]
        public int Strength { get; set; }
        [DataMember]
        public int Dexterity { get; set; }
        [DataMember]
        public int Integlligence { get; set; }
        [DataMember]
        public int Constitution { get; set; }
        [DataMember]
        public int Appearance { get; set; }
        [DataMember]
        public int Power { get; set; }
        [DataMember]
        public int Size { get; set; }
        [DataMember]
        public int Education { get; set; }
        [DataMember]
        public int MoveRate { get; set; }
        [DataMember]
        public int DamageBonus { get; set; }
        [DataMember]
        public int Build { get; set; }
    }

    [DataContract]
    public class Stats : IStats
    {
        public bool MajorWound { get; set; }
        [DataMember]
        public int CurrentHitPoints { get; set; }
        [DataMember]
        public int MaxHitPoints { get; set; }
        [DataMember]
        public int CurrentSanity { get; set; }
        [DataMember]
        public int MaxSanity { get; set; }
        [DataMember]
        public bool IsTempInsane { get; set; }
        [DataMember]
        public bool IsIndefInsane { get; set; }
        [DataMember]
        public int Luck { get; set; }
        [DataMember]
        public int MagicPoints { get; set; }
    }

    public interface ICharacteristics
    {
        int Strength { get; set; }
        int Dexterity { get; set; }
        int Integlligence { get; set; }
        int Constitution { get; set; }
        int Appearance { get; set; }
        int Power { get; set; }
        int Size { get; set; }
        int Education { get; set; }
        int MoveRate { get; set; }
    }

    public interface IStats
    {
        bool MajorWound { get; set; }
        int CurrentHitPoints { get; set; }
        int MaxHitPoints { get; set; }
        int CurrentSanity { get; set; }
        int MaxSanity { get; set; }
        bool IsTempInsane { get; set; }
        bool IsIndefInsane { get; set; }
        int Luck { get; set; }
        int MagicPoints { get; set; }
    }
}