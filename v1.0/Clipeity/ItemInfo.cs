using System;
using System.Xml.Serialization;

namespace Clipeity
{
    [Serializable]
    public class ItemInfo
    {
        public ItemInfo()
        {
            Id = Guid.NewGuid().ToString();
            ButtonLabel = string.Empty;
            CopyThisToClipboard = string.Empty;
        }

        public ItemInfo(string id, string buttonLabel, string copyThisToClipboard)
        {
            Id = id;
            ButtonLabel = buttonLabel;
            CopyThisToClipboard = copyThisToClipboard;
        }

        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute]
        public string ButtonLabel { get; set; }

        [XmlAttribute]
        public string CopyThisToClipboard { get; set; }
    }
}