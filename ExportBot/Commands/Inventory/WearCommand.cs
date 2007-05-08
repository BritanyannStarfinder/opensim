using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

using libsecondlife;
using libsecondlife.Packets;
using libsecondlife.InventorySystem;

namespace libsecondlife.TestClient
{
    public class WearCommand : Command
    {
		public WearCommand(TestClient testClient)
        {
            Name = "wear";
            Description = "Wear an outfit folder from inventory.";
        }

        public override string Execute(string[] args, LLUUID fromAgentID)
        {
            return "Broken until someone fixes me";

            //string target = String.Empty;
            //for (int ct = 0; ct < args.Length; ct++)
            //    target = target + args[ct] + " ";
            //target = target.TrimEnd();

            //Client.Inventory.DownloadInventory();
            //InventoryFolder folder = Client.Inventory.getFolder(target);
            //if (folder != null)
            //{
            //    Client.Appearance.WearOutfit(folder);
            //    return "Outfit " + target + " worn.";
            //}

            //return "Unable to find: " + target;
        }
	}
}