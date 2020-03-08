using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationTool.model
{
    class CharacterClass
    {

        Dice hitDice;
        int initialHitPoints;
        int HitPoints;

        string proficiencies;

        string equipment;

        ClassTable classTable;

        public CharacterClass(Dice hitDice, int initialHitPoints, int hitPoints, string proficiencies, string equipment, ClassTable classTable)
        {
            this.HitDice = hitDice;
            this.InitialHitPoints = initialHitPoints;
            HitPoints1 = hitPoints;
            this.Proficiencies = proficiencies;
            this.Equipment = equipment;
            this.ClassTable = classTable;
        }

        public int InitialHitPoints { get => initialHitPoints; set => initialHitPoints = value; }
        public int HitPoints1 { get => HitPoints; set => HitPoints = value; }
        public string Proficiencies { get => proficiencies; set => proficiencies = value; }
        public string Equipment { get => equipment; set => equipment = value; }
        internal Dice HitDice { get => hitDice; set => hitDice = value; }
        internal ClassTable ClassTable { get => classTable; set => classTable = value; }
    }
}
