using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Clipeity
{
    [Serializable]
    public class ItemInfoCollection : List<ItemInfo>
    {
        public static ItemInfoCollection Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    var xs = new XmlSerializer(typeof (ItemInfoCollection));
                    var itemInfoCollection = xs.Deserialize(fs) as ItemInfoCollection;
                    fs.Close();
                    return itemInfoCollection;
                }
            }
            return new ItemInfoCollection();
        }

        public static void Save(ItemInfoCollection itemInfoCollection, string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                var xs = new XmlSerializer(typeof (ItemInfoCollection));
                xs.Serialize(fs, itemInfoCollection);
                fs.Flush();
                fs.Close();
            }
        }

        public void AddOrUpdate(ItemInfo data)
        {
            List<ItemInfo> matchingItems = FindAll(x => x.Id == data.Id);
            if (matchingItems.Count > 0)
            {
                foreach (ItemInfo matchingItem in matchingItems)
                {
                    matchingItem.ButtonLabel = data.ButtonLabel;
                    matchingItem.CopyThisToClipboard = data.CopyThisToClipboard;
                }
            }
            else
            {
                Add(data);
            }
        }

        public void RemoveItem(ItemInfo data)
        {
            RemoveAll(x => x.Id == data.Id);
        }
    }
}