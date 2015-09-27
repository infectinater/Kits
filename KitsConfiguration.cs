using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace unturned.ROCKS.Kits
{
    public class KitsConfiguration : IRocketPluginConfiguration
    {
        [XmlArrayItem(ElementName = "Kit")]
        public List<Kit> Kits;
        public int GlobalCooldown;

        public void LoadDefaults()
        {
            GlobalCooldown = 10;
            Kits = new List<Kit>() {
                new Kit() { Cooldown = 10, Name = "Sniper", Items = new List<KitItem>() { new KitItem(245, 1), new KitItem(81, 2), new KitItem(109, 1), new KitItem(111, 3) }},
            };
        }
    }

    public class Kit
    {
        public Kit() { }

        public string Name;

        [XmlArrayItem(ElementName = "Item")]
        public List<KitItem> Items;
        public int Cooldown = 0;
    }

    public class KitItem{

        public KitItem(){ }

        public KitItem(ushort itemId, byte amount)
        {
            ItemId = itemId;
            Amount = amount;
        }

        [XmlAttribute("id")]
        public ushort ItemId;

        [XmlAttribute("amount")]
        public byte Amount;
    }
}
