using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CthulhuCharacterSheet.Models
{
    [DataContract]
    public class Settings : ISettings
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Player { get; set; }
        [DataMember]
        public string Occupation { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public string Residence { get; set; }
        [DataMember]
        public string Birthplace { get; set; }
        [DataMember]
        public Characteristics Characteristics { get; set; }
        [DataMember]
        public Stats Stats { get; set; }
        [DataMember]
        public Dictionary<string, int> Skills { get; set; }
        [DataMember]
        public string PersonalDescription { get; set; }
        [DataMember]
        public string Ideology { get; set; }
        [DataMember]
        public string SignificantPeople { get; set; }
        [DataMember]
        public string MeaningfulLocations { get; set; }
        [DataMember]
        public string TreasuredPossessions { get; set; }
        [DataMember]
        public string Traits { get; set; }
        [DataMember]
        public string InjuriesAndScars { get; set; }
        [DataMember]
        public string PhobiasAndManias { get; set; }
        [DataMember]
        public string ArcaneTomesSpellsArtifacts { get; set; }
        [DataMember]
        public string EncountersWithEntities { get; set; }
        [DataMember]
        public List<string> GearAndPosessions { get; set; }
        [DataMember]
        public int SpendingLevel { get; set; }
        [DataMember]
        public int Cash { get; set; }
        [DataMember]
        public List<string> Assets { get; set; }
    }

    public interface ISettings
    {
        string Name { get; set; }
        string Player { get; set; }
        string Occupation { get; set; }
        int Age { get; set; }
        string Sex { get; set; }
        string Residence { get; set; }
        string Birthplace { get; set; }

        Characteristics Characteristics { get; set; }
        Stats Stats { get; set; }
        Dictionary<string, int> Skills { get; set; }

        string PersonalDescription { get; set; }
        string Ideology { get; set; }
        string SignificantPeople { get; set; }
        string MeaningfulLocations { get; set; }
        string TreasuredPossessions { get; set; }
        string Traits { get; set; }
        string InjuriesAndScars { get; set; }
        string PhobiasAndManias { get; set; }
        string ArcaneTomesSpellsArtifacts { get; set; }
        string EncountersWithEntities { get; set; }

        List<string> GearAndPosessions { get; set; }

        //TODO: Check this property type
        int SpendingLevel { get; set; }
        int Cash { get; set; }
        List<string> Assets { get; set; }

    }
}